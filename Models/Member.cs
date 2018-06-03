using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Member
    {
        public Member()
        {

        }

        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Alamat { get; set; }
        [MaxLength(50)]
        public string nama { get; set; }
        public int Umur { get; set; }
    }
}