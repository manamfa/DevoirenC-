using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common; 
using System.Data;
using System.Data.SqlClient;

namespace manamfasha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello voici mes recherche!");
            ArrayList numbers = new ArrayList();  
            numbers.Add(16);    //int
            numbers.Add(15.3);  //float
            numbers.Add("manamfasha");   //string
            numbers.Add('M');     //char
      
            foreach (var nbr in numbers)  
            {  
            Console.Write("{0} ", nbr);
            Console.WriteLine("\n");
            }
             


            Hashtable languages = new Hashtable();  
            languages.Add(1, "physiqe");  
            languages.Add(2, "C++");  
            languages.Add(3, "php");  
            languages.Add(4, "VB");  
            
            foreach (DictionaryEntry language in languages)  
            {  
            Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);  
             Console.WriteLine("\n"); 
            }


            Stack stk = new Stack();  
            stk.Push("chimie");  
            stk.Push("economie");  
            stk.Push("Biologie");  
            stk.Push("Technologie");  
            foreach (var aff in stk)  
            {
            Console.WriteLine(aff);
            Console.WriteLine("\n"); 
            }

        }
    }
}
