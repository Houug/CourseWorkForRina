
namespace CourseWork
{
    partial class AddNewPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPersonForm));
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.haveMinorChildreCheckBox = new System.Windows.Forms.CheckBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dapartmentLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(12, 22);
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 61);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(12, 99);
            this.departmentTextBox.MaxLength = 30;
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(200, 20);
            this.departmentTextBox.TabIndex = 3;
            this.departmentTextBox.Tag = "";
            this.departmentTextBox.TextChanged += new System.EventHandler(this.departmentTextBox_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 138);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // haveMinorChildreCheckBox
            // 
            this.haveMinorChildreCheckBox.AutoSize = true;
            this.haveMinorChildreCheckBox.Location = new System.Drawing.Point(12, 203);
            this.haveMinorChildreCheckBox.Name = "haveMinorChildreCheckBox";
            this.haveMinorChildreCheckBox.Size = new System.Drawing.Size(188, 17);
            this.haveMinorChildreCheckBox.TabIndex = 7;
            this.haveMinorChildreCheckBox.Text = "Есть несовершеннолетние дети";
            this.haveMinorChildreCheckBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 226);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(200, 23);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(12, 177);
            this.salaryTextBox.MaxLength = 10;
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaryTextBox.TabIndex = 10;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTextBox_KeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(9, 6);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Имя";
            // 
            // dapartmentLabel
            // 
            this.dapartmentLabel.AutoSize = true;
            this.dapartmentLabel.Location = new System.Drawing.Point(9, 84);
            this.dapartmentLabel.Name = "dapartmentLabel";
            this.dapartmentLabel.Size = new System.Drawing.Size(38, 13);
            this.dapartmentLabel.TabIndex = 13;
            this.dapartmentLabel.Text = "Отдел";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(9, 122);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(87, 13);
            this.dateTimeLabel.TabIndex = 14;
            this.dateTimeLabel.Text = "Начало отпуска";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(9, 161);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(55, 13);
            this.salaryLabel.TabIndex = 16;
            this.salaryLabel.Text = "Зарплата";
            // 
            // AddNewPersonForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 260);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.dapartmentLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.haveMinorChildreCheckBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить нового работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox haveMinorChildreCheckBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dapartmentLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button acceptButton;
    }
}