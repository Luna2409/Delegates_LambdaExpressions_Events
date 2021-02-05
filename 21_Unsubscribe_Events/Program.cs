using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Unsubscribe_Events
{
    class Person
    {
        Button myButton;

        public Person(Button but)
        {
            myButton = but;
            but.Click += CliffDive;
        }
        void CliffDive(object sender, EventArgs e)
        {
            MessageBox.Show("Jumping!");
            myButton.Click -= CliffDive;
        }
    }

    static class Program
    {
        static void Main()
        {
            var but = new Button { Text = "Jump!" };
            new Person(but);
            var form = new Form();
            form.Controls.Add(but);
            Application.Run(form);
        }
    }
}
