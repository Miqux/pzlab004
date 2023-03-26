using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab004
{
    public class Person : IComparable<Person>, IComparer<Person>, IEnumerable<Car>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Car> Cars { get; set; }

        public Person(string name, string lastName, int age, List<Car> cars) 
        { 
            Name = name;
            LastName = lastName;
            Age = age;
            Cars = cars;
        }
        public Person() { }
        public override string ToString()
        {
            string cars = String.Join(", ", Cars);
            return "$ Imie: " + Name + " Nazwisko: " + LastName + " Wiek: " + Age + " Auta : " + cars + " SUMA = " + Cars.Sum(x => x.Price);
        }

        public int CompareTo(Person? other)
        {
            if (other.Cars.Sum(x => x.Price) > this.Cars.Sum(x => x.Price))
                return 1;
            return -1;
        }

        public int Compare(Person? x, Person? y)
        {
            if (x.Age > y.Age)
                return 1;
            if (x.Age == y.Age)
                return 0;
            return -1;
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
