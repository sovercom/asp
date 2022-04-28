namespace project01
{
    partial class 머신DBList
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView01 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView01)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 25);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1058, 577);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView01);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 40);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1050, 533);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dataGridView01
            // 
            this.dataGridView01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView01.Location = new System.Drawing.Point(38, 107);
            this.dataGridView01.Name = "dataGridView01";
            this.dataGridView01.RowHeadersWidth = 51;
            this.dataGridView01.RowTemplate.Height = 27;
            this.dataGridView01.Size = new System.Drawing.Size(755, 391);
            this.dataGridView01.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "managerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "관리자명";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "machineName";
            this.dataGridViewTextBoxColumn2.HeaderText = "장치명";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "temperature";
            this.dataGridViewTextBoxColumn3.HeaderText = "온도";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "power";
            this.dataGridViewTextBoxColumn4.HeaderText = "사용전력량";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "runtime";
            this.dataGridViewTextBoxColumn5.HeaderText = "운용시간";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26F);
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "설비 DB List";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.linkLabel1);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 40);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1050, 533);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 30F);
            this.linkLabel1.Location = new System.Drawing.Point(19, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(798, 50);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://127.0.0.1/MachineManage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 30F);
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "웹페이지 주소";
            // 
            // runtime
            // 
            this.runtime.DataPropertyName = "runtime";
            this.runtime.HeaderText = "운용시간";
            this.runtime.MinimumWidth = 6;
            this.runtime.Name = "runtime";
            this.runtime.Width = 125;
            // 
            // power
            // 
            this.power.DataPropertyName = "power";
            this.power.HeaderText = "사용전력량";
            this.power.MinimumWidth = 6;
            this.power.Name = "power";
            this.power.Width = 125;
            // 
            // temperature
            // 
            this.temperature.DataPropertyName = "temperature";
            this.temperature.HeaderText = "온도";
            this.temperature.MinimumWidth = 6;
            this.temperature.Name = "temperature";
            this.temperature.Width = 125;
            // 
            // machineName
            // 
            this.machineName.DataPropertyName = "machineName";
            this.machineName.HeaderText = "장치명";
            this.machineName.MinimumWidth = 6;
            this.machineName.Name = "machineName";
            this.machineName.Width = 125;
            // 
            // managerName
            // 
            this.managerName.DataPropertyName = "managerName";
            this.managerName.HeaderText = "관리자명";
            this.managerName.MinimumWidth = 6;
            this.managerName.Name = "managerName";
            this.managerName.Width = 125;
            // 
            // 머신DBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 602);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "머신DBList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView01)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView01;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}