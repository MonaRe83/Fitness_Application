using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_RunningWild
{
    public partial class Form1 : Form
    {
        public string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           try
           {
               var sr = new System.IO.StreamReader("login.ID");
               username = sr.ReadLine();
               password = sr.ReadLine();
               sr.Close();

               if (txtUsername.Text == username && textbox2.Text == password)
               {
                   MessageBox.Show("You are successfully logged in!", "success ");
                   new Form2().Show();
               }
               else
               {
                   MessageBox.Show("Failed, son");
               }
           }
           catch
           {

           }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                var sw = new System.IO.StreamWriter("login.ID");
                sw.WriteLine(txtUsername.Text);
                sw.WriteLine(textbox2.Text);
                sw.Close();
              
            }
          catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
