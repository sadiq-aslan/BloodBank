using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Form3 : Form
    {
  
        public Form3()
        {
           
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
         void setdata() {
          
            label20.Text = StaticClass1.listt[index * 10 + 2];
            label19.Text = StaticClass1.listt[index * 10 + 3];
            label18.Text = StaticClass1.listt[index * 10 + 4];
            label17.Text = StaticClass1.listt[index * 10 + 5];
            label16.Text = StaticClass1.listt[index * 10 + 6];
            label15.Text = StaticClass1.listt[index * 10 + 7];
            label14.Text = StaticClass1.listt[index * 10 + 8];
            label13.Text = StaticClass1.listt[index * 10 + 9];
        }
        void setphoto()
        {
            
            if (StaticClass1.listt[index*10+9].ToString().Length != 0)
            {
                
                pictureBox2.Visible = false;
                pictureBox1.ImageLocation = StaticClass1.listt[index * 10 + 9].ToString();
            }
            else
            {
               

                pictureBox2.Visible = true;
            }
        }
        
        int index = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = StaticClass1.listt.Count.ToString();


           

            try
            {
                label4.Text = (StaticClass1.listt.Count / 10).ToString();


                setdata();
            
                if (StaticClass1.listt.Count / 10 <= 1)
                {

                    button2.Enabled = false;
                    button1.Enabled = false;
                }

                if (StaticClass1.listt.Count / 10 != 0)
                {
                    label2.Text = 1.ToString();

                }

                setphoto();
             
                // Form2.img[0] = pictureBox1.ImageLocation;



            }
            catch (Exception)
            {
                MessageBox.Show("there is no data");
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;

            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == 2.ToString())
            {
                button2.Enabled = false;
            }
            button1.Enabled = true;
            int a = Convert.ToInt32(label2.Text);
            if (a > 1)
            {
                index--;
                if (Form2.img[index].ToString().Length != 0)
                {
                   
                    pictureBox2.Visible = false;
                    pictureBox1.ImageLocation = Form2.img[index].ToString();
                }
                else
                {
                   

                    pictureBox2.Visible = true;
                }
                setdata();
                a--;
                label2.Text = a.ToString();
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;

            if (label4.Text != label2.Text)
            {
                
                index++;
                if (Form2.img[index].ToString().Length != 0)
                {
                   
                    pictureBox2.Visible = false;
                    pictureBox1.ImageLocation = Form2.img[index].ToString();
                }
                else
                {
                  

                    pictureBox2.Visible = true;
                }


                setdata();  
                int a = Convert.ToInt32(label2.Text);
                a++;
                label2.Text = a.ToString();
            }
            if (Convert.ToInt32(label2.Text)== Convert.ToInt32(label4.Text)) button1.Enabled = false; 
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form2.ls.Count != 0) ;
            else button3.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
