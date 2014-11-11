using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace SyncTime
{
    public partial class WindowForm : MetroForm
    {
        public WindowForm()
        {
            InitializeComponent();
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {
            performHouseKeeping();
        }

        private void performHouseKeeping()
        {
            this.Text = Application.ProductName;
            
            metroGridWindow.Columns.Add("Task", "Task");
            metroGridWindow.Columns.Add("Time", "Time");

            metroGridWindow.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            metroTextBoxActivityName.Focus();
                        
        }

        private void metroButtonAddActivity_Click(object sender, EventArgs e)
        {
            addNewTask(metroTextBoxActivityName.Text);
        }

        private void addNewTask(string p)
        {
            metroGridWindow.Rows.Add(p, "Time");
        }
    }
}
