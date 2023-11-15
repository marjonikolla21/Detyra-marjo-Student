using CompaniesApp.API.Data.Base;


namespace ConsoleAppApi.Data.Models
{
    public class Company: EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EstablishedYear { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}


