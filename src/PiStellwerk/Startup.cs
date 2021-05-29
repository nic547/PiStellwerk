// <copyright file="Startup.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PiStellwerk.Commands;
using PiStellwerk.Database;
using PiStellwerk.Services;
using PiStellwerk.Util;

namespace PiStellwerk
{
    /// <summary>
    /// Startup class of the WebAPI.
    /// </summary>
    public class Startup
    {
        // TODO: Setting-ify
        private const string _userContentDirectory = "userContent";
        private const string _generatedContentDirectory = "generatedContent";
        private const string _engineImageDirectory = "engineimages";

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration"><see cref="Configuration"/>.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            using var client = new StwDbContext();
            if (client.Database.GetPendingMigrations().Any())
            {
                ConsoleService.PrintHighlightedMessage("Applying database migrations.");
                client.Database.Migrate();
                ConsoleService.PrintHighlightedMessage("Database migrations applied.");
            }
            else
            {
                ConsoleService.PrintMessage("No database migrations necessary.");
            }

            // UNCOMMENT TO ADD TEST DATA.
            // client.Engines.AddRange(TestDataService.GetEngines());
            // client.SaveChanges();
        }

        /// <summary>
        /// Gets some configuration.
        /// TODO: Find out what exactly this configuration is, sounds pretty useful.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">IDK.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(opts =>
            {
                opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            services.AddEntityFrameworkSqlite().AddDbContext<StwDbContext>();

            services.AddHostedService<SessionService>();

            var commandSystem = CommandSystemFactory.FromConfig(Configuration);
            _ = commandSystem.LoadEnginesFromSystem(new StwDbContext());
            services.AddSingleton(commandSystem);

            services.AddSingleton(new StatusService(commandSystem));
            var sessionService = new SessionService();
            services.AddSingleton(sessionService);
            services.AddSingleton<IEngineService>(new EngineService(commandSystem, sessionService));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PiStellwerk API", Version = "v1" });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, "PiStellwerk.xml");
                c.IncludeXmlComments(filePath);
            });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">IDK.</param>
        /// <param name="env">IDK either.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "PiStellwerk API V1");
                });
            }

            app.UseDefaultFiles();

            EnsureContentDirectoriesExist(env);

            RunImageSetup(env);

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new CompositeFileProvider(
                    new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, _userContentDirectory)),
                    new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, _generatedContentDirectory)),
                    new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, "wwwroot"))),
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void EnsureContentDirectoriesExist(IHostEnvironment env)
        {
            Directory.CreateDirectory(Path.Combine(env.ContentRootPath, _userContentDirectory, _engineImageDirectory));
            Directory.CreateDirectory(Path.Combine(env.ContentRootPath, _generatedContentDirectory, _engineImageDirectory));
        }

        private static async void RunImageSetup(IHostEnvironment env)
        {
            var system = new Images.ImageSystem(
                new StwDbContext(),
                Path.Combine(env.ContentRootPath, _userContentDirectory, _engineImageDirectory),
                Path.Combine(env.ContentRootPath, _generatedContentDirectory, _engineImageDirectory));
            await Task.Run(system.RunImageSetup);
        }
    }
}