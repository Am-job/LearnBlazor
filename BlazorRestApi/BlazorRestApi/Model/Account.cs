namespace BlazorRestApi.Model
{
    public class Account
    {
        public string accid { get; set; } = string.Empty;
        public string acc_name { get; set; } = string.Empty;

        public string acc_no { get; set; } = string.Empty;
        public string acc_type { get; set;} = string.Empty;

        public string currid { get; set; } = string.Empty;
        public bool sLock { get; set; } = false;

        public DateTime sUdt { get; set; }

        public string sEditBy { get; set; } = string.Empty;
    }
}
