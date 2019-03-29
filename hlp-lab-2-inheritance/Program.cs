using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_2_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication publicationSample = new Publication("Комсомольская правда", 20);
            publicationSample.Print();

            Book bookSample = new Book("Хайкин С. Искусственные нейронные сети", 5780, 660);
            bookSample.Print();

            AudioBook audioBookSample = new AudioBook("Азимов Айзек - Академия", 219, 183);
            audioBookSample.Print();

            System.Console.In.Read();
        }
    }
}
