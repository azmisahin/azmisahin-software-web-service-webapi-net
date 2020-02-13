using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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
        [Display(Name = "Başlık")]
        [StringLength(50, ErrorMessage = "{0}, en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        public string Title { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Required]
        [Display(Name = "Açıklama")]
        [StringLength(100, ErrorMessage = "{0}, en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        public string Description { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Todo
        /// </summary>
        public Todo()
        {
            CreateDate = DateTime.Now;
        }
    }
}