using FluentMigrator;
using FluentMigrator.Postgres;

namespace Task.Migration.Migrations;
[Migration(202502191640)]
public class _202502191640_initial_Task:FluentMigrator.Migration
{
    public override void Up()
    {
        Create.Table("Tasks")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Titel").AsString().NotNullable()
            .WithColumn("Description").AsString().Nullable()
            .WithColumn("StartDate").AsDateTime().Nullable()
            .WithColumn("EndDate").AsDateTime().Nullable()
            .WithColumn("DoIt").AsString().Nullable()
            .WithColumn("UserId").AsInt32().NotNullable()
            .WithColumn("CategoryId").AsInt32().NotNullable();
        Create.ForeignKey("FK_Tasks_Users")
            .FromTable("Tasks").ForeignColumn("UserId")
            .ToTable("Users").PrimaryColumn("Id");
        Create.ForeignKey("FK_Tasks_Category")
            .FromTable("Tasks").ForeignColumn("CategoryId")
            .ToTable("Category").PrimaryColumn("Id");
    }

    public override void Down()
    {
        Delete.Table("Tasks");
    }
}