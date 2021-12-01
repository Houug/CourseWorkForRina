
namespace CourseWork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableField = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.thisMonthCheckBox = new System.Windows.Forms.CheckBox();
            this.haveMinorChildrenCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableField)).BeginInit();
            this.SuspendLayout();
            // 
            // tableField
            // 
            this.tableField.AllowUserToAddRows = false;
            this.tableField.AllowUserToDeleteRows = false;
            this.tableField.AllowUserToResizeColumns = false;
            this.tableField.AllowUserToResizeRows = false;
            this.tableField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableField.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableField.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.tableField, "tableField");
            this.tableField.MultiSelect = false;
            this.tableField.Name = "tableField";
            this.tableField.ReadOnly = true;
            this.tableField.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reloadButton
            // 
            resources.ApplyResources(this.reloadButton, "reloadButton");
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // departmentTextBox
            // 
            resources.ApplyResources(this.departmentTextBox, "departmentTextBox");
            this.departmentTextBox.Name = "departmentTextBox";
            // 
            // thisMonthCheckBox
            // 
            resources.ApplyResources(this.thisMonthCheckBox, "thisMonthCheckBox");
            this.thisMonthCheckBox.Name = "thisMonthCheckBox";
            this.thisMonthCheckBox.UseVisualStyleBackColor = true;
            // 
            // haveMinorChildrenCheckBox
            // 
            resources.ApplyResources(this.haveMinorChildrenCheckBox, "haveMinorChildrenCheckBox");
            this.haveMinorChildrenCheckBox.Name = "haveMinorChildrenCheckBox";
            this.haveMinorChildrenCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            resources.ApplyResources(this.departmentLabel, "departmentLabel");
            this.departmentLabel.Name = "departmentLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.haveMinorChildrenCheckBox);
            this.Controls.Add(this.thisMonthCheckBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tableField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.CheckBox thisMonthCheckBox;
        private System.Windows.Forms.CheckBox haveMinorChildrenCheckBox;
        private System.Windows.Forms.Label departmentLabel;
    }
}

