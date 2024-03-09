﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rnwood.Smtp4dev.Data;

#nullable disable

namespace Rnwood.Smtp4dev.Migrations
{
    [DbContext(typeof(Smtp4devDbContext))]
    partial class Smtp4devDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.ImapState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long>("LastUid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ImapState");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AttachmentCount")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Data")
                        .HasColumnType("BLOB");

                    b.Property<bool?>("EightBitTransport")
                        .HasColumnType("INTEGER");

                    b.Property<string>("From")
                        .HasColumnType("TEXT");

                    b.Property<long>("ImapUid")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsUnread")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MimeParseError")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RelayError")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SecureConnection")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SessionEncoding")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SessionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.Property<string>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.MessageRelay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("MessageRelays");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Log")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfMessages")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SessionError")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SessionErrorType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.HasOne("Rnwood.Smtp4dev.DbModel.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.MessageRelay", b =>
                {
                    b.HasOne("Rnwood.Smtp4dev.DbModel.Message", "Message")
                        .WithMany("Relays")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Rnwood.Smtp4dev.DbModel.Message", b =>
                {
                    b.Navigation("Relays");
                });
#pragma warning restore 612, 618
        }
    }
}
