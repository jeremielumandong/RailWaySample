namespace RailSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LineColor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrainLine",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 100),
                        FirstStationId = c.Int(nullable: false),
                        LastStationId = c.Int(nullable: false),
                        LineColorId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LineColor", t => t.LineColorId)
                .ForeignKey("dbo.TrainLineStatus", t => t.StatusId)
                .Index(t => t.LineColorId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.TrainLineStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrainSchedule",
                c => new
                    {
                        TrainId = c.Int(nullable: false),
                        FromStationId = c.Int(nullable: false),
                        ToStationId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        ArriveTime = c.DateTime(nullable: false),
                        LineId = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TrainId, t.FromStationId, t.ToStationId, t.StartTime, t.ArriveTime })
                .ForeignKey("dbo.TrainLine", t => t.LineId)
                .ForeignKey("dbo.Train", t => t.TrainId, cascadeDelete: true)
                .Index(t => t.TrainId)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.Station",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrainLineStation",
                c => new
                    {
                        LineId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                        NextStationId = c.Int(nullable: false),
                        PreviousStationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LineId, t.StationId });
            
            CreateTable(
                "dbo.Train",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainSchedule", "TrainId", "dbo.Train");
            DropForeignKey("dbo.TrainSchedule", "LineId", "dbo.TrainLine");
            DropForeignKey("dbo.TrainLine", "StatusId", "dbo.TrainLineStatus");
            DropForeignKey("dbo.TrainLine", "LineColorId", "dbo.LineColor");
            DropIndex("dbo.TrainSchedule", new[] { "LineId" });
            DropIndex("dbo.TrainSchedule", new[] { "TrainId" });
            DropIndex("dbo.TrainLine", new[] { "StatusId" });
            DropIndex("dbo.TrainLine", new[] { "LineColorId" });
            DropTable("dbo.Train");
            DropTable("dbo.TrainLineStation");
            DropTable("dbo.Station");
            DropTable("dbo.TrainSchedule");
            DropTable("dbo.TrainLineStatus");
            DropTable("dbo.TrainLine");
            DropTable("dbo.LineColor");
        }
    }
}
