﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SimplStudy.DBContexts;

#nullable disable

namespace SimplStudy.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230811081420_InitialMigration1")]
    partial class InitialMigration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.AddressesPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdressesPoints");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressesPointId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressesPointId");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateReceipt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Item", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("BuyerId")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<int>("DeliveryId")
                        .HasColumnType("integer");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "BuyerId", "SellerId", "DeliveryId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SellerId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressesPointId")
                        .HasColumnType("integer");

                    b.Property<int>("HoursProduction")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressesPointId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressesPointId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressesPointId");

                    b.HasIndex("SellerId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Buyer", b =>
                {
                    b.HasOne("SimplStudy.Models.DataBaseModels.AddressesPoint", "ActiveAddressesPoint")
                        .WithMany("Buyers")
                        .HasForeignKey("AddressesPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveAddressesPoint");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Item", b =>
                {
                    b.HasOne("SimplStudy.Models.DataBaseModels.Buyer", "ActiveBuyer")
                        .WithMany("Items")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplStudy.Models.DataBaseModels.Delivery", "ActiveDelivery")
                        .WithMany("Items")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplStudy.Models.DataBaseModels.Order", "ActiveOrder")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplStudy.Models.DataBaseModels.Product", "ActiveProduct")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplStudy.Models.DataBaseModels.Seller", "ActiveSeller")
                        .WithMany("Items")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveBuyer");

                    b.Navigation("ActiveDelivery");

                    b.Navigation("ActiveOrder");

                    b.Navigation("ActiveProduct");

                    b.Navigation("ActiveSeller");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Manager", b =>
                {
                    b.HasOne("SimplStudy.Models.DataBaseModels.AddressesPoint", "ActiveAddressesPoint")
                        .WithMany("Managers")
                        .HasForeignKey("AddressesPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveAddressesPoint");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Product", b =>
                {
                    b.HasOne("SimplStudy.Models.DataBaseModels.Category", "ActiveCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveCategory");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Store", b =>
                {
                    b.HasOne("SimplStudy.Models.DataBaseModels.AddressesPoint", "ActiveAddressesPoint")
                        .WithMany("Stores")
                        .HasForeignKey("AddressesPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimplStudy.Models.DataBaseModels.Seller", "ActiveSeller")
                        .WithMany("Stores")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveAddressesPoint");

                    b.Navigation("ActiveSeller");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.AddressesPoint", b =>
                {
                    b.Navigation("Buyers");

                    b.Navigation("Managers");

                    b.Navigation("Stores");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Buyer", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Delivery", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Product", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("SimplStudy.Models.DataBaseModels.Seller", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}