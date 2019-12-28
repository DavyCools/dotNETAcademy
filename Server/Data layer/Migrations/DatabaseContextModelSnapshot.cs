﻿// <auto-generated />
using System;
using Data_layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_layer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_layer.Model.Admin", b =>
                {
                    b.Property<string>("AzureId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("AzureId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Data_layer.Model.Bestelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("KlantAzureId");

                    b.Property<double>("TotaalPrijs");

                    b.HasKey("Id");

                    b.HasIndex("KlantAzureId");

                    b.ToTable("Bestellingen");
                });

            modelBuilder.Entity("Data_layer.Model.BestellingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal");

                    b.Property<int?>("BestellingId");

                    b.Property<int?>("ProductID");

                    b.HasKey("Id");

                    b.HasIndex("BestellingId");

                    b.HasIndex("ProductID");

                    b.ToTable("BestellingItem");
                });

            modelBuilder.Entity("Data_layer.Model.Klant", b =>
                {
                    b.Property<string>("AzureId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("AzureId");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("Data_layer.Model.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving")
                        .HasMaxLength(120);

                    b.Property<string>("Categorie");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FotoURLCard");

                    b.Property<bool>("IsBuyable");

                    b.Property<string>("LangeBeschrijving");

                    b.Property<int>("OrderNumber");

                    b.Property<double>("Prijs");

                    b.Property<string>("Titel")
                        .IsRequired();

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("Data_layer.Model.Winkelwagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("KlantAzureId");

                    b.Property<double>("TotaalPrijs");

                    b.HasKey("Id");

                    b.HasIndex("KlantAzureId");

                    b.ToTable("Winkelwagens");
                });

            modelBuilder.Entity("Data_layer.Model.WinkelwagenItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal");

                    b.Property<int?>("ProductID");

                    b.Property<int?>("WinkelwagenId");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("WinkelwagenId");

                    b.ToTable("WinkelwagenItem");
                });

            modelBuilder.Entity("Data_layer.Model.Cursus", b =>
                {
                    b.HasBaseType("Data_layer.Model.Product");

                    b.Property<int?>("TrajectID");

                    b.HasIndex("Titel")
                        .IsUnique();

                    b.HasIndex("TrajectID");

                    b.HasDiscriminator().HasValue("Cursus");
                });

            modelBuilder.Entity("Data_layer.Model.Traject", b =>
                {
                    b.HasBaseType("Data_layer.Model.Product");

                    b.HasIndex("Titel")
                        .IsUnique()
                        .HasName("IX_Product_Titel1");

                    b.HasDiscriminator().HasValue("Traject");
                });

            modelBuilder.Entity("Data_layer.Model.Bestelling", b =>
                {
                    b.HasOne("Data_layer.Model.Klant", "Klant")
                        .WithMany("Bestellingen")
                        .HasForeignKey("KlantAzureId");
                });

            modelBuilder.Entity("Data_layer.Model.BestellingItem", b =>
                {
                    b.HasOne("Data_layer.Model.Bestelling", "Bestelling")
                        .WithMany("Producten")
                        .HasForeignKey("BestellingId");

                    b.HasOne("Data_layer.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("Data_layer.Model.Winkelwagen", b =>
                {
                    b.HasOne("Data_layer.Model.Klant", "Klant")
                        .WithMany("Winkelwagens")
                        .HasForeignKey("KlantAzureId");
                });

            modelBuilder.Entity("Data_layer.Model.WinkelwagenItem", b =>
                {
                    b.HasOne("Data_layer.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");

                    b.HasOne("Data_layer.Model.Winkelwagen", "Winkelwagen")
                        .WithMany("Producten")
                        .HasForeignKey("WinkelwagenId");
                });

            modelBuilder.Entity("Data_layer.Model.Cursus", b =>
                {
                    b.HasOne("Data_layer.Model.Traject")
                        .WithMany("Cursussen")
                        .HasForeignKey("TrajectID");
                });
#pragma warning restore 612, 618
        }
    }
}
