namespace BargeSurvey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BargeSample",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BargeID = c.String(),
                        RiverCondition = c.Int(nullable: false),
                        BargeType = c.Int(nullable: false),
                        LoadedPrior = c.Boolean(nullable: false),
                        PumpedAfterLight = c.Boolean(nullable: false),
                        ReadingP1 = c.Single(nullable: false),
                        ReadingP2 = c.Single(nullable: false),
                        ReadingP3 = c.Single(nullable: false),
                        ReadingP4 = c.Single(nullable: false),
                        ReadingS1 = c.Single(nullable: false),
                        ReadingS2 = c.Single(nullable: false),
                        ReadingS3 = c.Single(nullable: false),
                        ReadingS4 = c.Single(nullable: false),
                        SurveyId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Survey", t => t.SurveyId, cascadeDelete: true)
                .Index(t => t.SurveyId);
            
            CreateTable(
                "dbo.Survey",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Customer = c.String(nullable: false),
                        SamplerName = c.String(nullable: false),
                        Terminal = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.Int(nullable: false),
                        Purpose = c.String(nullable: false),
                        SurveyDate = c.DateTime(nullable: false),
                        ClosedOut = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BargeSample", "SurveyId", "dbo.Survey");
            DropIndex("dbo.BargeSample", new[] { "SurveyId" });
            DropTable("dbo.Survey");
            DropTable("dbo.BargeSample");
        }
    }
}
