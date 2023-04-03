using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    // IEnumerable provides us iteration over a collection

    class AnimalFarm : IEnumerable
    {
        // List that holds objects of class Animal
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm() { }

        // Indexer for AnimalFarm created using this[]
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        // Returns the number of values in the collection
        public int Count
        {
            get
            {
                return animalList.Count;
            }
        }

        // Returns an enumerator that is used to iterate through
        // the collection
        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
