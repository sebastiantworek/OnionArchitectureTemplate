namespace Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterEntitiys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Attribute2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SlaveEntities",
                c => new
                    {
                        Attribute1 = c.String(nullable: false, maxLength: 128),
                        display_name = c.String(),
                        RelationToEntity1_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Attribute1)
                .ForeignKey("dbo.MasterEntitiys", t => t.RelationToEntity1_Id)
                .Index(t => t.RelationToEntity1_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SlaveEntities", "RelationToEntity1_Id", "dbo.MasterEntitiys");
            DropIndex("dbo.SlaveEntities", new[] { "RelationToEntity1_Id" });
            DropTable("dbo.SlaveEntities");
            DropTable("dbo.MasterEntitiys");
        }
    }
}
