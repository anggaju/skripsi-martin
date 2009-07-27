namespace SMS_Gateway.FormBroadcastSchedule
{
    partial class FrmBroadcastSchedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtLastExecute = new System.Windows.Forms.DateTimePicker();
            this.dtNextExecute = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Status = new System.Windows.Forms.ComboBox();
            this.Txt_Interval = new System.Windows.Forms.TextBox();
            this.Txt_CurrLoop = new System.Windows.Forms.TextBox();
            this.Txt_MaxLoop = new System.Windows.Forms.TextBox();
            this.Cmb_Name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtLastExecute);
            this.groupBox1.Controls.Add(this.dtNextExecute);
            this.groupBox1.Controls.Add(this.Cmb_Status);
            this.groupBox1.Controls.Add(this.Txt_Interval);
            this.groupBox1.Controls.Add(this.Txt_CurrLoop);
            this.groupBox1.Controls.Add(this.Txt_MaxLoop);
            this.groupBox1.Controls.Add(this.Cmb_Name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtLastExecute
            // 
            this.dtLastExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtLastExecute.CustomFormat = "dd-MM-yyyy";
            this.dtLastExecute.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastExecute.Location = new System.Drawing.Point(111, 157);
            this.dtLastExecute.Name = "dtLastExecute";
            this.dtLastExecute.Size = new System.Drawing.Size(126, 20);
            this.dtLastExecute.TabIndex = 12;
            // 
            // dtNextExecute
            // 
            this.dtNextExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtNextExecute.CustomFormat = "dd-MM-yyyy";
            this.dtNextExecute.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNextExecute.Location = new System.Drawing.Point(111, 130);
            this.dtNextExecute.Name = "dtNextExecute";
            this.dtNextExecute.Size = new System.Drawing.Size(126, 20);
            this.dtNextExecute.TabIndex = 11;
            // 
            // Cmb_Status
            // 
            this.Cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Status.FormattingEnabled = true;
            this.Cmb_Status.Items.AddRange(new object[] {
            "ACTIVE",
            "DEACTIVE"});
            this.Cmb_Status.Location = new System.Drawing.Point(111, 187);
            this.Cmb_Status.Name = "Cmb_Status";
            this.Cmb_Status.Size = new System.Drawing.Size(126, 21);
            this.Cmb_Status.TabIndex = 13;
            // 
            // Txt_Interval
            // 
            this.Txt_Interval.Location = new System.Drawing.Point(111, 104);
            this.Txt_Interval.MaxLength = 3;
            this.Txt_Interval.Name = "Txt_Interval";
            this.Txt_Interval.Size = new System.Drawing.Size(45, 20);
            this.Txt_Interval.TabIndex = 10;
            // 
            // Txt_CurrLoop
            // 
            this.Txt_CurrLoop.Location = new System.Drawing.Point(111, 78);
            this.Txt_CurrLoop.MaxLength = 3;
            this.Txt_CurrLoop.Name = "Txt_CurrLoop";
            this.Txt_CurrLoop.Size = new System.Drawing.Size(45, 20);
            this.Txt_CurrLoop.TabIndex = 9;
            // 
            // Txt_MaxLoop
            // 
            this.Txt_MaxLoop.Location = new System.Drawing.Point(111, 51);
            this.Txt_MaxLoop.MaxLength = 3;
            this.Txt_MaxLoop.Name = "Txt_MaxLoop";
            this.Txt_MaxLoop.Size = new System.Drawing.Size(45, 20);
            this.Txt_MaxLoop.TabIndex = 8;
            // 
            // Cmb_Name
            // 
            this.Cmb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Name.FormattingEnabled = true;
            this.Cmb_Name.Location = new System.Drawing.Point(111, 24);
            this.Cmb_Name.MaxLength = 15;
            this.Cmb_Name.Name = "Cmb_Name";
            this.Cmb_Name.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Name.TabIndex = 7;
            this.Cmb_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Name_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Execute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Next Execute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intervals (Days)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curr Loop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Loop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(245, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Add / Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(161, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmBroadcastSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBroadcastSchedule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form Broadcast Schedule";
            this.Load += new System.EventHandler(this.FrmBroadcastSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Name;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_Interval;
        private System.Windows.Forms.TextBox Txt_CurrLoop;
        private System.Windows.Forms.TextBox Txt_MaxLoop;
        private System.Windows.Forms.ComboBox Cmb_Status;
        private System.Windows.Forms.DateTimePicker dtLastExecute;
        private System.Windows.Forms.DateTimePicker dtNextExecute;

    }
}