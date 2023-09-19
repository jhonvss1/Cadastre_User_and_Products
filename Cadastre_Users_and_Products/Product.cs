using Cadastre_User_and_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastre_Users_and_Products
{
    public class Product
    {
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public string? NameProduct {  get; set; }
        public decimal PriceProduct { get; set; }
    }

}
