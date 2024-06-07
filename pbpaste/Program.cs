using System;
using System.Text;
using System.Windows.Forms;

namespace pbpaste
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var pasteboard = Clipboard.GetText();
            Console.Write(pasteboard);
        }
    }
}
