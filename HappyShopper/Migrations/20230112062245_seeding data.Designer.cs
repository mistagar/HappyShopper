// <auto-generated />
using HappyShopper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HappyShopper.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230112062245_seeding data")]
    partial class seedingdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HappyShopper.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Reddis",
                            Description = "Cool and soft",
                            Name = "Eskimo boots",
                            PictureUrl = "images/products/boots-reddis.png",
                            Price = 485L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Nike",
                            Description = "Cool fashion",
                            Name = "Nike Hoodie",
                            PictureUrl = "images/products/hoodie.png",
                            Price = 485L,
                            QuantityInStock = 332,
                            Type = "Hoodie"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Chinatown",
                            Description = "Very effective",
                            Name = "Chinese Chop Sticks",
                            PictureUrl = "images/products/chopsticks.png",
                            Price = 113L,
                            QuantityInStock = 405,
                            Type = "Cutlery"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
