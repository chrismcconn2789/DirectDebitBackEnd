using System.ComponentModel.DataAnnotations;

namespace DDCanxWebAPI.Models
{
    public class BACs
    {
        [Required]
        public string DueDate { get; set; } = String.Empty;

        [Required]
        public int Branch { get; set; }

        [Required]
        [Key]
        public string PolicyRef { get; set; } = string.Empty;

        [Required]
        public Boolean ContinueDD { get; set; }

        [Required]
        public string PaidBy { get; set; } = string.Empty;

        public string NewDate { get; set; } = String.Empty;

        public Boolean ChangeDate { get; set; }

        [Required]
        public string Amount { get; set; } = string.Empty;
    }

}
