using FluentMigrator;

namespace AnimalCrudApi.Data.Migrations
{
    [Migration(03032024)]
    public class CreateSchema : Migration
    {
        public override void Up()
        {
            Create.Table("animals")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("full_name").AsString(128).NotNullable()
                .WithColumn("gendre").AsString(128).NotNullable()
                .WithColumn("age").AsInt32().NotNullable();
                
        }

        public override void Down()
        {

        }
    }
}
