﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QQBot.DB;

namespace QQBot.DB.Migrations
{
    [DbContext(typeof(QQBotDbContext))]
    [Migration("20211113085434_Update2")]
    partial class Update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("QQBot.Entities.Config.Command", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("t_Command");
                });

            modelBuilder.Entity("QQBot.Entities.Config.QLConfig", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ClientID")
                        .HasColumnType("text");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("text");

                    b.Property<int>("CookieCount")
                        .HasColumnType("int");

                    b.Property<bool>("EnableAll")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("TokeType")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<DateTime?>("TokenExprise")
                        .HasColumnType("datetime");

                    b.Property<int>("Weigth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("t_QLConfig");
                });

            modelBuilder.Entity("QQBot.Entities.Model.Env", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<bool>("Enable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Remark")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("t_env");
                });

            modelBuilder.Entity("QQBot.Entities.Model.JDCookie", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CFDShareCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DDGCShareCode")
                        .HasColumnType("text");

                    b.Property<string>("JDMCShareCode")
                        .HasColumnType("text");

                    b.Property<string>("JDNCShareCode")
                        .HasColumnType("text");

                    b.Property<string>("JXGCShareCode")
                        .HasColumnType("text");

                    b.Property<string>("JXNCShareCode")
                        .HasColumnType("text");

                    b.Property<string>("PTKey")
                        .HasColumnType("text");

                    b.Property<string>("PTPin")
                        .HasColumnType("text");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("QDLXJShareCode")
                        .HasColumnType("text");

                    b.Property<long>("QQ")
                        .HasColumnType("bigint");

                    b.Property<string>("Remark")
                        .HasColumnType("text");

                    b.Property<string>("SGMHShareCode")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ZDDDShareCode")
                        .HasColumnType("text");

                    b.Property<string>("nickname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("t_JDCookie");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QLEnv", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("EnvId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("QLId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EnvId");

                    b.ToTable("t_ql_env");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QLPanelCookie", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("CookieId")
                        .HasColumnType("text");

                    b.Property<string>("JDCookieId")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Mode")
                        .HasColumnType("int");

                    b.Property<string>("QLPanelId")
                        .HasColumnType("text");

                    b.Property<string>("_id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("JDCookieId");

                    b.ToTable("t_ql_panel_cookie");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QQBotTask", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Command")
                        .HasColumnType("text");

                    b.Property<int>("ConcCount")
                        .HasColumnType("int");

                    b.Property<string>("Cron")
                        .HasColumnType("text");

                    b.Property<bool>("Enable")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EnableConc")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EnablePush")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ExecAllCookie")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TaskSource")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("t_qqbot_task");
                });

            modelBuilder.Entity("QQBot.Entities.Model.TaskConc", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("CookieId")
                        .HasColumnType("text");

                    b.Property<string>("QQBotTaskId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("QQBotTaskId");

                    b.ToTable("t_task_conc");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QLEnv", b =>
                {
                    b.HasOne("QQBot.Entities.Model.Env", null)
                        .WithMany("QLEnvs")
                        .HasForeignKey("EnvId");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QLPanelCookie", b =>
                {
                    b.HasOne("QQBot.Entities.Model.JDCookie", null)
                        .WithMany("QLPanelCookies")
                        .HasForeignKey("JDCookieId");
                });

            modelBuilder.Entity("QQBot.Entities.Model.TaskConc", b =>
                {
                    b.HasOne("QQBot.Entities.Model.QQBotTask", null)
                        .WithMany("TaskConcs")
                        .HasForeignKey("QQBotTaskId");
                });

            modelBuilder.Entity("QQBot.Entities.Model.Env", b =>
                {
                    b.Navigation("QLEnvs");
                });

            modelBuilder.Entity("QQBot.Entities.Model.JDCookie", b =>
                {
                    b.Navigation("QLPanelCookies");
                });

            modelBuilder.Entity("QQBot.Entities.Model.QQBotTask", b =>
                {
                    b.Navigation("TaskConcs");
                });
#pragma warning restore 612, 618
        }
    }
}
