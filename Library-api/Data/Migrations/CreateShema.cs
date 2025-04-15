
using FluentMigrator;

namespace Library_api.Data.Migrations
{
    public class CreateShema : Migration
    {
        public override void Up()
        {
            Create.Table("libraries")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("location").AsString().NotNullable();

            Create.Table("books")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("title").AsString().NotNullable()
                .WithColumn("author").AsString().NotNullable()
                .WithColumn("publishedYear").AsInt32().NotNullable()
                .WithColumn("LibraryId").AsInt32().ForeignKey("libraries", "id").OnDelete(System.Data.Rule.Cascade);
        }

        public override void Down()
        {
            Delete.Table("books");
            Delete.Table("libraries");
        }
    }
}
