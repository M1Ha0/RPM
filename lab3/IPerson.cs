using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface IPerson
    {
        string Surname { get; set; }
        string Name { get; set; }
        string Patronymic { get; set; }
        double Income();
    }
}
