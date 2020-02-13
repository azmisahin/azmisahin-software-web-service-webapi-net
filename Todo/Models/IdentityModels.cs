using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Todo.Models
{
    /// <summary>
    /// ApplicationUser sınıfınıza daha fazla özellik ekleyerek kullanıcıya profil verileri ekleyebilirsiniz. Daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkID=317594 adresini ziyaret edin.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Generate User Identity
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // authenticationType özelliğinin CookieAuthenticationOptions.AuthenticationType içinde tanımlanmış olanla eşleşmesi gerektiğini unutmayın
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Özel kullanıcı taleplerini buraya ekle
            return userIdentity;
        }
    }

    /// <summary>
    /// Application Db Context
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Identity Db Context
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /// <summary>
        /// Todos
        /// </summary>
        public virtual DbSet<Todo> Todos { get; set; }
    }
}