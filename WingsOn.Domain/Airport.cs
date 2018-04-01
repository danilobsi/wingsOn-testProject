namespace WingsOn.Domain
{
    public class Airport : DomainObject
    {
        public string Code { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}
