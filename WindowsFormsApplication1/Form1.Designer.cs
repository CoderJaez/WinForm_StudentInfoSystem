namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbMidlename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstname.Location = new System.Drawing.Point(133, 77);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(215, 25);
            this.tbFirstname.TabIndex = 1;
            // 
            // tbMidlename
            // 
            this.tbMidlename.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMidlename.Location = new System.Drawing.Point(133, 108);
            this.tbMidlename.Name = "tbMidlename";
            this.tbMidlename.Size = new System.Drawing.Size(215, 25);
            this.tbMidlename.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle name:";
            // 
            // tbLastname
            // 
            this.tbLastname.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastname.Location = new System.Drawing.Point(133, 141);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(215, 25);
            this.tbLastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(133, 172);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(215, 25);
            this.cbGender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(133, 203);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(215, 23);
            this.dtpBirthday.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(218, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgStudent
            // 
            this.dgStudent.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgStudent.ColumnHeadersHeight = 30;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Lastname,
            this.Firstname,
            this.MIddlename,
            this.Gender,
            this.Birthday,
            this.edit,
            this.delete});
            this.dgStudent.EnableHeadersVisualStyles = false;
            this.dgStudent.Location = new System.Drawing.Point(370, 44);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.RowHeadersVisible = false;
            this.dgStudent.Size = new System.Drawing.Size(820, 330);
            this.dgStudent.TabIndex = 11;
            this.dgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // MIddlename
            // 
            this.MIddlename.HeaderText = "Middlename";
            this.MIddlename.Name = "MIddlename";
            this.MIddlename.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 5;
            // 
            // tbStudentId
            // 
            this.tbStudentId.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentId.Location = new System.Drawing.Point(133, 44);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(215, 25);
            this.tbStudentId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Student Id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save to Textfile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(924, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbStudentId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMidlename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbMidlename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

