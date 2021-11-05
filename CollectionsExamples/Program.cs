using System.Collections.Generic;
using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Linq;
using CollectionsExamples.Students;

namespace CollectionsExamples
{

    class Bag<T> : ICollection<T>
    {
        List<T> list;
        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Random R = new Random();
            return list.OrderBy(v => R.Next()).GetEnumerator();
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    interface IRunnable { void Run(); }


    internal class Program
    {
        static (string navnupper, int l, int twelve) Foo(string navn)
        {

            return (navn.ToUpper(), navn.Length, 12);
        }


        static string GetAsString(int v)
        {
            Console.WriteLine("Vi beregner v! : " + v);
            return v.ToString();
        }

        static Dictionary<string, Person> sd = new();
        static void Main(string[] args)
        {
            new AdvancedLinq().Run();

            //StudentData.LiveExample();
            return;
            //Tuple<string, int, int> tuple = new Tuple<string, int, int>("Thomas", 12, 12);



            //var (navn, tolv,_ ) = Foo("Thomas");
            //Console.WriteLine(navn);


            //var tal = Enumerable.Range(0, 4);

            //IEnumerable<string> v1 = tal.Select(v => GetAsString(v)).ToList();
            //IEnumerable<string> v2 = tal.Select(GetAsString).ToList();

            

            //IEnumerable<int> v3 = tal.Select(v =>
            //{
            //    Console.WriteLine("Vi beregner v! : "+ v);
            //    return v;
            //});
            //IEnumerable<int> v4 = tal.Select(v => v + v);

            //foreach (var item in v3)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in v3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(v3.First());
            //Console.WriteLine(v3.Skip(2).First());



            //(string, string) g = ("Thomas", "Bøgholm");

            


            //List<string> list = new List<string>() { "hans","poul", "ole"};


            //var k2 = new { G=g, ListL=list };

            

            //var v =list[0];
            //var k =sd["Fisk"];
            ////sd

            //foreach (KeyValuePair<string, Person> item in sd)
            //{

            //}


            //IEnumerator<string> e = list.GetEnumerator();
            //while(e.MoveNext())
            //    Console.WriteLine(e.Current);

            //foreach (string item in list)
            //{

            //}


            //new AdvancedLinq().Run();
        }
    }
}
    
    
