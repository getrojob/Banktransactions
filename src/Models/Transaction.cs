using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage ="Maximum 12 characters only.")]
        public string AccountNumber { get; set; }

        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string BeneficiaryName { get; set; }

        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string BankName { get; set; }

        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
