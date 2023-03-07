using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
          InitializeComponent();
        }
        List<drink> shell = new List<drink>();
        //void eat(int mouth)
        //{
        //    if (mouth < 10)
        //    {
        //        MessageBox.Show("kal");
        //    }
        //    else if (mouth > 20)
        //    {
        //        MessageBox.Show("kharab");
        //    }
        //    else
        //    {
        //        while (mouth != 0)
        //        {
        //            mouth--;
        //        }
        //    }
        //}
        void drinking(drink dr)
        {
            shell.Add(dr);
            drink h = new drink();
            h.gas = 10;
            h.sugar = 10;
            h.water = 10;
            shell.Add(h);
        }
        List <string> colors = new List<string>();
        bool select (string colorcheck)
        { 
            foreach (var item in colors)
            {
                if (item == colorcheck)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          //  eat(Convert.ToInt16(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (select(textBox1.Text) == false) 
            {
                colors.Add(textBox1.Text);
            }
            listBox1.DataSource = null;
            listBox1.DataSource = colors;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
