using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_2_inheritance
{
    class AudioBook : Publication
    {
        private int size;

        public int Size
        {
            set
            {
                if (value < 0)
                    value = 0;

                this.size = value;
            }
            get
            {
                return this.size;
            }
        }

        public AudioBook(string name, int price, int size) : base(name, price)
        {
            this.size = size;
        }

        public string GetSize()
        {
            return String.Format("{0} мин.", this.Size);
        }

        public override void Print()
        {
            System.Console.WriteLine("{0}, {1} - {2} руб.", this.Name, this.GetSize(), this.Price);
        }
    }
}
