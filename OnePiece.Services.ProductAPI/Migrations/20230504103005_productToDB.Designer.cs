﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnePiece.Services.ProductAPI.DbContexts;

#nullable disable

namespace OnePiece.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230504103005_productToDB")]
    partial class productToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnePiece.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "Paramecia",
                            Description = " Devil Fruit that grants the user's body the properties of rubber, effectively turning them into a Rubber Human.",
                            ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Gomu_Gomu_no_Mi",
                            Name = "Gomo Gomo no Mi",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "Logia",
                            Description = "Devil Fruit that allows the user to create, control, and transform into fire at will..",
                            ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Mera_Mera_no_Mi",
                            Name = "Mera Mera no Mi",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "Zoan",
                            Description = "Devil Fruit that allows its user to transform into a leopard hybrid and a full leopard at will, making the user a Leopard Human.",
                            ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Neko_Neko_no_Mi_Model_Leopard",
                            Name = "Neko Neko no Mi Model Leopard",
                            Price = 10.99
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Paramecia",
                            Description = " Devil Fruit whose granted ability is creating a spherical forcefield in which the user can freely alter the orientation, movements, and configuration/anatomy of anything and anyone (themselves included) in a \"surgical\" fashion, making the user a Free Modification Human.<br/>",
                            ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Ope_Ope_no_Mi",
                            Name = "Ope Ope no Mi",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}