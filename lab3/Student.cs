using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Student : IPerson
    {
        public double Sipendia { get; set; }
        
        public double Income() => Sipendia * 12;
        public override string? ToString()
        {
            return $"Годовой доход:{Income():F2}";
        }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Patronymic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
