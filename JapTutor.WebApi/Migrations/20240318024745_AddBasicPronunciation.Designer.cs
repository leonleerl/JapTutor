﻿// <auto-generated />
using JapTutor.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JapTutor.WebApi.Migrations
{
    [DbContext(typeof(JapTutorDbContext))]
    [Migration("20240318024745_AddBasicPronunciation")]
    partial class AddBasicPronunciation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("JapTutor.WebApi.Models.BasicPronunciation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BasicPronunciations");
                });
#pragma warning restore 612, 618
        }
    }
}
