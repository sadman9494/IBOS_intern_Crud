namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeAttendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        present = c.Boolean(nullable: false),
                        absent = c.Boolean(nullable: false),
                        offday = c.Boolean(nullable: false),
                        eId = c.Int(nullable: false),
                        employees_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.employees_Id)
                .Index(t => t.employees_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        eName = c.String(),
                        code = c.String(),
                        salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeAttendances", "employees_Id", "dbo.Employees");
            DropIndex("dbo.EmployeeAttendances", new[] { "employees_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeAttendances");
        }
    }
}
