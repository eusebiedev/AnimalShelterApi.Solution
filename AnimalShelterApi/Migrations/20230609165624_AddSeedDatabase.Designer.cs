﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230609165624_AddSeedDatabase")]
    partial class AddSeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 1,
                            Breed = "Siamese",
                            Name = "Alice",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 3,
                            Breed = "Ragdoll",
                            Name = "Barky",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 5,
                            Breed = "Ocicat",
                            Name = "Wirey",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 7,
                            Breed = "Chausie",
                            Name = "Bianca",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 5,
                            Breed = "Abyssinian",
                            Name = "Flame",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 6,
                            Breed = "Birman",
                            Name = "Georia",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 7,
                            Breed = "Chartreux",
                            Name = "Frisky",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 3,
                            Breed = "Himalayan",
                            Name = "Sleepy",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 3,
                            Breed = "Lyoki",
                            Name = "Curly",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 11,
                            Breed = "Chihuahua",
                            Name = "Bicker",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 4,
                            Breed = "Pomeranian",
                            Name = "Snipper",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 12,
                            Age = 4,
                            Breed = "Havanese",
                            Name = "Wiley",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 13,
                            Age = 8,
                            Breed = "Dachshund",
                            Name = "Frank",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 14,
                            Age = 11,
                            Breed = "Bichon",
                            Name = "Charlie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 15,
                            Age = 9,
                            Breed = "Terrier",
                            Name = "Rue",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 16,
                            Age = 5,
                            Breed = "Poodle",
                            Name = "Googlie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 17,
                            Age = 8,
                            Breed = "Affenpinscher",
                            Name = "Mike",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 18,
                            Age = 9,
                            Breed = "Sarabi",
                            Name = "Wolfie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 19,
                            Age = 3,
                            Breed = "Samoyed",
                            Name = "Chomper",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 20,
                            Age = 15,
                            Breed = "Maltipoo",
                            Name = "Sleepy",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}