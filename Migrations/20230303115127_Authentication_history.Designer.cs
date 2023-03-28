﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using danj_backend.DB;

#nullable disable

namespace danj_backend.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20230303115127_Authentication_history")]
    partial class Authentication_history
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("danj_backend.Model.Authentication_history", b =>
                {
                    b.Property<int>("authId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("authId"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("isValid")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("preserve_data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("savedAuth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("authId");

                    b.ToTable("authentication_history");
                });

            modelBuilder.Entity("danj_backend.Model.Tokenization", b =>
                {
                    b.Property<int>("tokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tokenId"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("isExpired")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("isValid")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("tokenId");

                    b.ToTable("tokenization");
                });

            modelBuilder.Entity("danj_backend.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middlename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("verified")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
