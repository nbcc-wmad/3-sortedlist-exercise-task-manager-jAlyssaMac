using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedListExTask
{
    public partial class Form1 : Form
    {
        SortedList<DateTime, string> mySortedTasks = new SortedList<DateTime, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime date = dtpTaskDate.Value;
            string item = txtTask.Text;

            if (mySortedTasks.ContainsKey(date))
            {
                MessageBox.Show("You must enter a value", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mySortedTasks.Add(date, item);
            }

            lstTasks.Items.Add(date.ToShortDateString());
            txtTask.Clear();
            dtpTaskDate.Value = DateTime.Now;

            
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if(lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("You must Select a task to remove", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mySortedTasks.Remove(dtpTaskDate.Value);
            }
        }
    }
}
