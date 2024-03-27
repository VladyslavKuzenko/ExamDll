// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ExamDll;
using System.Runtime.InteropServices;

//[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]

//[DllImport(@"D:\ADO.Net\ExamDll\x64\Debug\MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
//static extern double Add(double a, double b);

var a = DLLImp.A(25, 45);
var b = DLLImp.Mul(25, 45);
var c = DLLImp.Div(25, 45);
var d = DLLImp.Sub(8, 2);
//Add(2, 45);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);

DLLImp.SetError();

int error = Marshal.GetLastWin32Error();
Console.WriteLine("Код помилки: " + error);