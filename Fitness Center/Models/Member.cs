using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Center
{
    public abstract class Member
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public abstract void CheckIn();
    


    }
}
