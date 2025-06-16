using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Employee : IPerson
    {
        public double Oklad { get; set; }
        public int Stavka { get; set; }
       
        public double Income() => (Oklad * 12) - (((Oklad * 12) / 100) * Stavka);
        public override string? ToString()
         {
           return $"Годовой доход:{Income():F2}";
         }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Patronymic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
