// <auto-generated />
using System;
using GraphQLDotNetCore.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("246b3077-ce46-4f3e-a24f-3dbea873fd6d"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("9ba732a8-a3b6-4a65-ad81-e8407aa38dc2"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d67bdf80-abe0-4267-afd1-c1d50635f081"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("79ceced9-93c4-4794-aa1c-804f40aa4672"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("78c003c3-4354-4739-8629-53747ccbe0d6"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("79ceced9-93c4-4794-aa1c-804f40aa4672"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ba732a8-a3b6-4a65-ad81-e8407aa38dc2"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("79ceced9-93c4-4794-aa1c-804f40aa4672"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
