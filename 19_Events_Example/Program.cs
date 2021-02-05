using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Events_Example
{
    static class Program
    {
        static Button but1 = new Button { Text = "Button 1" };
        static Random rand = new Random();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            but1.MouseMove += MouseMoved;
            var form = new Form();
            form.Controls.Add(but1);
            Application.Run(form);
        }

        static void MouseMoved(object sender, MouseEventArgs e)
        {
            but1.Top = rand.Next() % 200;
            but1.Left = rand.Next() % 200;
        }
    }
}
