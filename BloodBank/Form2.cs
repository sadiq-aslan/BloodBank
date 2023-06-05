using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Form2 : Form
    {
     

        public Form2()
        {
            InitializeComponent();
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           label3.Text= DateTime.Now.ToString();
        }
   
        
        public string imageLocation = string.Empty;
        public static ArrayList img = new ArrayList();
        private void button3_Click(object sender, EventArgs e)
        {
        
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    
                    pictureBox1.ImageLocation = imageLocation;   

                }
            }
            catch (Exception)
            {

                MessageBox.Show("An eror occured");
            }
        }


       

        public static List<string>ls=new List<string>();   
        public void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length == 0 || comboBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
                MessageBox.Show("fulfil all gapes");
         
            else
            {
                

                img.Add(imageLocation);

                Person person = new Person();
                person.name = textBox1.Text;
                person.surname = textBox2.Text;
                person.social_id = textBox3.Text;
                person.Phonenumber = textBox4.Text;
                person.email = textBox5.Text;
                person.bloodtype = comboBox1.Text;
                person.date = label3.Text;

                StaticClass1.txt("-------------------");
                StaticClass1.txt(person.id);
                StaticClass1.txt(person.name);
                StaticClass1.txt(person.surname);
                StaticClass1.txt(person.social_id);
                StaticClass1.txt(person.Phonenumber);
                StaticClass1.txt(person.email);
                StaticClass1.txt(person.bloodtype);
                StaticClass1.txt(person.date);
                StaticClass1.txt(imageLocation.ToString());

                StaticClass1.read();

                ls.Add(person.id) ;
                ls.Add(person.name);
                ls.Add(person.surname);
                ls.Add(person.social_id);
                ls.Add(person.Phonenumber);
                ls.Add(person.email);
                ls.Add(person.bloodtype);
                ls.Add(person.date);
                MessageBox.Show($"{person.name} Saved");
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
