using System;
using entityFramework.App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace entityFramework.App.Migrations
{
    [DbContext(typeof(NinjaContext))]
    partial class NinjaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("entityFramework.Entities.Clan", b =>
                {
                    b.Property<int>("ClanId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ClanId");

                    b.ToTable("Clan");
                });

            modelBuilder.Entity("entityFramework.Entities.Ninja", b =>
                {
                    b.Property<int>("NinjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClanId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<int>("NinjaType");

                    b.Property<bool>("ServedInObiwan");

                    b.HasKey("NinjaId");

                    b.HasIndex("ClanId");

                    b.ToTable("Ninja");
                });

            modelBuilder.Entity("entityFramework.Entities.NinjaEquipment", b =>
                {
                    b.Property<int>("NinjaEquipmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EquipmentType");

                    b.Property<string>("Name");

                    b.Property<int>("NinjaId");

                    b.HasKey("NinjaEquipmentId");

                    b.HasIndex("NinjaId");

                    b.ToTable("NinjaEquipment");
                });

            modelBuilder.Entity("entityFramework.Entities.Ninja", b =>
                {
                    b.HasOne("entityFramework.Entities.Clan", "Clan")
                        .WithMany("Ninas")
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("entityFramework.Entities.NinjaEquipment", b =>
                {
                    b.HasOne("entityFramework.Entities.Ninja", "Ninja")
                        .WithMany("NinjaEquipments")
                        .HasForeignKey("NinjaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
