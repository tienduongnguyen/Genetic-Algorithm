using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            for (int i = 1; i <= Convert.ToInt32(domNumObj.Text); i++)
            {
                ListViewItem lst1 = new ListViewItem(i.ToString());

                string val = r.Next(0, Convert.ToInt32(domMaxValue.Text)).ToString();
                string wei = r.Next(0, Convert.ToInt32(domMaxWeight.Text)).ToString();

                ListViewItem.ListViewSubItem value = new ListViewItem.ListViewSubItem(lst1, val);
                lst1.SubItems.Add(value);

                ListViewItem.ListViewSubItem weight = new ListViewItem.ListViewSubItem(lst1, wei);
                lst1.SubItems.Add(weight);

                listView1.Items.Add(lst1);
            }
        }

        public int getValueObject(int i)
        {
            string[] arr = new string[Convert.ToInt32(domNumObj.Text)];
            int index = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                arr[index++] = item.SubItems[1].Text.ToString();
            }

            return Convert.ToInt32(arr[i]);
        }

        public int getWeightObject(int i)
        {
            string[] arr = new string[Convert.ToInt32(domNumObj.Text)];
            int index = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                arr[index++] = item.SubItems[2].Text.ToString();
            }

            return Convert.ToInt32(arr[i]);
        }

        public string createPerson()
        {
            string pop = "";
            for (int i = 0; i < Convert.ToInt32(domNumObj.Text); i++)
            {
                pop = pop + r.Next(0,2).ToString();
            }

            return pop;
        }

        public int calcValue(string value)
        {
            int val = 0;
            for (int i = 0; i < Convert.ToInt32(domNumObj.Text); i++)
            {
                if (value[i].ToString() == "1")
                {
                    val = val + getValueObject(i);
                }
            }            

            return val;
        }

        public int calcWeight(string weight)
        {
            int wei = 0;
            for (int i = 0; i < Convert.ToInt32(domNumObj.Text); i++)
            {
                if (weight[i].ToString() == "1")
                {
                    wei = wei + getWeightObject(i);
                }
            }

            return wei;
        }

        private void btnCreatePop_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            for (int i = 1; i <= Convert.ToInt32(domPopSize.Text); i++)
            {
                ListViewItem lst2 = new ListViewItem(i.ToString());

                string person = createPerson();
                ListViewItem.ListViewSubItem pop = new ListViewItem.ListViewSubItem(lst2, person);
                lst2.SubItems.Add(pop);

                string val = calcValue(person).ToString();
                ListViewItem.ListViewSubItem value = new ListViewItem.ListViewSubItem(lst2, val);
                lst2.SubItems.Add(value);

                string wei = calcWeight(person).ToString();
                ListViewItem.ListViewSubItem weight = new ListViewItem.ListViewSubItem(lst2, wei);
                lst2.SubItems.Add(weight);

                listView2.Items.Add(lst2);
            }

            
        }
    }
}
