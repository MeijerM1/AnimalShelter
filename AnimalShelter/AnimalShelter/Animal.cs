using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public abstract class Animal
    {
        // Fields
        private string _name;
        private DateTime _birthDate = new DateTime();
        private Owner _owner;
        private bool _isReserved;
        private decimal _price;

        //Property's
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        public DateTime Birthdate
        {
            get { return _birthDate; }
            set { this._birthDate = value; }
        }
        public Owner Owner
        {
            get { return _owner; }
            set { this._owner = value; }
        }
        public bool IsReserved
        {
            get { return _isReserved; }
            set { this._isReserved = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { this._price = value; }
        }

        // Constructors
        public Animal(string name, DateTime birthDate)
        {
            this._name = name;
            this._birthDate = birthDate;
            _isReserved = false;
        }

        public void ChangeOwner(Owner owner)
        {
            this._owner = owner;
        }

        public void ChangeReservation(bool status)
        {
            _isReserved = status;
        }

        public void ChangePrice(decimal price)
        {
            _price = price;
        }
    }
}
