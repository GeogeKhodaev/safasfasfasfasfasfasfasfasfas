using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button2.Location = new Point(button2.Location.X - 5, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 5, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.D)
            {
                button2.Location = new Point(button2.Location.X + 5, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 5, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                button2.Visible = false;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button2.Location = new Point(button2.Location.X - 5, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 5, button1.Location.Y);
            }

            else if (e.KeyCode == Keys.D)
            {
                button2.Location = new Point(button2.Location.X + 5, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 5, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                button2.Visible = true;
            }
        }
        Button button;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            button = new Button();
            button.Location = new Point(r.Next(16, 1060), 0);
            button.BackgroundImage = WinFormsApp2.Properties.Resources.Meteor;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Size = new Size(98, 95);
            this.Controls.Add(button);
            
        }
        int a = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            

            foreach (Control c in this.Controls)
            {
                if (c.Name != "button1" && c.Name != "button2"&& c.Name != "button3" && c.Name != "button4" )
                {
                    if (c is Button)
                    {
                        ((Button)c).Location = new Point(c.Location.X, c.Location.Y + 5);

                    }

                    if (c.Location.X/10 == button2.Location.X/10&&c.Location.Y/10==button2.Location.Y/10&&button2.Visible==true)
                    {
                        a=a+1;
                        this.Controls.Remove(c);
                        textBox2.Text = Convert.ToString(a);
                    }
                    if (c.Location.X / 10 == button1.Location.X / 10 && c.Location.Y / 10 == button1.Location.Y / 10 && button1.Visible == true)
                    {
                        c.Visible = false;
                        button1.Visible = false; 
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false; 
                        button = new Button();
                        button.Location = new Point(button1.Location.X, button1.Location.Y);
                        button.BackgroundImage = WinFormsApp2.Properties.Resources.exp;
                        button.BackgroundImageLayout = ImageLayout.Zoom;
                        button.Size = new Size(98, 95);
                        this.Controls.Add(button);
                        MessageBox.Show("Ты проиграл");
                        this.Close();
                        
                    }
                }

            }
            //this.Controls.Remove(button);



        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(button2.Location.X/10);

            if (button != null)
                textBox3.Text = Convert.ToString(button.Location.X / 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible=true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }
    }
}
