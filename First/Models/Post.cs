using System;
namespace First.Models
{
	public class Post
	{
        public int? ID { get; set; }
        required

        public string? TITLE { get; set; }
        public string? CONTENT { get; set; }
        
        public DateTime DATE { get; set; }
        public int? USER_ID { get; set; }
    }
   
}

