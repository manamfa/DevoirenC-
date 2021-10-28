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
            //Console.WriteLine("Hello World!");
            ArrayList numbers = new ArrayList();  
            numbers.Add(16);    //int
            numbers.Add(15.3);  //float
            numbers.Add("manamfasha");   //string
            numbers.Add('M');     //char
      
            foreach (var nbr in numbers)  
            {  
            Console.Write("{0} ", nbr);
            }


        }
    }
}
