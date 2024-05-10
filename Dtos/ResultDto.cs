namespace Authentication_Authorization_AddApiEndpoints.Dtos
{
    public class ResultDto
    {
        public bool status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object data { get; set; }
        
    }
}
