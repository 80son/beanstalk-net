using System;

namespace beanstalk_net.DataAccess.Models
{
    public class Note
    {
       public int Id { get; set; } 
       public DateTime CreatedOn { get; set; } 
       public DateTime UpdatedOn { get; set; }
       public string Content { get; set; }
    }
}