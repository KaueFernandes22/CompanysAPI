using System.ComponentModel.DataAnnotations.Schema;

namespace CompanysAPI.Model
{
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public string Price { get; set; }

        [Column("stock")]
        public int Stock { get; set; }
    }
}
