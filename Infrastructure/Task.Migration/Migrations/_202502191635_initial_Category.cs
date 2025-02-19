using FluentMigrator;

namespace Task.Migration.Migrations;
[Migration(202502191635)]
public class _202502191635_initial_Category:FluentMigrator.Migration
{
    public override void Up()
    {
        Create.Table("Category")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Category");
    }
}