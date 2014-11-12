namespace SyncTime
{
    partial class WindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.WindowRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonTabActivity = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelTimeTrack = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonStartTracking = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStopTracking = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelTime = new System.Windows.Forms.RibbonPanel();
            this.ribbonLabelTime = new System.Windows.Forms.RibbonLabel();
            this.toolTipComp = new System.Windows.Forms.ToolTip(this.components);
            this.metroTextBoxActivityName = new MetroFramework.Controls.MetroTextBox();
            this.splitContainerMainWindow = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButtonAddActivity = new MetroFramework.Controls.MetroButton();
            this.metroLabelPrompter = new MetroFramework.Controls.MetroLabel();
            this.metroGridWindow = new MetroFramework.Controls.MetroGrid();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonPanelStatus = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanelEdit = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonActivityUp = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonActivityDown = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteActivity = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPauseResume = new System.Windows.Forms.RibbonButton();
            this.timerCounting = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainWindow)).BeginInit();
            this.splitContainerMainWindow.Panel1.SuspendLayout();
            this.splitContainerMainWindow.Panel2.SuspendLayout();
            this.splitContainerMainWindow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowRibbon
            // 
            this.WindowRibbon.CaptionBarVisible = false;
            this.WindowRibbon.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.WindowRibbon.Location = new System.Drawing.Point(20, 60);
            this.WindowRibbon.Minimized = false;
            this.WindowRibbon.Name = "WindowRibbon";
            // 
            // 
            // 
            this.WindowRibbon.OrbDropDown.BorderRoundness = 8;
            this.WindowRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.WindowRibbon.OrbDropDown.Name = "";
            this.WindowRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.WindowRibbon.OrbDropDown.TabIndex = 0;
            this.WindowRibbon.OrbImage = null;
            this.WindowRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.WindowRibbon.OrbText = "App";
            // 
            // 
            // 
            this.WindowRibbon.QuickAcessToolbar.Visible = false;
            this.WindowRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.WindowRibbon.Size = new System.Drawing.Size(660, 168);
            this.WindowRibbon.TabIndex = 0;
            this.WindowRibbon.Tabs.Add(this.ribbonTabActivity);
            this.WindowRibbon.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.WindowRibbon.Text = "AppRibbon";
            // 
            // ribbonTabActivity
            // 
            this.ribbonTabActivity.Panels.Add(this.ribbonPanelTimeTrack);
            this.ribbonTabActivity.Panels.Add(this.ribbonPanelTime);
            this.ribbonTabActivity.Panels.Add(this.ribbonPanelEdit);
            this.ribbonTabActivity.Text = "Activity";
            // 
            // ribbonPanelTimeTrack
            // 
            this.ribbonPanelTimeTrack.Items.Add(this.ribbonButtonStartTracking);
            this.ribbonPanelTimeTrack.Items.Add(this.ribbonButtonStopTracking);
            this.ribbonPanelTimeTrack.Items.Add(this.ribbonButtonPauseResume);
            this.ribbonPanelTimeTrack.Text = "Tracking";
            // 
            // ribbonButtonStartTracking
            // 
            this.ribbonButtonStartTracking.Enabled = false;
            this.ribbonButtonStartTracking.Image = global::SyncTime.Properties.Resources._1__188_;
            this.ribbonButtonStartTracking.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonStartTracking.SmallImage = global::SyncTime.Properties.Resources._1__188_;
            this.ribbonButtonStartTracking.Text = "Start Tracking";
            this.ribbonButtonStartTracking.Click += new System.EventHandler(this.ribbonButtonStartTracking_Click);
            // 
            // ribbonButtonStopTracking
            // 
            this.ribbonButtonStopTracking.Enabled = false;
            this.ribbonButtonStopTracking.Image = global::SyncTime.Properties.Resources._1__149_;
            this.ribbonButtonStopTracking.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonStopTracking.SmallImage = global::SyncTime.Properties.Resources._1__149_;
            this.ribbonButtonStopTracking.Text = "Stop Tracking";
            // 
            // ribbonPanelTime
            // 
            this.ribbonPanelTime.Enabled = false;
            this.ribbonPanelTime.Items.Add(this.ribbonLabelTime);
            this.ribbonPanelTime.Text = "Time";
            // 
            // ribbonLabelTime
            // 
            this.ribbonLabelTime.Enabled = false;
            this.ribbonLabelTime.Text = "Time/Date : 00:00:00";
            // 
            // metroTextBoxActivityName
            // 
            this.metroTextBoxActivityName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxActivityName.Lines = new string[0];
            this.metroTextBoxActivityName.Location = new System.Drawing.Point(3, 3);
            this.metroTextBoxActivityName.MaxLength = 32767;
            this.metroTextBoxActivityName.Multiline = true;
            this.metroTextBoxActivityName.Name = "metroTextBoxActivityName";
            this.metroTextBoxActivityName.PasswordChar = '\0';
            this.metroTextBoxActivityName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxActivityName.SelectedText = "";
            this.metroTextBoxActivityName.Size = new System.Drawing.Size(148, 44);
            this.metroTextBoxActivityName.TabIndex = 0;
            this.metroTextBoxActivityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipComp.SetToolTip(this.metroTextBoxActivityName, "Your Activity Name");
            this.metroTextBoxActivityName.UseSelectable = true;
            // 
            // splitContainerMainWindow
            // 
            this.splitContainerMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainWindow.Location = new System.Drawing.Point(20, 228);
            this.splitContainerMainWindow.Name = "splitContainerMainWindow";
            // 
            // splitContainerMainWindow.Panel1
            // 
            this.splitContainerMainWindow.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerMainWindow.Panel2
            // 
            this.splitContainerMainWindow.Panel2.Controls.Add(this.metroGridWindow);
            this.splitContainerMainWindow.Size = new System.Drawing.Size(660, 212);
            this.splitContainerMainWindow.SplitterDistance = 154;
            this.splitContainerMainWindow.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroTextBoxActivityName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroButtonAddActivity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabelPrompter, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(154, 212);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroButtonAddActivity
            // 
            this.metroButtonAddActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonAddActivity.Location = new System.Drawing.Point(3, 53);
            this.metroButtonAddActivity.Name = "metroButtonAddActivity";
            this.metroButtonAddActivity.Size = new System.Drawing.Size(148, 29);
            this.metroButtonAddActivity.TabIndex = 1;
            this.metroButtonAddActivity.Text = "Add Activity";
            this.metroButtonAddActivity.UseSelectable = true;
            this.metroButtonAddActivity.Click += new System.EventHandler(this.metroButtonAddActivity_Click);
            // 
            // metroLabelPrompter
            // 
            this.metroLabelPrompter.AutoSize = true;
            this.metroLabelPrompter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabelPrompter.Location = new System.Drawing.Point(3, 185);
            this.metroLabelPrompter.Name = "metroLabelPrompter";
            this.metroLabelPrompter.Size = new System.Drawing.Size(148, 27);
            this.metroLabelPrompter.TabIndex = 2;
            this.metroLabelPrompter.Text = "Message";
            this.metroLabelPrompter.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroGridWindow
            // 
            this.metroGridWindow.AllowUserToAddRows = false;
            this.metroGridWindow.AllowUserToDeleteRows = false;
            this.metroGridWindow.AllowUserToResizeRows = false;
            this.metroGridWindow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridWindow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridWindow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridWindow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridWindow.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridWindow.EnableHeadersVisualStyles = false;
            this.metroGridWindow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridWindow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridWindow.Location = new System.Drawing.Point(0, 0);
            this.metroGridWindow.MultiSelect = false;
            this.metroGridWindow.Name = "metroGridWindow";
            this.metroGridWindow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridWindow.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridWindow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridWindow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridWindow.Size = new System.Drawing.Size(502, 212);
            this.metroGridWindow.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridWindow.TabIndex = 2;
            this.metroGridWindow.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.metroGridWindow_RowsAdded);
            this.metroGridWindow.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.metroGridWindow_RowsRemoved);
            // 
            // ribbonPanelStatus
            // 
            this.ribbonPanelStatus.Text = null;
            // 
            // ribbonPanelEdit
            // 
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonActivityUp);
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonActivityDown);
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonDeleteActivity);
            this.ribbonPanelEdit.Text = "Edit";
            // 
            // ribbonButtonActivityUp
            // 
            this.ribbonButtonActivityUp.Enabled = false;
            this.ribbonButtonActivityUp.Image = global::SyncTime.Properties.Resources._1__73_;
            this.ribbonButtonActivityUp.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonActivityUp.SmallImage = global::SyncTime.Properties.Resources._1__73_;
            this.ribbonButtonActivityUp.Text = "Up";
            this.ribbonButtonActivityUp.Click += new System.EventHandler(this.ribbonButtonActivityUp_Click);
            // 
            // ribbonButtonActivityDown
            // 
            this.ribbonButtonActivityDown.Enabled = false;
            this.ribbonButtonActivityDown.Image = global::SyncTime.Properties.Resources._1__88_;
            this.ribbonButtonActivityDown.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonActivityDown.SmallImage = global::SyncTime.Properties.Resources._1__88_;
            this.ribbonButtonActivityDown.Text = "Down";
            this.ribbonButtonActivityDown.Click += new System.EventHandler(this.ribbonButtonActivityDown_Click);
            // 
            // ribbonButtonDeleteActivity
            // 
            this.ribbonButtonDeleteActivity.Enabled = false;
            this.ribbonButtonDeleteActivity.Image = global::SyncTime.Properties.Resources._1__145_;
            this.ribbonButtonDeleteActivity.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonDeleteActivity.SmallImage = global::SyncTime.Properties.Resources._1__145_;
            this.ribbonButtonDeleteActivity.Text = "Delete";
            this.ribbonButtonDeleteActivity.Click += new System.EventHandler(this.ribbonButtonDeleteActivity_Click);
            // 
            // ribbonButtonPauseResume
            // 
            this.ribbonButtonPauseResume.Enabled = false;
            this.ribbonButtonPauseResume.Image = global::SyncTime.Properties.Resources._1__74_;
            this.ribbonButtonPauseResume.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonPauseResume.SmallImage = global::SyncTime.Properties.Resources._1__74_;
            this.ribbonButtonPauseResume.Text = "Pause Tracking";
            // 
            // timerCounting
            // 
            this.timerCounting.Interval = 1000;
            this.timerCounting.Tick += new System.EventHandler(this.timerCounting_Tick);
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.splitContainerMainWindow);
            this.Controls.Add(this.WindowRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "AppName";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.splitContainerMainWindow.Panel1.ResumeLayout(false);
            this.splitContainerMainWindow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainWindow)).EndInit();
            this.splitContainerMainWindow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon WindowRibbon;
        private System.Windows.Forms.RibbonTab ribbonTabActivity;
        private System.Windows.Forms.RibbonPanel ribbonPanelTimeTrack;
        private System.Windows.Forms.RibbonButton ribbonButtonStartTracking;
        private System.Windows.Forms.RibbonButton ribbonButtonStopTracking;
        private System.Windows.Forms.ToolTip toolTipComp;
        private System.Windows.Forms.SplitContainer splitContainerMainWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxActivityName;
        private MetroFramework.Controls.MetroButton metroButtonAddActivity;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonPanel ribbonPanelStatus;
        private System.Windows.Forms.RibbonPanel ribbonPanelTime;
        private System.Windows.Forms.RibbonLabel ribbonLabelTime;
        private MetroFramework.Controls.MetroLabel metroLabelPrompter;
        private MetroFramework.Controls.MetroGrid metroGridWindow;
        private System.Windows.Forms.RibbonPanel ribbonPanelEdit;
        private System.Windows.Forms.RibbonButton ribbonButtonActivityUp;
        private System.Windows.Forms.RibbonButton ribbonButtonActivityDown;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteActivity;
        private System.Windows.Forms.RibbonButton ribbonButtonPauseResume;
        private System.Windows.Forms.Timer timerCounting;
    }
}

