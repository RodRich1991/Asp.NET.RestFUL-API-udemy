using RestWithAsp.NET_core.UDEMY.v1.Model.Base;
using System;

namespace RestWithAsp.NET_core.UDEMY.V1.Model
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}