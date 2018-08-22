﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modix.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Modix.Data.Migrations
{
    [DbContext(typeof(ModixContext))]
    [Migration("20180820053227_DesignatedChannels")]
    partial class DesignatedChannels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Modix.Data.Models.BehaviourConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BehaviourConfigurations");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ClaimMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Claim")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<long?>("RoleId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.ToTable("ClaimMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ConfigurationActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ClaimMappingId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long?>("DesignatedChannelMappingId");

                    b.Property<long>("GuildId");

                    b.Property<long?>("ModerationMuteRoleMappingId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClaimMappingId");

                    b.HasIndex("DesignatedChannelMappingId");

                    b.HasIndex("ModerationMuteRoleMappingId");

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("ConfigurationActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedChannelMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelDesignation")
                        .IsRequired();

                    b.Property<long>("ChannelId");

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.ToTable("DesignatedChannelMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildChannelEntity", b =>
                {
                    b.Property<long>("ChannelId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GuildId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ChannelId");

                    b.ToTable("GuildChannels");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildUserEntity", b =>
                {
                    b.Property<long>("GuildId");

                    b.Property<long>("UserId");

                    b.Property<DateTimeOffset>("FirstSeen");

                    b.Property<DateTimeOffset>("LastSeen");

                    b.Property<string>("Nickname");

                    b.HasKey("GuildId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GuildUsers");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.DeletedMessageEntity", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AuthorId");

                    b.Property<long>("ChannelId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("CreateActionId");

                    b.HasIndex("GuildId", "AuthorId");

                    b.ToTable("DeletedMessages");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.InfractionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<long>("GuildId");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.Property<long?>("RescindActionId");

                    b.Property<long>("SubjectId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.HasIndex("RescindActionId")
                        .IsUnique();

                    b.HasIndex("GuildId", "SubjectId");

                    b.ToTable("Infractions");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long?>("DeletedMessageId");

                    b.Property<long>("GuildId");

                    b.Property<long?>("InfractionId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DeletedMessageId");

                    b.HasIndex("InfractionId");

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("ModerationActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationMuteRoleMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<long>("MuteRoleId");

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.ToTable("ModerationMuteRoleMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotion.PromotionCampaignEntity", b =>
                {
                    b.Property<long>("PromotionCampaignId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("PromotionForId");

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<int>("Status");

                    b.HasKey("PromotionCampaignId");

                    b.HasIndex("PromotionForId");

                    b.ToTable("PromotionCampaigns");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotion.PromotionCommentEntity", b =>
                {
                    b.Property<long>("PromotionCommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTimeOffset>("PostedDate");

                    b.Property<long?>("PromotionCampaignId");

                    b.Property<int>("Sentiment");

                    b.HasKey("PromotionCommentId");

                    b.HasIndex("PromotionCampaignId");

                    b.ToTable("PromotionComments");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ClaimMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne("CreatedClaimMapping")
                        .HasForeignKey("Modix.Data.Models.Core.ClaimMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne("DeletedClaimMapping")
                        .HasForeignKey("Modix.Data.Models.Core.ClaimMappingEntity", "DeleteActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ConfigurationActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ClaimMappingEntity", "ClaimMapping")
                        .WithMany()
                        .HasForeignKey("ClaimMappingId");

                    b.HasOne("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "DesignatedChannelMapping")
                        .WithMany()
                        .HasForeignKey("DesignatedChannelMappingId");

                    b.HasOne("Modix.Data.Models.Moderation.ModerationMuteRoleMappingEntity", "ModerationMuteRoleMapping")
                        .WithMany()
                        .HasForeignKey("ModerationMuteRoleMappingId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedChannelMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne("CreatedDesignatedChannelMapping")
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne("DeletedDesignatedChannelMapping")
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "DeleteActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildUserEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.DeletedMessageEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.GuildChannelEntity", "Channel")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "CreateAction")
                        .WithMany()
                        .HasForeignKey("CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "Author")
                        .WithMany()
                        .HasForeignKey("GuildId", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.InfractionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "DeleteActionId");

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "RescindAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "RescindActionId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "Subject")
                        .WithMany()
                        .HasForeignKey("GuildId", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Moderation.DeletedMessageEntity", "DeletedMessage")
                        .WithMany()
                        .HasForeignKey("DeletedMessageId");

                    b.HasOne("Modix.Data.Models.Moderation.InfractionEntity", "Infraction")
                        .WithMany()
                        .HasForeignKey("InfractionId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationMuteRoleMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne("CreatedModerationMuteRoleMapping")
                        .HasForeignKey("Modix.Data.Models.Moderation.ModerationMuteRoleMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne("DeletedModerationMuteRoleMapping")
                        .HasForeignKey("Modix.Data.Models.Moderation.ModerationMuteRoleMappingEntity", "DeleteActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotion.PromotionCampaignEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.UserEntity", "PromotionFor")
                        .WithMany()
                        .HasForeignKey("PromotionForId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Promotion.PromotionCommentEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Promotion.PromotionCampaignEntity", "PromotionCampaign")
                        .WithMany("Comments")
                        .HasForeignKey("PromotionCampaignId");
                });
#pragma warning restore 612, 618
        }
    }
}
