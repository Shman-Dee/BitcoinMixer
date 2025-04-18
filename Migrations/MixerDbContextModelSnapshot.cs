﻿// <auto-generated />
using System;
using BitcoinMixer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BitcoinMixer.Migrations
{
    [DbContext(typeof(MixerDbContext))]
    partial class MixerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("BitcoinMixer.Models.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("FakeBitcoinAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("BitcoinMixer.Models.MixTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepositId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ScheduledSendTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepositId");

                    b.ToTable("MixTransactions");
                });

            modelBuilder.Entity("BitcoinMixer.Models.Withdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RequestedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WithdrawalAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Withdrawals");
                });

            modelBuilder.Entity("BitcoinMixer.Models.MixTransaction", b =>
                {
                    b.HasOne("BitcoinMixer.Models.Deposit", "Deposit")
                        .WithMany("MixTransactions")
                        .HasForeignKey("DepositId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deposit");
                });

            modelBuilder.Entity("BitcoinMixer.Models.Deposit", b =>
                {
                    b.Navigation("MixTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
