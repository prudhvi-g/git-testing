// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_E_Grocecry.DataAccess;

namespace Online_E_Grocecry.Migrations
{
    [DbContext(typeof(GroceryDbContext))]
    [Migration("20220914184435_initi")]
    partial class initi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_E_Grocecry.Models.Items", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Item Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("itemName")
                        .HasColumnName("Item Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("itemPrice")
                        .HasColumnName("Item Price")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnName("Rating")
                        .HasColumnType("int");

                    b.HasKey("itemId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("Online_E_Grocecry.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("itemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderPlace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("Online_E_Grocecry.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("passWord")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
