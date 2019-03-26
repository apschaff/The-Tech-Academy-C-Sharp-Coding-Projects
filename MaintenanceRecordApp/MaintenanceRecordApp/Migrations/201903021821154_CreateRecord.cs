namespace MaintenanceRecordApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRecord : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vehicle = c.String(),
                        MaintenanceDate = c.DateTime(nullable: false),
                        MaintenanceDescription = c.String(),
                        PerformedBy = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Records");
        }
    }
}
