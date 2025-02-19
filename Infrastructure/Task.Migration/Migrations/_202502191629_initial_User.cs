using FluentMigrator;

namespace Task.Migration.Migrations;
[Migration(202502191629)]
public class _202502191629_initial_User:FluentMigrator.Migration
{
    public override void Up()
    {
        Create.Table("Users")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserName").AsString().NotNullable()
            .WithColumn("Email").AsString().NotNullable()
            .WithColumn("Password").AsString().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("Users");
    }
}