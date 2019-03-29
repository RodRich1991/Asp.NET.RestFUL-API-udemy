using RestWithAsp.NET_core.UDEMY.v1.Model.Base;

namespace RestWithAsp.NET_core.UDEMY.V1.Model
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
