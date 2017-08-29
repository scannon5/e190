﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using e190.Model;

namespace e190.Migrations
{
    [DbContext(typeof(PieContext))]
    [Migration("20170829122827_Added_IsSweet_field")]
    partial class Added_IsSweet_field
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("e190.Model.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Filling");

                    b.Property<bool>("IsSweet");

                    b.HasKey("PieId");

                    b.ToTable("Pies");
                });
        }
    }
}
