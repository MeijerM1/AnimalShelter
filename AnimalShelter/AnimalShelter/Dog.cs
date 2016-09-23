using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog : Animal
    {
        private DateTime timeOfLastWalk;

        public DateTime TimeOfLastWalk
        {
            get { return timeOfLastWalk; }
        }

        public Dog(string name, DateTime birthDate, Owner owner):base(name, birthDate, owner)
        {

        }

        public void changeDateOfLastWalk(DateTime date)
        {
            timeOfLastWalk = date;
        }
    }
}
