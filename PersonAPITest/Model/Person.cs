using System.ComponentModel.DataAnnotations.Schema;

namespace PersonAPITest.Model
{

    [Table("person")]
    public class Person
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }


        [Column("address")]
        public string Address { get; set; }


        [Column("gender")]
        public string Gender { get; set; }


        [Column("age")]
        public int Age { get; set; }


    }
}
