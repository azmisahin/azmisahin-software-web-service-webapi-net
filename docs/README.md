# ![Logo](media/favicon.png)

# Web Api with .netframework

It uses the ASP.NET Web API to create an API that returns a list of web products.

# Test Project
![Test-Project](media/test-project.png)

[Document Web Site](https://azmisahin.github.io/azmisahin-software-web-service-webapi-net/)

![api-documentation](media/api-documentation.png)

# Password Policy
IdentityConfig.cs
```
manager.PasswordValidator = new PasswordValidator
{
    RequiredLength = 6,
    RequireNonLetterOrDigit = false,
    RequireDigit = false,
    RequireLowercase = false,
    RequireUppercase = false,
};
```
# Add Todo Table
```
namespace Todo.Models
{
    /// <summary>
    /// Todo
    /// </summary>
    [Table("Todos")]
    public class Todo
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        [DefaultValue(0)]
        [Column(Order = 0)]
        public int Order { get; set; }

        /// <summary>
        /// Create Date
        /// </summary>
        public DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// Is Active
        /// </summary>
        [DefaultValue(true)]
        public bool isActive { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [Required]
        [Display(Name = "Baþlýk")]
        [StringLength(50, ErrorMessage = "{0}, en az {2} karakter uzunluðunda olmalýdýr.", MinimumLength = 6)]
        public string Title { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Required]
        [Display(Name = "Açýklama")]
        [StringLength(100, ErrorMessage = "{0}, en az {2} karakter uzunluðunda olmalýdýr.", MinimumLength = 6)]
        public string Description { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Telefon Numarasý")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Todo
        /// </summary>
        public Todo()
        {
            CreateDate = DateTime.Now;
        }
    }
```

# IdentityModels
```
 public class ApplicationDbContex{
         .
         .
         .

        /// <summary>
        /// Todos
        /// </summary>
        public virtual DbSet<Todo> Todos { get; set; }

        .
        .
        .
```
# Enable Migration
Enable-Migrations: Enables the migration in your project by creating a Configuration class.
Add-Migration: Creates a new migration class as per specified name with the Up() and Down() methods.
Update-Database: Executes the last migration file created by the Add-Migration command and applies changes to the database schema.

Package Manager Console
```
Enable-Migrations 
Add-Migration Todos
Update-Database
```

![todo-table-migration-code-first](media/todo-table-migration-code-first.png)