using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Adicione este arquivo em PIProjetpCards/Models/Card.cs
namespace PIProjetpCards.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CategoryId { get; set; }
    }
}
