using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Dog : Animal
    {
        private DateTime _timeOfLastWalk;

        public DateTime TimeOfLastWalk
        {
            get { return _timeOfLastWalk; }
        }

        public Dog(string name, DateTime birthDate, Owner owner):base(name, birthDate, owner)
        {
        }

        public void ChangeDateOfLastWalk(DateTime date)
        {
            _timeOfLastWalk = date;
        }
    }
}
