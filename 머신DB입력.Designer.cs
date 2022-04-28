namespace project01
{
    partial class 머신DB입력
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.runtime = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.TextBox();
            this.temperature = new System.Windows.Forms.TextBox();
            this.machineName = new System.Windows.Forms.TextBox();
            this.managerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // runtime
            // 
            this.runtime.Location = new System.Drawing.Point(226, 438);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(220, 25);
            this.runtime.TabIndex = 23;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(226, 366);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(220, 25);
            this.power.TabIndex = 22;
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(226, 297);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(220, 25);
            this.temperature.TabIndex = 21;
            // 
            // machineName
            // 
            this.machineName.Location = new System.Drawing.Point(226, 228);
            this.machineName.Name = "machineName";
            this.machineName.Size = new System.Drawing.Size(220, 25);
            this.machineName.TabIndex = 20;
            // 
            // managerName
            // 
            this.managerName.Location = new System.Drawing.Point(226, 164);
            this.managerName.Name = "managerName";
            this.managerName.Size = new System.Drawing.Size(220, 25);
            this.managerName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(63, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "장치명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(63, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "온도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "사용전력량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(63, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "운용시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(63, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "관리자명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "설비 데이터 입력";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(148, 502);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 39);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "입력";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(275, 502);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(95, 39);
            this.metroButton2.TabIndex = 27;
            this.metroButton2.Text = "DB List";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // 머신DB입력
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 564);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.runtime);
            this.Controls.Add(this.power);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.machineName);
            this.Controls.Add(this.managerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "머신DB입력";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox runtime;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.TextBox machineName;
        private System.Windows.Forms.TextBox managerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

