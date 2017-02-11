using Microsoft.EntityFrameworkCore;

namespace MySite.Models
{
    public class Page
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}