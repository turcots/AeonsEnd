using System;
using System.Collections.Generic;
using SQLiteAeonsEnd.Affaires;
using SQLiteAeonsEnd.Affaires.SqlLite;

namespace SQLiteAeonsEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var aeonsEndBd = new Database();
            
            aeonsEndBd.Create();

            Console.ReadLine();
        }
    }
}
