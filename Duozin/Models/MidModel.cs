using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duozin.Models
{
    public class MidModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int MartialArts { get; set; }
        public int Fights { get; set; }
        public int Defeats { get; set; }
        public int Victories { get; set; }
    }
}