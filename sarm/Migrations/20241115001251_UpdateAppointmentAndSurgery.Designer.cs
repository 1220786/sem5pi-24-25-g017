﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDNetCore.Migrations
{
    [DbContext(typeof(SARMDbContext))]
    [Migration("20241115001251_UpdateAppointmentAndSurgery")]
    partial class UpdateAppointmentAndSurgery
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DDDNetCore.Domain.Appointments.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("AppointmentDate");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("OperationType");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Priority");

                    b.Property<string>("Staff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Staff");

                    b.Property<string>("SurgeryNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SurgeryNumber");

                    b.HasKey("Id");

                    b.ToTable("Appointments", (string)null);
                });

            modelBuilder.Entity("DDDNetCore.Domain.Patients.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Gender");

                    b.Property<string>("MedicalRecordNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MedicalRecordNumber");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DDDNetCore.Domain.Surgeries.Surgery", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("AssignedEquipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AssignedEquipment");

                    b.Property<string>("CurrentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CurrentStatus");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SurgeryRoom");

                    b.Property<int>("RoomCapacity")
                        .HasColumnType("int")
                        .HasColumnName("RoomCapacity");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RoomType");

                    b.Property<string>("SurgeryNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SurgeryNumber");

                    b.HasKey("Id");

                    b.ToTable("Surgeries", (string)null);
                });

            modelBuilder.Entity("Domain.DbLogs.DbLog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EntityType");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LogType");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Message");

                    b.Property<string>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("DbLog");
                });

            modelBuilder.Entity("Domain.OperationRequests.OperationRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("DeadlineDate")
                        .HasColumnType("date")
                        .HasColumnName("DeadlineDate");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OperationType");

                    b.Property<string>("Patient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Patient");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Priority");

                    b.Property<string>("Staff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Staff");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RequestStatus");

                    b.HasKey("Id");

                    b.ToTable("OperationRequests");
                });

            modelBuilder.Entity("Domain.OperationTypes.OperationType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhasesDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhasesDuration");

                    b.Property<string>("RequiredStaff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RequiredStaff");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("OperationTypes");
                });

            modelBuilder.Entity("Domain.Staffs.Staff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LicenseNumber");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Specialization");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Status");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserStatus");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.UsersSession.UserSession", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cookie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cookie");

                    b.Property<DateTime>("ExpiresIn")
                        .HasColumnType("datetime2")
                        .HasColumnName("ExpiresIn");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Role");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("UsersSessions");
                });

            modelBuilder.Entity("DDDNetCore.Domain.Patients.Patient", b =>
                {
                    b.OwnsMany("Domain.Shared.Slot", "AppointmentHistory", b1 =>
                        {
                            b1.Property<string>("PatientId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("End")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("End");

                            b1.Property<string>("Start")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Start");

                            b1.HasKey("PatientId", "Id");

                            b1.ToTable("Patients_AppointmentHistory");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.OwnsOne("Domain.Shared.ContactInformation", "ContactInformation", b1 =>
                        {
                            b1.Property<string>("PatientId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Email");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("PatientId");

                            b1.ToTable("Patients");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.OwnsOne("Domain.Shared.FullName", "FullName", b1 =>
                        {
                            b1.Property<string>("PatientId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("LastName");

                            b1.HasKey("PatientId");

                            b1.ToTable("Patients");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.OwnsOne("Domain.Patients.EmergencyContact", "EmergencyContact", b1 =>
                        {
                            b1.Property<string>("PatientId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Number")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("EmergencyContactPhoneNumber");

                            b1.HasKey("PatientId");

                            b1.ToTable("Patients");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.OwnsMany("Domain.Patients.MedicalConditions", "MedicalConditions", b1 =>
                        {
                            b1.Property<string>("PatientId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Condition")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("MedicalCondition");

                            b1.HasKey("PatientId", "Id");

                            b1.ToTable("MedicalConditions");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.Navigation("AppointmentHistory");

                    b.Navigation("ContactInformation")
                        .IsRequired();

                    b.Navigation("EmergencyContact");

                    b.Navigation("FullName")
                        .IsRequired();

                    b.Navigation("MedicalConditions");
                });

            modelBuilder.Entity("DDDNetCore.Domain.Surgeries.Surgery", b =>
                {
                    b.OwnsMany("Domain.Shared.Slot", "MaintenanceSlots", b1 =>
                        {
                            b1.Property<string>("SurgeryId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("End")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("End");

                            b1.Property<string>("Start")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Start");

                            b1.HasKey("SurgeryId", "Id");

                            b1.ToTable("Surgeries_MaintenanceSlots");

                            b1.WithOwner()
                                .HasForeignKey("SurgeryId");
                        });

                    b.Navigation("MaintenanceSlots");
                });

            modelBuilder.Entity("Domain.Staffs.Staff", b =>
                {
                    b.OwnsOne("Domain.Shared.ContactInformation", "ContactInformation", b1 =>
                        {
                            b1.Property<string>("StaffId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Email");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("StaffId");

                            b1.ToTable("Staffs");

                            b1.WithOwner()
                                .HasForeignKey("StaffId");
                        });

                    b.OwnsOne("Domain.Shared.FullName", "FullName", b1 =>
                        {
                            b1.Property<string>("StaffId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("LastName");

                            b1.HasKey("StaffId");

                            b1.ToTable("Staffs");

                            b1.WithOwner()
                                .HasForeignKey("StaffId");
                        });

                    b.OwnsMany("Domain.Shared.Slot", "SlotAppointement", b1 =>
                        {
                            b1.Property<string>("StaffId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("End")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("End");

                            b1.Property<string>("Start")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Start");

                            b1.HasKey("StaffId", "Id");

                            b1.ToTable("Staffs_SlotAppointement");

                            b1.WithOwner()
                                .HasForeignKey("StaffId");
                        });

                    b.OwnsMany("Domain.Shared.Slot", "SlotAvailability", b1 =>
                        {
                            b1.Property<string>("StaffId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("End")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("End");

                            b1.Property<string>("Start")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Start");

                            b1.HasKey("StaffId", "Id");

                            b1.ToTable("Staffs_SlotAvailability");

                            b1.WithOwner()
                                .HasForeignKey("StaffId");
                        });

                    b.Navigation("ContactInformation")
                        .IsRequired();

                    b.Navigation("FullName")
                        .IsRequired();

                    b.Navigation("SlotAppointement");

                    b.Navigation("SlotAvailability");
                });

            modelBuilder.Entity("Domain.Users.User", b =>
                {
                    b.OwnsOne("Domain.Shared.Email", "Email", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("Domain.Users.Username", "Username", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Username");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Username")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.UsersSession.UserSession", b =>
                {
                    b.OwnsOne("Domain.Shared.Email", "Email", b1 =>
                        {
                            b1.Property<string>("UserSessionId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Email");

                            b1.HasKey("UserSessionId");

                            b1.ToTable("UsersSessions");

                            b1.WithOwner()
                                .HasForeignKey("UserSessionId");
                        });

                    b.Navigation("Email")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
