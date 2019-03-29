using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_2_inheritance
{
    class Publication
    {
        private string name;
        public string Name { 
            get {
                return this.name;
            }
            set
            {
                if ("" == value)
                {
                    throw new Exception("Имя публикации не может быть пустым");
                }
                this.name = value;
            }
        }

        private int price;

        public int Price { 
            get {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.price = value;
            }
        }

        public Publication(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public virtual void Print()
        {
            System.Console.Out.WriteLine("{0} - {1} руб.", this.Name, this.Price);
        }
    }
}
