using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Cat> Cats { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Owner> Owners { get; set; }

        public Administration()
        {
            Cats = new List<Cat>();
            Dogs = new List<Dog>();
            Owners = new List<Owner>();
        }


        public void AddCat(Cat cat)
        {
            Cats.Add(cat);
        }

        public void AddDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public void AddOwner(Owner owner)
        {
            Owners.Add(owner);
        }

        public void RemoveCat(Cat cat)
        {
            Cats.Remove(cat);
        }

        public void RemoveDog(Dog dog)
        {
            Dogs.Remove(dog);
        }
    }
}
