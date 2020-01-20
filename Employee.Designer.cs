namespace EmployeeForm
{
    partial class Employee
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
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.rb_data = new System.Windows.Forms.RichTextBox();
            this.rb_log = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbx_work_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(48, 58);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(169, 20);
            this.txbx_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(48, 119);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(169, 20);
            this.txbx_surname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soy Ad";
            // 
            // txbx_id
            // 
            this.txbx_id.Location = new System.Drawing.Point(48, 179);
            this.txbx_id.Name = "txbx_id";
            this.txbx_id.Size = new System.Drawing.Size(169, 20);
            this.txbx_id.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şəxsiyyət Vəsiqəsi";
            // 
            // txbx_date
            // 
            this.txbx_date.Location = new System.Drawing.Point(48, 247);
            this.txbx_date.Name = "txbx_date";
            this.txbx_date.Size = new System.Drawing.Size(169, 20);
            this.txbx_date.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarixi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şirkət";
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(48, 398);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(169, 23);
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "Welcome";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // cb_company
            // 
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Items.AddRange(new object[] {
            "pasha",
            "kapital",
            "milli"});
            this.cb_company.Location = new System.Drawing.Point(48, 355);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(169, 21);
            this.cb_company.TabIndex = 3;
            // 
            // rb_data
            // 
            this.rb_data.Location = new System.Drawing.Point(259, 58);
            this.rb_data.Name = "rb_data";
            this.rb_data.Size = new System.Drawing.Size(240, 363);
            this.rb_data.TabIndex = 4;
            this.rb_data.Text = "";
            // 
            // rb_log
            // 
            this.rb_log.Location = new System.Drawing.Point(532, 58);
            this.rb_log.Name = "rb_log";
            this.rb_log.Size = new System.Drawing.Size(240, 363);
            this.rb_log.TabIndex = 4;
            this.rb_log.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show Log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbx_work_id
            // 
            this.txbx_work_id.Location = new System.Drawing.Point(48, 307);
            this.txbx_work_id.Name = "txbx_work_id";
            this.txbx_work_id.Size = new System.Drawing.Size(169, 20);
            this.txbx_work_id.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Əmək Kitabçası";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rb_log);
            this.Controls.Add(this.rb_data);
            this.Controls.Add(this.cb_company);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_work_id);
            this.Controls.Add(this.txbx_date);
            this.Controls.Add(this.txbx_id);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.txbx_name);
            this.Name = "Employee";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.RichTextBox rb_data;
        private System.Windows.Forms.RichTextBox rb_log;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbx_work_id;
        private System.Windows.Forms.Label label6;
    }
}

