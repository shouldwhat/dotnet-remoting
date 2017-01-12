using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Client
{
    public class AddUserEventArgs
    {
        public String Name { get; set; }
        public String Age { get; set; }
        public String Sex { get; set; }

        public String Position { get; set; }

        public AddUserEventArgs(String name, String Age, String sex, String position)
        {
            this.Name = name;
            this.Age = Age;
            this.Sex = sex;
            this.Position = position;
        }
    }
}
