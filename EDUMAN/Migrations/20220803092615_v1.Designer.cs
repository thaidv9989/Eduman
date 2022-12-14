// <auto-generated />
using System;
using EDUMAN.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EDUMAN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220803092615_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EDUMAN.Models.approle", b =>
                {
                    b.Property<string>("role_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("role_id");

                    b.ToTable("approles");
                });

            modelBuilder.Entity("EDUMAN.Models.approle_permission", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("permission_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("role_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("permission_id");

                    b.HasIndex("role_id");

                    b.ToTable("approle_permissions");
                });

            modelBuilder.Entity("EDUMAN.Models.discipline", b =>
                {
                    b.Property<int>("discipline_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("discipline_id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("discipline_id");

                    b.ToTable("disciplines");
                });

            modelBuilder.Entity("EDUMAN.Models.e_class", b =>
                {
                    b.Property<string>("class_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("class_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("major_id")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teacher_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("class_id");

                    b.HasIndex("major_id");

                    b.HasIndex("teacher_id");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("EDUMAN.Models.education_type", b =>
                {
                    b.Property<int>("education_type_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("education_type_id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("education_type_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("education_type_id");

                    b.ToTable("education_types");
                });

            modelBuilder.Entity("EDUMAN.Models.major", b =>
                {
                    b.Property<int>("major_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("major_id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("major_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("major_related")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("major_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("school_year_id")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("major_id");

                    b.HasIndex("school_year_id");

                    b.ToTable("majors");
                });

            modelBuilder.Entity("EDUMAN.Models.permission", b =>
                {
                    b.Property<string>("permission_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("module")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permission_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("permission_id");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("EDUMAN.Models.reward", b =>
                {
                    b.Property<int>("reward_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reward_id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reward_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("reward_id");

                    b.ToTable("rewards");
                });

            modelBuilder.Entity("EDUMAN.Models.school_year", b =>
                {
                    b.Property<int>("school_year_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("school_year_id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("education_type_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("from_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("school_year_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("to_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("school_year_id");

                    b.HasIndex("education_type_id");

                    b.ToTable("school_years");
                });

            modelBuilder.Entity("EDUMAN.Models.student", b =>
                {
                    b.Property<string>("student_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("bank_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("class_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("communist_party_day")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("communist_youth_day")
                        .HasColumnType("datetime2");

                    b.Property<string>("contact_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("domicile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("education_level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ethnicity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("family_category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("household")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("identity_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("identity_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identity_place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("morality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place_of_birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("policy_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recruitment_area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("student_id");

                    b.HasIndex("class_id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("EDUMAN.Models.student_discipline", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("decision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discipline_id")
                        .HasColumnType("int");

                    b.Property<string>("discipline_reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expired_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("discipline_id");

                    b.HasIndex("student_id");

                    b.ToTable("student_disciplines");
                });

            modelBuilder.Entity("EDUMAN.Models.student_relative", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("household")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("relative_fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("relative_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("student_id");

                    b.ToTable("student_relatives");
                });

            modelBuilder.Entity("EDUMAN.Models.student_reward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("decision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reward_id")
                        .HasColumnType("int");

                    b.Property<string>("reward_reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("reward_id");

                    b.HasIndex("student_id");

                    b.ToTable("student_rewards");
                });

            modelBuilder.Entity("EDUMAN.Models.student_staying", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("from_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("host_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("to_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("student_id");

                    b.ToTable("student_stayings");
                });

            modelBuilder.Entity("EDUMAN.Models.student_study_log", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("log_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("student_id");

                    b.ToTable("student_study_logs");
                });

            modelBuilder.Entity("EDUMAN.Models.student_study_progress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("from_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("student_position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("to_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("student_id");

                    b.ToTable("student_study_progresses");
                });

            modelBuilder.Entity("EDUMAN.Models.teacher", b =>
                {
                    b.Property<string>("teacher_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teacher_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacher_id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("EDUMAN.Models.teacher_approle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("role_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("teacher_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("role_id");

                    b.HasIndex("teacher_id");

                    b.ToTable("teacher_approles");
                });

            modelBuilder.Entity("EDUMAN.Models.approle_permission", b =>
                {
                    b.HasOne("EDUMAN.Models.permission", null)
                        .WithMany()
                        .HasForeignKey("permission_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUMAN.Models.approle", null)
                        .WithMany()
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.e_class", b =>
                {
                    b.HasOne("EDUMAN.Models.major", null)
                        .WithMany()
                        .HasForeignKey("major_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUMAN.Models.teacher", null)
                        .WithMany()
                        .HasForeignKey("teacher_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.major", b =>
                {
                    b.HasOne("EDUMAN.Models.school_year", null)
                        .WithMany()
                        .HasForeignKey("school_year_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.school_year", b =>
                {
                    b.HasOne("EDUMAN.Models.education_type", null)
                        .WithMany()
                        .HasForeignKey("education_type_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student", b =>
                {
                    b.HasOne("EDUMAN.Models.e_class", null)
                        .WithMany()
                        .HasForeignKey("class_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_discipline", b =>
                {
                    b.HasOne("EDUMAN.Models.discipline", null)
                        .WithMany()
                        .HasForeignKey("discipline_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_relative", b =>
                {
                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_reward", b =>
                {
                    b.HasOne("EDUMAN.Models.reward", null)
                        .WithMany()
                        .HasForeignKey("reward_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_staying", b =>
                {
                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_study_log", b =>
                {
                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.student_study_progress", b =>
                {
                    b.HasOne("EDUMAN.Models.student", null)
                        .WithMany()
                        .HasForeignKey("student_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EDUMAN.Models.teacher_approle", b =>
                {
                    b.HasOne("EDUMAN.Models.approle", null)
                        .WithMany()
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDUMAN.Models.teacher", null)
                        .WithMany()
                        .HasForeignKey("teacher_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
