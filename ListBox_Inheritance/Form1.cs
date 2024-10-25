using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxObjects.Items.Add(1);
            listBoxObjects.Items.Add("Name");
            listBoxObjects.Items.Add(2.3);
            listBoxObjects.Items.Add(DateTime.Now);
            //listBoxObjects.Items.Add(new Animal("Sth"));
            listBoxObjects.Items.Add(new Dog("Reksio"));
            listBoxObjects.Items.Add(new Cat("Bonifacy"));
        }

        private void listBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxObjects.SelectedIndex != -1)
            {
                Object myObject = listBoxObjects.SelectedItem;

                MessageBox.Show( myObject.GetType().ToString());

                //first way
                Animal animal = myObject as Animal;
                if (animal != null)
                {
                }
                //second way
                if(myObject is Animal)
                {
                    Animal a = myObject as Animal;
                }


            }


        }
    }
}
