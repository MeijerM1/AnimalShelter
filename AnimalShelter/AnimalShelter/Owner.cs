using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Owner
    {
        //Fields
        string name;
        DateTime birthDate;
        string adress;

        // Properties
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { this.birthDate = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { this.adress = value; }
        }

        //Constructors
        public Owner(string name, DateTime birthDate, string adress)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.Adress = adress;
        }
        

    }
}
