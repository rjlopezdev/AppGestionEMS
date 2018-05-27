namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGrupoClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoClases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoClases");
        }
    }
}
