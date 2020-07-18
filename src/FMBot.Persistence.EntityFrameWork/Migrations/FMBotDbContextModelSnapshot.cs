﻿// <auto-generated />
using System;
using FMBot.Persistence.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMBot.Persistence.EntityFrameWork.Migrations
{
    [DbContext(typeof(FMBotDbContext))]
    partial class FMBotDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aliases")
                        .HasColumnName("aliases")
                        .HasColumnType("text");

                    b.Property<string>("LastFmUrl")
                        .HasColumnName("last_fm_url")
                        .HasColumnType("text");

                    b.Property<Guid?>("Mbid")
                        .HasColumnName("mbid")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("SpotifyId")
                        .HasColumnName("spotify_id")
                        .HasColumnType("text");

                    b.Property<DateTime?>("SpotifyImageDate")
                        .HasColumnName("spotify_image_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SpotifyImageUrl")
                        .HasColumnName("spotify_image_url")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_artists");

                    b.ToTable("artists");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.Friend", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("friend_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FriendUserId")
                        .HasColumnName("friend_user_id")
                        .HasColumnType("integer");

                    b.Property<string>("LastFMUserName")
                        .HasColumnName("last_fm_user_name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("FriendId")
                        .HasName("pk_friends");

                    b.HasIndex("FriendUserId")
                        .HasName("ix_friends_friend_user_id");

                    b.HasIndex("UserId")
                        .HasName("ix_friends_user_id");

                    b.ToTable("friends");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.Guild", b =>
                {
                    b.Property<int>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("guild_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("Blacklisted")
                        .HasColumnName("blacklisted")
                        .HasColumnType("boolean");

                    b.Property<int>("ChartTimePeriod")
                        .HasColumnName("chart_time_period")
                        .HasColumnType("integer");

                    b.Property<string>("DisabledCommands")
                        .HasColumnName("disabled_commands")
                        .HasColumnType("text");

                    b.Property<decimal>("DiscordGuildId")
                        .HasColumnName("discord_guild_id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("EmoteReactions")
                        .HasColumnName("emote_reactions")
                        .HasColumnType("text");

                    b.Property<int>("FmEmbedType")
                        .HasColumnName("fm_embed_type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastIndexed")
                        .HasColumnName("last_indexed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Prefix")
                        .HasColumnName("prefix")
                        .HasColumnType("text");

                    b.Property<bool?>("SpecialGuild")
                        .HasColumnName("special_guild")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TitlesEnabled")
                        .HasColumnName("titles_enabled")
                        .HasColumnType("boolean");

                    b.HasKey("GuildId")
                        .HasName("pk_guilds");

                    b.ToTable("guilds");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.GuildUser", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnName("guild_id")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "UserId")
                        .HasName("pk_guild_users");

                    b.HasIndex("UserId")
                        .HasName("ix_guild_users_user_id");

                    b.ToTable("guild_users");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("Blacklisted")
                        .HasColumnName("blacklisted")
                        .HasColumnType("boolean");

                    b.Property<int>("ChartTimePeriod")
                        .HasColumnName("chart_time_period")
                        .HasColumnType("integer");

                    b.Property<decimal>("DiscordUserId")
                        .HasColumnName("discord_user_id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool?>("Featured")
                        .HasColumnName("featured")
                        .HasColumnType("boolean");

                    b.Property<bool?>("FeaturedNotificationsEnabled")
                        .HasColumnName("featured_notifications_enabled")
                        .HasColumnType("boolean");

                    b.Property<int?>("FmCountType")
                        .HasColumnName("fm_count_type")
                        .HasColumnType("integer");

                    b.Property<int>("FmEmbedType")
                        .HasColumnName("fm_embed_type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastGeneratedChartDateTimeUtc")
                        .HasColumnName("last_generated_chart_date_time_utc")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastIndexed")
                        .HasColumnName("last_indexed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool?>("TitlesEnabled")
                        .HasColumnName("titles_enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserNameLastFM")
                        .HasColumnName("user_name_last_fm")
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnName("user_type")
                        .HasColumnType("integer");

                    b.HasKey("UserId")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.UserArtist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("artist_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnName("last_updated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<int>("Playcount")
                        .HasColumnName("playcount")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("ArtistId")
                        .HasName("pk_user_artists");

                    b.HasIndex("UserId")
                        .HasName("ix_user_artists_user_id");

                    b.ToTable("user_artists");
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.Friend", b =>
                {
                    b.HasOne("FMBot.Persistence.Domain.Models.User", "FriendUser")
                        .WithMany("FriendedByUsers")
                        .HasForeignKey("FriendUserId")
                        .HasConstraintName("FK.Friends.Users_FriendUserID");

                    b.HasOne("FMBot.Persistence.Domain.Models.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK.Friends.Users_UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.GuildUser", b =>
                {
                    b.HasOne("FMBot.Persistence.Domain.Models.Guild", "Guild")
                        .WithMany("GuildUsers")
                        .HasForeignKey("GuildId")
                        .HasConstraintName("fk_guild_users_guilds_guild_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FMBot.Persistence.Domain.Models.User", "User")
                        .WithMany("GuildUsers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_guild_users_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FMBot.Persistence.Domain.Models.UserArtist", b =>
                {
                    b.HasOne("FMBot.Persistence.Domain.Models.User", "User")
                        .WithMany("Artists")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_artists_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
