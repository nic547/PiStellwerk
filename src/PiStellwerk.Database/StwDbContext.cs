﻿// <copyright file="StwDbContext.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PiStellwerk.Data;

namespace PiStellwerk.Database
{
    /// <summary>
    /// <inheritdoc cref="DbContext"/>
    /// </summary>
    public class StwDbContext : DbContext
    {
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="StwDbContext"/> class.
        /// </summary>
        /// <param name="connectionString">The SQLite connection string to use. Default: "Filename=StwDatabase.db".</param>
        public StwDbContext(string connectionString = "Filename=StwDatabase.db;cache=shared")
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets a collection of engines in the database.
        /// </summary>
        public DbSet<Engine> Engines => Set<Engine>();

        public DbSet<EngineImage> EngineImages => Set<EngineImage>();

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engine>()
            .Property(e => e.Tags)
            .HasConversion(v => string.Join(";", v), v => v.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList());

            base.OnModelCreating(modelBuilder);
        }
    }
}