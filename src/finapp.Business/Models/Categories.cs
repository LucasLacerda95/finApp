using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using finnapp.Business.Models.Enums;
using Microsoft.AspNetCore.Identity;


namespace finnapp.Business.Models
{

    public class Categories{
        [Key]
        public Guid CategoryId { get; set; }
       
        public string? CategoryName { get; set; }

        public CategoryType CategoryType { get; set; }

        public DateTime CategoryRegisterDate { get; set; }


        [ForeignKey("User")]
        public string? UserId { get; set; }


        /* Relacionamento EF*/
        public virtual IdentityUser? User { get; set; }
    }
}