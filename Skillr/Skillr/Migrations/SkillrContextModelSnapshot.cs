﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skillr.Models;

namespace Skillr.Migrations
{
    [DbContext(typeof(SkillrContext))]
    partial class SkillrContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Skillr.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Insertion");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("OnProjectUntil");

                    b.Property<bool>("PersonAvailable");

                    b.Property<int>("SkillID");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Skillr.Models.Projects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonID");

                    b.Property<int>("ProjectDuration");

                    b.Property<DateTime>("ProjectEndDate");

                    b.Property<string>("ProjectNR")
                        .IsRequired();

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<DateTime>("ProjectStartDate");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Skillr.Models.Skills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Certificate");

                    b.Property<DateTime>("CertificateValidFrom");

                    b.Property<DateTime>("CertificateValidUntil");

                    b.Property<int?>("PersonID");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("SkillLevel");

                    b.Property<int>("YearsExperience");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Skillr.Models.Projects", b =>
                {
                    b.HasOne("Skillr.Models.Person", "Person")
                        .WithMany("Projects")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Skillr.Models.Skills", b =>
                {
                    b.HasOne("Skillr.Models.Person")
                        .WithMany("Skills")
                        .HasForeignKey("PersonID");
                });
#pragma warning restore 612, 618
        }
    }
}
