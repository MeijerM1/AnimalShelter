using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Cat : Animal
    {
        private List<string> _habits;

        public List<string> Habits
        {
            get { return _habits; }
        }

        public Cat(string name, DateTime birthDate, Owner owner): base(name, birthDate, owner)
        {
            _habits = new List<string>();
        }

        public void AddHabit(string habit)
        {
            _habits.Add(habit);
        }

        public void RemoveHabit(string habit)
        {
            // TODO
        }
    }
}
