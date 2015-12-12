using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCOMPlusSample
{
#if DEBUG
    public class ComPlusClass
#else    
    [ComVisible(true)]
    [Guid("E0B749E5-CDF4-4DB0-8C86-5695EBFD4929")]
    public class ComPlusClass : ServicedComponent
#endif
    {
        public bool Process(
            [In, Out] ref Object inoutObject,
            [In, Out] ref string inoutString,
            [In] Object inObject,
            [In] string inString,
            [In, MarshalAs(UnmanagedType.AsAny, SafeArraySubType = VarEnum.VT_VARIANT)] Object[] inArray,
            [In, Out, MarshalAs(UnmanagedType.AsAny, SafeArraySubType = VarEnum.VT_VARIANT)] ref Object[,] inoutArray)
        {
            bool noRemainder = false;
            if (inArray.Length % 2 == 0)
                noRemainder = true;

            int length = inArray.Length / 2 + (noRemainder ? 0 : 1);
            
            Object[,] outputArray = new Object[3, length];
            
            outputArray[0, 0] = "Hello, " + ConfigurationManager.AppSettings["GreetingsRecipient"] + "!";

            for (int i = 0, j = 1, k = 0; i < inArray.Length; i++, j = j + (i % length == 0 ? 1 : 0), k = k + (i % length == 0 ? -k : 1))
            {
                outputArray[j, k] = inArray[i];
            }

            inoutArray = outputArray;

            return true;
        }
    }
}
