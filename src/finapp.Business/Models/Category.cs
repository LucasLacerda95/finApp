using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using finapp.Business.Models;
using finnapp.Business.Models.Enums;
using Microsoft.AspNetCore.Identity;


namespace finnapp.Business.Models
{

    public class Category : Entity
    {

        [ForeignKey("User")]
        public string? UserId { get; set; }

        public string? CategoryName { get; set; }

        public CategoryType CategoryType { get; set; }

        public DateTime CategoryRegisterDate { get; set; }


        /* Relacionamento EF*/
        public virtual IdentityUser? User { get; set; }
    }
}