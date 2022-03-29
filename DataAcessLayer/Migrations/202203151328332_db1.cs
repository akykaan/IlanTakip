namespace DataAcessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdentityNumber = c.String(),
                        BirthYear = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.Int(nullable: false),
                        CvId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cvs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        GitHubLink = c.String(),
                        CoverLetter = c.String(),
                        Active = c.Boolean(nullable: false),
                        Candidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id)
                .Index(t => t.Candidate_Id);
            
            CreateTable(
                "dbo.JobExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkPlaceName = c.String(),
                        Position = c.String(),
                        StartYear = c.DateTime(nullable: false),
                        EndYear = c.DateTime(nullable: false),
                        CvId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cvs", t => t.CvId, cascadeDelete: true)
                .Index(t => t.CvId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LanguageLevel = c.Int(nullable: false),
                        LanguageName = c.String(),
                        ProgrammingLanguageLevel = c.Int(nullable: false),
                        ProgrammingLanguageName = c.String(),
                        Cv_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cvs", t => t.Cv_id)
                .Index(t => t.Cv_id);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolId = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        DepartmentName = c.String(),
                        StartYear = c.String(),
                        StartEnd = c.String(),
                        cv_id = c.Int(),
                    })
                .PrimaryKey(t => t.SchoolId)
                .ForeignKey("dbo.Cvs", t => t.cv_id)
                .Index(t => t.cv_id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                        EventOwner = c.String(),
                        EventDay = c.DateTime(nullable: false),
                        Candidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id)
                .Index(t => t.Candidate_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.JobAdverts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobDescription = c.String(),
                        JobTitle = c.String(),
                        CityName = c.String(),
                        OpenPosition = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        EmployerId = c.Int(nullable: false),
                        Employer_EmployersId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employers", t => t.Employer_EmployersId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.Employer_EmployersId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployersId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        CompanyMailAddress = c.String(),
                        CompanyName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.EmployersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobAdverts", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.JobAdverts", "Employer_EmployersId", "dbo.Employers");
            DropForeignKey("dbo.Events", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.Schools", "cv_id", "dbo.Cvs");
            DropForeignKey("dbo.Languages", "Cv_id", "dbo.Cvs");
            DropForeignKey("dbo.JobExperiences", "CvId", "dbo.Cvs");
            DropForeignKey("dbo.Cvs", "Candidate_Id", "dbo.Candidates");
            DropIndex("dbo.JobAdverts", new[] { "City_CityId" });
            DropIndex("dbo.JobAdverts", new[] { "Employer_EmployersId" });
            DropIndex("dbo.Events", new[] { "Candidate_Id" });
            DropIndex("dbo.Schools", new[] { "cv_id" });
            DropIndex("dbo.Languages", new[] { "Cv_id" });
            DropIndex("dbo.JobExperiences", new[] { "CvId" });
            DropIndex("dbo.Cvs", new[] { "Candidate_Id" });
            DropTable("dbo.Employers");
            DropTable("dbo.JobAdverts");
            DropTable("dbo.Cities");
            DropTable("dbo.Events");
            DropTable("dbo.Schools");
            DropTable("dbo.Languages");
            DropTable("dbo.JobExperiences");
            DropTable("dbo.Cvs");
            DropTable("dbo.Candidates");
        }
    }
}
