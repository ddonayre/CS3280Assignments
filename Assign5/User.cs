using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }
        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
