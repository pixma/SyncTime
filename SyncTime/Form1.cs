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
        private DateTime dtStartTime;
        private TimeSpan tsElapsedTime;
        private int nIndexRunningTask;
        private TimeSpan ts_done;

        int statePause = 0;

        public WindowForm()
        {
            InitializeComponent();
            ts_done = TimeSpan.Zero;
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {
            performHouseKeeping();
        }

        private void performHouseKeeping()
        {
            this.Text = Application.ProductName;
            
            metroGridWindow.Columns.Add("Task", "Task");
            metroGridWindow.Columns.Add("AddedOn", "Added On");
            metroGridWindow.Columns.Add("ElapsedTime", "Time Elapsed");

            metroGridWindow.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        
        }

        private void metroButtonAddActivity_Click(object sender, EventArgs e)
        {
            addNewTask(metroTextBoxActivityName.Text);
        }

        private void addNewTask(string p)
        {
            metroGridWindow.Rows.Insert(0, p, DateTime.Now.ToShortDateString(), "NULL");
            metroGridWindow.Rows[0].Selected = true;
            metroGridWindow.CurrentCell = metroGridWindow[0, 0];
            metroTextBoxActivityName.Text = "";

        }

        private void metroGridWindow_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridRowAddedAction(sender, e);
        }

        private void dataGridRowAddedAction(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ribbonButtonStartTracking.Enabled = true;
            MetroFramework.Controls.MetroGrid mtrGrid = (MetroFramework.Controls.MetroGrid)sender;
            if (mtrGrid.Rows.Count > 1)
            {
                ribbonButtonActivityUp.Enabled = true;
                ribbonButtonActivityDown.Enabled = true;                
            }
            else if (mtrGrid.Rows.Count == 1)
            {
                ribbonButtonDeleteActivity.Enabled = true;
            }
            else if (mtrGrid.Rows.Count >= 2)
            {
                ribbonButtonActivityUp.Enabled = ribbonButtonActivityDown.Enabled = true;
            }
            
        }

        private void metroGridWindow_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dataGridRowRemovedAction(sender, e);
        }

        private void dataGridRowRemovedAction(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MetroFramework.Controls.MetroGrid mtrGrid = (MetroFramework.Controls.MetroGrid)sender;
            if (mtrGrid.Rows.Count == 1)
            {
                ribbonButtonActivityUp.Enabled = false;
                ribbonButtonActivityDown.Enabled = false;
                ribbonButtonActivityUp.Enabled = ribbonButtonActivityDown.Enabled = false;
            }
            else if (mtrGrid.Rows.Count == 0)
            {
                ribbonButtonDeleteActivity.Enabled = false;
                ribbonButtonStartTracking.Enabled = false;
            }
        }

        private void ribbonButtonDeleteActivity_Click(object sender, EventArgs e)
        {
            activityDeleteActionRoutine(sender, e);
        }

        private void activityDeleteActionRoutine(object sender, EventArgs e)
        {
            if (metroGridWindow.SelectedRows.Count == 0)
            {
                //nothing to do.
            }
            else
            {
                try
                {
                    metroGridWindow.Rows.RemoveAt(metroGridWindow.SelectedRows[0].Index);
                }
                catch (Exception expc)
                {
                    
                    throw;
                }
            }
        }

        private void ribbonButtonActivityUp_Click(object sender, EventArgs e)
        {
            activityPlusPriorityAction(sender, e);
        }

        private void activityPlusPriorityAction(object sender, EventArgs e)
        {
            if (metroGridWindow.SelectedRows.Count == 0)
            {
                // do nothing
            }
            else
            {
                try
                {
                    //atleadt one row is selected.
                    DataGridViewRow rw = metroGridWindow.SelectedRows[0];
                    int nCurRowIndex = rw.Index;
                    if (rw.Index == 0)
                    {
                        //that row is already on the top.
                        // no need to shift further.
                    }
                    else
                    {
                        metroGridWindow.Rows.RemoveAt(nCurRowIndex);
                        metroGridWindow.Rows.Insert(nCurRowIndex - 1, rw);
                        metroGridWindow.Rows[nCurRowIndex - 1].Selected = true;
                        metroGridWindow.CurrentCell = metroGridWindow[0, nCurRowIndex - 1];
                    }
                }
                catch (Exception excp)
                {
                    
                    throw;
                }
            }
        }

        private void ribbonButtonActivityDown_Click(object sender, EventArgs e)
        {
            activityminusPriorityAction(sender, e);
        }

        private void activityminusPriorityAction(object sender, EventArgs e)
        {
            if (metroGridWindow.SelectedRows.Count == 0)
            {
                // do nothing
            }
            else
            {
                try
                {
                    //atleadt one row is selected.
                    DataGridViewRow rw = metroGridWindow.SelectedRows[0];
                    int nCurRowIndex = rw.Index;
                    if (rw.Index == metroGridWindow.Rows.Count - 1)
                    {
                        //that row is already on the top.
                        // no need to shift further.
                    }
                    else
                    {
                        metroGridWindow.Rows.RemoveAt(nCurRowIndex);
                        metroGridWindow.Rows.Insert(nCurRowIndex + 1, rw);
                        metroGridWindow.Rows[nCurRowIndex + 1].Selected = true;
                        metroGridWindow.CurrentCell = metroGridWindow[0, nCurRowIndex + 1];
                    }
                }
                catch (Exception excp)
                {

                    throw;
                }
            }
        }

        private void ribbonButtonStartTracking_Click(object sender, EventArgs e)
        {
            manageTimeTracking(sender, e);
        }

        private void manageTimeTracking(object sender, EventArgs e)
        {
            //Check if any row is selected or not?
            if (metroGridWindow.SelectedRows.Count == 0)
            {
                // nothing to do.
                return;
            }
            //First do some house keeping steps.
            ribbonButtonStopTracking.Enabled = ribbonButtonPauseResume.Enabled = true;
            ribbonLabelTime.Enabled = true;
            ribbonPanelEdit.Enabled = false;
            splitContainerMainWindow.Enabled = false;
            ribbonButtonStartTracking.Enabled = false;

            //check is this is a previous task or not.
            if (metroGridWindow.SelectedCells[2].Value.ToString() != "NULL") 
            {
                //resume from the last time so left.
                ts_done = TimeSpan.Parse(metroGridWindow.SelectedRows[0].Cells[2].Value.ToString());

            }

            dtStartTime = DateTime.Now;
            nIndexRunningTask = metroGridWindow.SelectedRows[0].Index;

            //finally success then start the timer tick
            timerCounting.Enabled = true;
        }

        private void timerCounting_Tick(object sender, EventArgs e)
        {
            tickTimeElapsedOnActivityActionRoutine(sender, e);
        }

        private void tickTimeElapsedOnActivityActionRoutine(object sender, EventArgs e)
        {
            try
            {                
                tsElapsedTime = DateTime.Now - dtStartTime;
                tsElapsedTime += ts_done;
                ribbonLabelTime.Text = tsElapsedTime.ToString(@"hh\:mm\:ss");
                metroGridWindow.Rows[nIndexRunningTask].Cells[metroGridWindow.Rows[nIndexRunningTask].Cells.Count - 1].Value = ribbonLabelTime.Text;

            }
            catch (Exception excp)
            {
                
                throw;
            }
        }

        private void ribbonButtonStopTracking_Click(object sender, EventArgs e)
        {
            stopTrackingTimeActionAbort(sender, e);
        }

        private void stopTrackingTimeActionAbort(object sender, EventArgs e)
        {
            ribbonButtonStopTracking.Enabled = false;
            ribbonButtonPauseResume.Enabled = false;            
            splitContainerMainWindow.Enabled = true;
            ribbonButtonStartTracking.Enabled = true;
            ribbonLabelTime.Text = "Timer Stopped";
            timerCounting.Enabled = false;
            
        }

        private void splitContainerMainWindow_EnabledChanged(object sender, EventArgs e)
        {
            if (splitContainerMainWindow.Enabled == true)
            {
                if (metroGridWindow.Rows.Count == 1)
                {
                    ribbonButtonDeleteActivity.Enabled = true;
                }
                else if (metroGridWindow.Rows.Count > 1)
                {
                    ribbonButtonDeleteActivity.Enabled = true;
                    ribbonButtonActivityUp.Enabled = ribbonButtonActivityDown.Enabled = true;
                }
            }
        }

        private void ribbonButtonPauseResume_Click(object sender, EventArgs e)
        {
            if (statePause == 1) // already paused, now resume.
            {
                statePause = 0;
                ribbonButtonPauseResume.Text = "Pause Tracking";
                dtStartTime = DateTime.Now;
                timerCounting.Enabled = true;
                return;
            }
            ts_done = tsElapsedTime;
            timerCounting.Enabled = false;
            statePause = 1;
            ribbonButtonPauseResume.Text = "Resume Tracking";
            

        }
    }
}
