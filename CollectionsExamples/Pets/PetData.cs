using System.Collections.Generic;
using System.Linq;

namespace CollectionsExamples
{


    class PetData

    {
        public PetData()
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };
            Person phyllis = new Person { FirstName = "Phyllis", LastName = "Harris" };

            Cat barley = new Cat { Name = "Barley", Owner = terry };
            Cat boots = new Cat { Name = "Boots", Owner = terry };
            Cat whiskers = new Cat { Name = "Whiskers", Owner = charlotte };
            Cat bluemoon = new Cat { Name = "Blue Moon", Owner = rui };
            Cat daisy = new Cat { Name = "Daisy", Owner = magnus };

            Dog fourwheeldrive = new Dog { Name = "Four Wheel Drive", Owner = phyllis };
            Dog duke = new Dog { Name = "Duke", Owner = magnus };
            Dog denim = new Dog { Name = "Denim", Owner = terry };
            Dog wiley = new Dog { Name = "Wiley", Owner = charlotte };
            Dog snoopy = new Dog { Name = "Snoopy", Owner = rui };
            Dog snickers = new Dog { Name = "Snickers", Owner = arlene };

            People = new List<Person> { magnus, terry, charlotte, arlene, rui, phyllis };
            Cats =   new List<Cat> { barley, boots, whiskers, bluemoon, daisy };
            Dogs =   new List<Dog> { fourwheeldrive, duke, denim, wiley, snoopy, snickers };
        }

        public List<Person> People { get; }
        public IEnumerable<Pet> Pets => Enumerable.Empty<Pet>().Concat(Cats).Concat(Dogs);
        public List<Cat> Cats { get; }
        public List<Dog> Dogs { get; }
    }
}
    
    
