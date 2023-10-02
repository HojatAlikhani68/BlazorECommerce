﻿// <auto-generated />
using BlazorECommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231002140841_productData")]
    partial class productData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorECommerce.Shared.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "",
                            Description = "The Samsung Galaxy S III (unofficially known as the Samsung Galaxy S3) is an Android smartphone designed, developed, and marketed by Samsung Electronics. Launched in 2012, it had sold more than 80 million units overall, making it the most sold phone in the S series.[5] It is the third smartphone in the Samsung Galaxy S series.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Samsung_Galaxy_S_III.png",
                            Price = 9.99m,
                            PriceTotal = 0m,
                            Status = false,
                            Tax = 0.0,
                            Title = "Samsung Galaxy S III"
                        },
                        new
                        {
                            Id = 2,
                            Code = "",
                            Description = "The Nokia N8 is a touchscreen-based smartphone developed by Nokia. Announced on 27 April 2010, the Nokia N8 was the first device to run on the Symbian^3 mobile operating system and it was the company's flagship device for the year.[4] It was released on 30 September 2010 at the Nokia Online Store before being released in markets around the world on 1 October 2010.[5] There were two version made, the N8 and the N8-00. The N8 was made for Vodafone and locked to its networks,[6] and the N8-00 was made by Microsoft and open network.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Nokia_N8.png",
                            Price = 6.99m,
                            PriceTotal = 0m,
                            Status = false,
                            Tax = 0.0,
                            Title = "Nokia N8"
                        },
                        new
                        {
                            Id = 3,
                            Code = "",
                            Description = "The iPhone X (Roman numeral X pronounced ten [12]) is a smartphone designed, developed and marketed by Apple Inc. It is part of the eleventh generation of the iPhone. Available for pre-order from October 27, 2017, it was released on November 3, 2017. The naming of the iPhone X (skipping the iPhone 9) is to mark the 10th anniversary of the iPhone.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/3/32/IPhone_X_vector.svg",
                            Price = 4.99m,
                            PriceTotal = 0m,
                            Status = false,
                            Tax = 0.0,
                            Title = "iPhone X"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
