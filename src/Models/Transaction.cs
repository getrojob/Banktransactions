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
        [Required]
        public string AccountNumber { get; set; }

        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BeneficiaryName { get; set; }

        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string BankName { get; set; }

        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required]
        public string SWIFTCode { get; set; }

        [Required]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
