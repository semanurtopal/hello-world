using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("pencil","kalem");
            myDictionary.Add("dress", "elbise");
            myDictionary.Add("computer", "bilgisayar");



            foreach (var kelime in myDictionary.Keys)
            {
                Console.WriteLine(kelime + ": ");
                
            }

            foreach (var karşılık in myDictionary.Values)
            {
                Console.WriteLine(karşılık);
            }

        }
    }
}
