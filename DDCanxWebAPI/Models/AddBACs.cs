namespace DDCanxWebAPI.Models
{
    public class AddBACs
    {
        public string PolicyRef { get; set; } = String.Empty;

        public Boolean ContinueDD { get; set; }

        public string PaidBy { get; set; } = string.Empty;

        public string NewDate { get; set; } = String.Empty;

        public Boolean ChangeDate { get; set; }

        public string Amount { get; set; } = string.Empty;

        public string DueDate { get; set; } = String.Empty;

        public int Branch { get; set; }
    }
}
