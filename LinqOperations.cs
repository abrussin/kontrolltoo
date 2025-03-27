using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kontrolltoo
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Juku",
                Age = 22,
            },
            new People()
            {
                Id = 2,
                Name = "Peeter",
                Age = 18,
            },
            new People()
            {
                Id = 3,
                Name = "Aleksi",
                Age = 52,
            },
            new People()
            {
                Id = 3,
                Name = "Kati",
                Age = 24,
            },
            new People()
            {
                Id = 3,
                Name = "Mari",
                Age = 30,
            },
        };
    }
}

