using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кнопки_и_свойства
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random one = new Random();
            int x = one.Next(0, 500);
            int y = one.Next(0, 500);              
            
            this.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random one = new Random();
            int x = one.Next(0, 200);
            int y = one.Next(0, 200);

            button2.Location = new Point(x, y);
        }
        int count = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            //button1.Text = "Кнопка нажата до  " + count + " раз(a)";
          
                if (count == 0) button3.BackColor = Color.Red;

                if (count == 1) button3.BackColor = Color.Yellow;

                if (count == 2) button3.BackColor = Color.Green;
            if (count == 2) count = -1; 

            count++;
            

           //button1.Text = "Кнопка нажата  " + count + " раз(a)";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
