using FluentMigrator;

namespace AnimalCrudApi.Data.Migrations;


[Migration(21032024)]
public class TestMigrate : Migration
{
    public override void Up()
    {
        Execute.Script(@"./Data/Scripts/data.sql");
    }
    public override void Down()
    {

    }
}
