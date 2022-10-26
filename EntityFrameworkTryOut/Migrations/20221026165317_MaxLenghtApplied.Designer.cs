﻿// <auto-generated />
using System;
using EntityFrameworkTryOut.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkTryOut.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221026165317_MaxLenghtApplied")]
    partial class MaxLenghtApplied
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkTryOut.DataModels.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassLanguage")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaxClassSize")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ClassID");

                    b.HasIndex("StudentID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("EntityFrameworkTryOut.DataModels.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentAge")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityFrameworkTryOut.DataModels.Class", b =>
                {
                    b.HasOne("EntityFrameworkTryOut.DataModels.Student", null)
                        .WithMany("StudentClasses")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("EntityFrameworkTryOut.DataModels.Student", b =>
                {
                    b.Navigation("StudentClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
