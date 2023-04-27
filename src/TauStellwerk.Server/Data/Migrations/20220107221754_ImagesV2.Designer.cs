// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TauStellwerk.Server.Data;
using TauStellwerk.Server.Database;

#nullable disable

namespace TauStellwerk.Server.Database.Migrations
{
    [DbContext(typeof(StwDbContext))]
    [Migration("20220107221754_ImagesV2")]
    partial class ImagesV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("EngineTag", b =>
                {
                    b.Property<int>("EnginesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EnginesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("EngineTag");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.DccFunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EngineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Number")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EngineId");

                    b.ToTable("DccFunction");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.ECoSEngineData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ECoSEngineData");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Address")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ECoSEngineDataId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastImageUpdate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUsed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("SpeedSteps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TopSpeed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Created");

                    b.HasIndex("ECoSEngineDataId");

                    b.HasIndex("LastUsed");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.EngineImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EngineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EngineId");

                    b.ToTable("EngineImages");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("EngineTag", b =>
                {
                    b.HasOne("TauStellwerk.Database.Model.Engine", null)
                        .WithMany()
                        .HasForeignKey("EnginesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TauStellwerk.Database.Model.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.DccFunction", b =>
                {
                    b.HasOne("TauStellwerk.Database.Model.Engine", null)
                        .WithMany("Functions")
                        .HasForeignKey("EngineId");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.Engine", b =>
                {
                    b.HasOne("TauStellwerk.Database.Model.ECoSEngineData", "ECoSEngineData")
                        .WithMany()
                        .HasForeignKey("ECoSEngineDataId");

                    b.Navigation("ECoSEngineData");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.EngineImage", b =>
                {
                    b.HasOne("TauStellwerk.Database.Model.Engine", null)
                        .WithMany("Images")
                        .HasForeignKey("EngineId");
                });

            modelBuilder.Entity("TauStellwerk.Database.Model.Engine", b =>
                {
                    b.Navigation("Functions");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
