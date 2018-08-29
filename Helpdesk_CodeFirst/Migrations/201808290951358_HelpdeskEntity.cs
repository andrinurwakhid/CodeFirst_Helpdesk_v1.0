namespace Helpdesk_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HelpdeskEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubCategoryCls", "Category_ID", "dbo.CategoryCls");
            DropIndex("dbo.SubCategoryCls", new[] { "Category_ID" });
            RenameColumn(table: "dbo.SubCategoryCls", name: "Category_ID", newName: "CategoryID");
            CreateTable(
                "dbo.TipeCls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tipe = c.String(),
                        Interval = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TicketCls", "TipeID", c => c.Int(nullable: false));
            AlterColumn("dbo.SubCategoryCls", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.SubCategoryCls", "CategoryID");
            CreateIndex("dbo.TicketCls", "TipeID");
            AddForeignKey("dbo.TicketCls", "TipeID", "dbo.TipeCls", "ID", cascadeDelete: true);
            AddForeignKey("dbo.SubCategoryCls", "CategoryID", "dbo.CategoryCls", "ID", cascadeDelete: true);
            DropColumn("dbo.TicketCls", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketCls", "Type", c => c.String());
            DropForeignKey("dbo.SubCategoryCls", "CategoryID", "dbo.CategoryCls");
            DropForeignKey("dbo.TicketCls", "TipeID", "dbo.TipeCls");
            DropIndex("dbo.TicketCls", new[] { "TipeID" });
            DropIndex("dbo.SubCategoryCls", new[] { "CategoryID" });
            AlterColumn("dbo.SubCategoryCls", "CategoryID", c => c.Int());
            DropColumn("dbo.TicketCls", "TipeID");
            DropTable("dbo.TipeCls");
            RenameColumn(table: "dbo.SubCategoryCls", name: "CategoryID", newName: "Category_ID");
            CreateIndex("dbo.SubCategoryCls", "Category_ID");
            AddForeignKey("dbo.SubCategoryCls", "Category_ID", "dbo.CategoryCls", "ID");
        }
    }
}
