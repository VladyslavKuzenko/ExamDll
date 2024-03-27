using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamDll
{
    internal class DLLImp
    {
        [DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll",EntryPoint = "Add",CallingConvention = CallingConvention.Cdecl)]
        public static extern double A(double a, double b);

        [DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll", ExactSpelling =true, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Mul(double a, double b);

        [DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll",CharSet=CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Div(double a, double b);

        [DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll",SetLastError =true, CallingConvention = CallingConvention.Cdecl)]
        public static extern double Sub(double a, double b);

        [DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetError();
    }
}
