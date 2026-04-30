using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Collections.Properties
{
    internal class GettersAndSetters
    {
        //declaring variable
        private string name;

        

        public int ID { get; set; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name=value;
            }
        }

        //static void Main(string[] args)
        //{
        //    GettersAndSetters gs = new GettersAndSetters();
        //    gs.Name = "shiva";
        //    Console.WriteLine(gs.Name); //shiva
        //    gs.ID = 222;
        //    Console.WriteLine(gs.ID); //222

        //}

    }
}
