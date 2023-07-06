using System.ComponentModel.DataAnnotations;

namespace finapp.Api.ViewModel
{


    public class AccountViewModel
    {

        [Required]
        [StringLength(200,MinimumLength=4, ErrorMessage="O campo nome deve conter no mínimo 4 e o máximo 200 carácteres")]
        public string? AccountName { get; set; }

        [Required]
        public int AccountType { get; set; }
        
        [Required]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime AccountDateRegister { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0,c}")]
        public decimal AccountOpeningBalance { get; set; }


        [Required]
        public Guid UserId { get; set; }
    }
}