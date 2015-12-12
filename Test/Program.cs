using DotNetCOMPlusSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ComPlusClass complusClass = new ComPlusClass();
            
            object inoutObject = 1;
            string inoutString = "inoutString";
            object inObject = 2;
            string inString = "inString";
            object[] myInArray = new object[5];
            myInArray[0] = 0;
            myInArray[1] = "1";
            myInArray[2] = 2;
            myInArray[3] = "3";
            myInArray[4] = 4;
            object[,] myInoutArray = null;

            bool result = complusClass.Process(ref inoutObject, ref inoutString, inObject, inString, myInArray, ref myInoutArray);

            Console.ReadKey();
        }
    }
}
