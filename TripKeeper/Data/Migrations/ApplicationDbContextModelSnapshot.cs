﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripKeeper.Data;

namespace TripKeeper.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TripKeeper.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TripKeeper.Models.DotAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BlankAccidentReport")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DotCard")
                        .HasColumnType("bit");

                    b.Property<string>("DriverSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DriversLicense")
                        .HasColumnType("bit");

                    b.Property<bool>("DvirBook")
                        .HasColumnType("bit");

                    b.Property<bool>("EldGuide")
                        .HasColumnType("bit");

                    b.Property<bool>("ExtraLogBook")
                        .HasColumnType("bit");

                    b.Property<bool>("Ifta")
                        .HasColumnType("bit");

                    b.Property<bool>("InsuranceCard")
                        .HasColumnType("bit");

                    b.Property<bool>("LogBook")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OregonFuelPermit")
                        .HasColumnType("bit");

                    b.Property<bool>("PermitBook")
                        .HasColumnType("bit");

                    b.Property<bool>("PitCard")
                        .HasColumnType("bit");

                    b.Property<bool>("PostAccidentKit")
                        .HasColumnType("bit");

                    b.Property<bool>("Registration")
                        .HasColumnType("bit");

                    b.Property<bool>("Tablet")
                        .HasColumnType("bit");

                    b.Property<int>("Tractor")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DotAudit");
                });

            modelBuilder.Entity("TripKeeper.Models.EndRouteCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClearTrailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Epj")
                        .HasColumnType("int");

                    b.Property<string>("LoadQualitySurvey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PalletJack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportEquipmentDamages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportTrailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RetunDvir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnMisPicks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteNumber")
                        .HasColumnType("int");

                    b.Property<string>("StrapsHanding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SweepTrailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tractor")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerShuttle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurnInAllPaperwork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurnInBols")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EndRouteCheck");
                });

            modelBuilder.Entity("TripKeeper.Models.OperatorEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatteryIndicator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapacityPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CracksWear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DockCracks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrivingControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Epj")
                        .HasColumnType("int");

                    b.Property<string>("FluidLeaks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Forks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandGuards")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandTruckWheels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Handle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoistControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HourMeter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftHandleDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightsAlarms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maneuverability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManualFluidLeaks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManualForks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MissingHardware")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatorsManual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pins")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerCord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseLever")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteNumber")
                        .HasColumnType("int");

                    b.Property<string>("SafetyWarnings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceBreak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SteeringOperation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tires")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wheels")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperatorEquipment");
                });

            modelBuilder.Entity("TripKeeper.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BHPU")
                        .HasColumnType("int");

                    b.Property<int>("Chains")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Delay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("EndingMiles")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HourlyYard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Inspections")
                        .HasColumnType("int");

                    b.Property<bool>("IsTeamRoute")
                        .HasColumnType("bit");

                    b.Property<int>("Meals")
                        .HasColumnType("int");

                    b.Property<decimal>("MiscExpense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pallets")
                        .HasColumnType("int");

                    b.Property<int>("RoadStops")
                        .HasColumnType("int");

                    b.Property<int>("RouteNumber")
                        .HasColumnType("int");

                    b.Property<int>("Shuttle")
                        .HasColumnType("int");

                    b.Property<string>("Signature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sleeper")
                        .HasColumnType("int");

                    b.Property<decimal?>("StartMiles")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuperStops")
                        .HasColumnType("int");

                    b.Property<string>("Temp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tractor")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XDock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TripKeeper.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TripKeeper.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripKeeper.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TripKeeper.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
