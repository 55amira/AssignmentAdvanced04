using System.Collections;
using System.Reflection.Metadata;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 02 Non-Generic Collection - Hashtable
            //Hashtable PhoneBook = new Hashtable();
            //
            //PhoneBook.Add("Ahmed", 111111);
            //PhoneBook.Add("Ali", 2121);
            //PhoneBook.Add("Mona", 11133);
            //PhoneBook.Add("Marim", 111451);

            //Console.WriteLine(PhoneBook.Count);
            //Console.WriteLine(PhoneBook.IsFixedSize);
            //Console.WriteLine(PhoneBook.IsReadOnly);

            //foreach (var phone in PhoneBook.Keys)
            //{
            //    Console.WriteLine(phone);
            //}

            //foreach (var phone in PhoneBook.Values)
            //{
            //    Console.WriteLine(phone);
            //}

            //PhoneBook["ahmedness"] = 1234;

            //Console.WriteLine(PhoneBook["Ahmed"]);

            //PhoneBook.Clear();
            //Console.WriteLine(PhoneBook.Count);

            //PhoneBook.Clone();

            ///var Flage = PhoneBook.Contains("Ahmed");
            ///Console.WriteLine(Flage);
            ///
            ///Flage = PhoneBook.ContainsKey("Ahmed");
            ///Console.WriteLine(Flage);
            ///
            ///
            ///Console.WriteLine("====================");
            ///
            ///foreach (DictionaryEntry item in PhoneBook)
            ///{
            ///    Console.WriteLine(item);
            ///} 
            #endregion

            #region 03 Generic Collection - Dictionary
            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            //PhoneBook.Add("Ahmed", 111111);
            //PhoneBook.Add("Ali", 2121);
            //PhoneBook.Add("Mona", 11133);
            //PhoneBook.Add("Marim", 111451);
            //
            //var Flge = PhoneBook.Remove("Ahmed");
            //Console.WriteLine(Flge);
            //
            //Flge = PhoneBook.Remove("Ahmed", out long re);
            //Console.WriteLine(Flge);
            //Console.WriteLine(re);
            //
            //foreach (KeyValuePair<string, long> item in PhoneBook)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 04 Generic Collection - HashSet
            //HashSet<string> Names = new HashSet<string>();

            //Names.Add("Ahmed");
            //Names.Add("Ali");
            //Names.Add("Amr");

            //foreach (var name in Names)
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion


        }







    }
}
