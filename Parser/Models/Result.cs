namespace Parser.Models
{
    public class Result
    {
        public string jsonrpc { get; set; }
        public Response response { get; set; }
        public object[] errors { get; set; }
        public object[] messages { get; set; }
        public string hash { get; set; }
        public string trace { get; set; }
    }
}