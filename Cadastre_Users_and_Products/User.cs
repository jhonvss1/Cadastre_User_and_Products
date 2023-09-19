using Cadastre_User_and_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cadastre_User_and_Products
{
    public class User
    {

        public string? Name { get; set;  }
        public string? Email { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public bool active { get; set; }
      

    }
}

