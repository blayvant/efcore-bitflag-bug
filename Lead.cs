using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreBitflagBug
{
    public class Lead
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public LeadType LeadType { get; set; }
    }

}