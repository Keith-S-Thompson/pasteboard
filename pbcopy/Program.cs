using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbcopy
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            StringBuilder pasteboard = new StringBuilder();
            Int32 c;
            while ((c = Console.Read()) != -1)
            {
                pasteboard.Append(Convert.ToChar(c));
            }
            Clipboard.SetText(pasteboard.ToString());
        }
    }
}
