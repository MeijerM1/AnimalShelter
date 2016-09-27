using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        private DateTime _timeOfLastWalk;

        public DateTime TimeOfLastWalk
        {
            get { return _timeOfLastWalk; }
        }

        public Dog(string name, DateTime birthDate):base(name, birthDate)
        {
            _timeOfLastWalk = new DateTime();
            _timeOfLastWalk = DateTime.Today;
        }

        public void ChangeDateOfLastWalk(DateTime date)
        {
            _timeOfLastWalk = date;
        }

        public override string ToString()
        {
            return "Dog";
        }
    }
}
