// 已啟用模型 'C:\CalvinLab\EvertrustLab1\MvcEvertrust\MvcEvertrust\Models\OpenNorthwind.edmx' 的 T4 程式碼產生。
// 若要啟用舊版程式碼產生，請將 [程式碼產生策略] 設計工具屬性的值
//變更為 [舊版 ObjectContext]。當模型在設計工具中開啟時，這個屬性便可
//以在 [屬性] 視窗中使用。

// 如果尚未產生任何內容和實體類型，可能是因為您建立了空的模型，但
//尚未選擇要使用的 Entity Framework 版本。若要為您的模型產生內容類別和
//實體類型，請在設計工具中開啟模型，以滑鼠右鍵按一下設計工具介面並
//選取 [從資料庫更新模型]、[由模型產生資料庫] 或 [加入程式碼產生
//項目]。
namespace CFNewDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OpenNorthwind : DbContext
    {
        // Your context has been configured to use a 'OperaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CFNewDB.Models.OperaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OperaContext' 
        // connection string in the application configuration file. 
        public OpenNorthwind()
            : base("name=OpenNorthwind")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; } 
    }

    //public class MyEntity 
    //{ 
    //    public int Id { get; set; } 
    //    public string Name { get; set; } 
    //} 
}