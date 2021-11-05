using System;
using System.Linq;
using System.Collections.Generic;

namespace CollectionsExamples
{
    static class MyLinqExtensions
    {
        // Tuple<T,T> er også en mulighed
        public static IEnumerable<(T left, T right)> Pairify<T>(this IEnumerable<T> e)
        {
            return e.Aggregate(new
            {
                last = default(T),
                acc = Enumerable.Empty<(T left, T right)>()
            }, (acc, v) => new { last = v, acc = acc.acc.Append((left: acc.last, right: v)) },
                    f => f.acc.Skip(1));
        }

        public static IEnumerable<TResult> Pairwise<TIn, TResult>(this IEnumerable<TIn> e, Func<TIn, TIn, TResult> pfunc)
        {
            return e.Pairify().Select(t => pfunc(t.left, t.right));
        }
    }
    class AdvancedLinq : IRunnable
    {
        void AggregateExample()
        {
            var pairs = Enumerable.Range(0, 10).Pairify();
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
        }


        void JoinAndGroup()
        {
            PetData d = new PetData();
            foreach (var v in d.People.Join(d.Cats, p => p, cat => cat.Owner, (owner, cats) => new { owner, cats })
                .GroupBy(v => v.owner)
                .Join(d.Dogs, v => v.Key, d => d.Owner, (acc, dog) => new { owner = acc.Key, cats = acc, dog })
                .GroupBy(v => v.owner)
                .Select(v => new
                {
                    NumberOfCats=v.First().cats.Count(),
                    NumberOfDogs = v.Select(v=>v.dog).Count(),
                    OwnerName = $"{v.Key.FirstName} {v.Key.LastName}",
                }))
            {
                Console.WriteLine($"{v.OwnerName}: Cats: {v.NumberOfCats} Dogs:{v.NumberOfDogs}");
            }
        }

        public void Run()
        {
            Console.WriteLine("Aggregate:");
            AggregateExample();
            Console.WriteLine();
            //JoinAndGroup();
            GroupJoinExample();
        }

        private static void GroupJoinExample()
        {
            PetData d = new PetData();
            foreach (var v in
                d.People
                    .GroupJoin(d.Cats, p => p, v => v.Owner, (owner, cats) => new { owner, cats })
                    .GroupJoin(d.Dogs, v => v.owner, d => d.Owner, (acc, dogs) => new { acc.owner, acc.cats, dogs })
                    .Select(v => new
                    {
                        NumberOfDogs = v.dogs.Count(),
                        NumberOfCats = v.cats.Count(),
                        OwnerName = $"{v.owner.FirstName} {v.owner.LastName}"
                    }))
            {
                Console.WriteLine($"{v.OwnerName}: Cats: {v.NumberOfCats} Dogs:{v.NumberOfDogs}");
            }
        }
    }
}
    
    
