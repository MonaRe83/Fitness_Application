using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.IO5;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_RunningWild
{
    public partial class Form2 : Form
   
    {
        List<object> athlete = new List<object>();
        int updateID = 0;

        public Form2()
        {
            InitializeComponent();
        }
        int Array_Length = 0;
        public void DisplayObject()
        {
            listBox1.Items.Clear();
            foreach (object c in athlete)
            {
              
             Classinfo calculate = c as Classinfo;
             if (calculate != null)
                {
                   listBox1.Items.Add("WarmUps:"+calculate.wup+
                       "Location:"+calculate.locat+"Activity:"+calculate.actv+
                       "Distance:"+calculate.dis+"Time & Date :"+calculate.dt);
                    Array_Length++;
                }
            }
        }
        int choice = 1;
        private void button1_Click(object sender, EventArgs e)
      
        {
            if (choice == 1)
            {
                this.BackgroundImage = Athlete_RunningWild.Properties.Resources.running_wild;
                choice++;

            }else if(choice==2)

            {
                this.BackgroundImage = Athlete_RunningWild.Properties.Resources.images;
                choice=1;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
             
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var sw = new System.IO.StreamWriter("name.ID");
                sw.WriteLine(txtbox_fstname.Text);
                sw.WriteLine(numericUpDown1.Text);
                sw.WriteLine(numericUpDown2.Text);
                sw.Close();

            }
            catch (Exception ex)
            {

            }
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            string firstname;
            int weight, height;
            try
            {
                var UserInfo = new System.IO.StreamReader("name.ID");
                firstname = UserInfo.ReadLine();

                weight = int.Parse(UserInfo.ReadLine());
                
                height = int.Parse(UserInfo.ReadLine());

              
                UserInfo.Close();

                    txtbox_fstname.Text = firstname;
                    numericUpDown1.Value = weight;
                    numericUpDown2.Value = height;

                    
            }
            catch
            {
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int updrow = this.listBox1.SelectedIndex;
            Classinfo Calculate = new Classinfo(this.updateID, this.comboBox2.SelectedItem.ToString(),
                this.textBox2.Text, this.comboBox1.SelectedItem.ToString(),
                this.numericUpDown3.Value, this.dateTimePicker1.Value.ToLongDateString() + " " +
                this.dateTimePicker1.Value.ToLongTimeString());
            this.listBox1.Items[updrow]=string.Concat(new object[]
            {
                 "UpdateId:",
                  Calculate._up,
                 "WarmUps:",
                  Calculate.wup,
                 "Location:",
                 Calculate.locat,
                 "Activity:",
                 Calculate.actv,
                 "Distance:",
                 Calculate.dis,
                 "Time & Date :",
                 Calculate.dt});


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classinfo Calculate = new Classinfo(this.updateID,this.comboBox2.SelectedItem.ToString(), 
            this.textBox2.Text, this.comboBox1.SelectedItem.ToString(), 
            this.numericUpDown3.Value, this.dateTimePicker1.Value.ToLongDateString() + " " +
            this.dateTimePicker1.Value.ToLongTimeString());
            this.athlete.Add(Calculate);
            this.updateID++;
            this.DisplayObject();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            if (this.comboBox4.SelectedIndex >= 1) {
                foreach (object search in this.athlete)
                {
                    Classinfo Calculate = search as Classinfo;

                    if (Calculate.actv == this.comboBox4.Items[this.comboBox4.SelectedIndex].ToString())
                    {
                        if (Calculate != null)
                        {
                            this.listBox1.Items.Add(string.Concat(new object[]
                        
                        {
                 "Activity:",
                 Calculate.actv,
                        }));

                        }
                    }
                }
            }
            else
            {
                foreach (object search in this.athlete)
                {
                    Classinfo Calculate = search as Classinfo;

                    this.listBox1.Items.Add(string.Concat(new object[]
            {
                 "UpdateId:",
                  Calculate._up,
                 "WarmUps:",
                  Calculate.wup,
                 "Location:",
                 Calculate.locat,
                 "Activity:",
                 Calculate.actv,
                 "Distance:",
                 Calculate.dis,
                 "Time & Date :",
                 Calculate.dt}));

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.facebook.com/");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}