using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit_OperatorOverloading_Nullable.Models
{
    
    public class Kelvin
    {
        public int Degree { get; set; }
        public Kelvin(int degree) { 
        Degree = degree;
        }

    }
}
