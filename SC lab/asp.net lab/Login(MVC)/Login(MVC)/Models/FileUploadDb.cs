using System;
using System.Data.Entity;
using System.Linq;

namespace Login_MVC_.Models
{
    public class FileUploadDb : DbContext
    {
        // Your context has been configured to use a 'FileUploadDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Login_MVC_.Models.FileUploadDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FileUploadDb' 
        // connection string in the application configuration file.
        public FileUploadDb()
            : base("name=FileUploadDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<FileClass> FileClasses { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}