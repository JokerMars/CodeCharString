using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            string hell = "hell";
            outputAscii(hell);
            byte[] uniBytes = Encoding.Unicode.GetBytes(hell);
            outputUnicode(uniBytes);

            Console.ReadKey();
        }

        [DllImport("CodeDll.dll", EntryPoint = "outputAscii",
            ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static void outputAscii(string str);

        [DllImport("CodeDll.dll", EntryPoint = "outputUnicode",
            ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static void outputUnicode(byte[] str);
        
    }
}
