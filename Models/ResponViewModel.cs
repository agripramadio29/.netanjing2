namespace WebApplicationTest.Models
{
    public class ResponViewModel<T>

    {

 
            public int code { get; set; }
            public string message { get; set; }
            public T data { get; set; }
            public string error { get; set; }
            public string error_description { get; set; }
        
    }
}
