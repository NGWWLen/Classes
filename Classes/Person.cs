using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    
        public class Person
        {
            public string Name { get; set; }
            public char Sex { get; set; }
            public int Age { get; set; }
            public int Height { get; set; }
            public float Weight { get; set; }

            public Person()
            { }

        public Person(string n, char s, int a, int h, float w)
        {
            Name = n;
            Sex = s;
            Age = a;
            Height = h;
            Weight = w;
        }

        }
    
}
