using System.ComponentModel.DataAnnotations.Schema;

namespace CompanysAPI.Model
{
    public class Company
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("social_name")]
        public string SocialName { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("document_number")]
        public string DocumentNumber { get; set; }

        [Column("address")]
        public string Address { get; set; }
    }
}
