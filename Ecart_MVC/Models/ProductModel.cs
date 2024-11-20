 using System.ComponentModel;

namespace Ecart_MVC.Models
{
    public class Product : Category
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdType { get; set; }
    }
}