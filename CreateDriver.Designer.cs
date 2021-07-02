
namespace TransferDirectories
{
    partial class CreateDriver
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
            this.FirstNameDisplayname = new System.Windows.Forms.Label();
            this.SecondaryNameDisplayname = new System.Windows.Forms.Label();
            this.BirthDateDisplayname = new System.Windows.Forms.Label();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.SecondaryNameField = new System.Windows.Forms.TextBox();
            this.BirthDateField = new System.Windows.Forms.TextBox();
            this.AddDriver = new System.Windows.Forms.Button();
            this.inputMask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameDisplayname
            // 
            this.FirstNameDisplayname.AutoSize = true;
            this.FirstNameDisplayname.Location = new System.Drawing.Point(22, 20);
            this.FirstNameDisplayname.Name = "FirstNameDisplayname";
            this.FirstNameDisplayname.Size = new System.Drawing.Size(81, 13);
            this.FirstNameDisplayname.TabIndex = 0;
            this.FirstNameDisplayname.Text = "Имя водителя";
            // 
            // SecondaryNameDisplayname
            // 
            this.SecondaryNameDisplayname.AutoSize = true;
            this.SecondaryNameDisplayname.Location = new System.Drawing.Point(23, 59);
            this.SecondaryNameDisplayname.Name = "SecondaryNameDisplayname";
            this.SecondaryNameDisplayname.Size = new System.Drawing.Size(108, 13);
            this.SecondaryNameDisplayname.TabIndex = 1;
            this.SecondaryNameDisplayname.Text = "Фамилия водителя";
            // 
            // BirthDateDisplayname
            // 
            this.BirthDateDisplayname.AutoSize = true;
            this.BirthDateDisplayname.Location = new System.Drawing.Point(23, 108);
            this.BirthDateDisplayname.Name = "BirthDateDisplayname";
            this.BirthDateDisplayname.Size = new System.Drawing.Size(142, 13);
            this.BirthDateDisplayname.TabIndex = 2;
            this.BirthDateDisplayname.Text = "Дата рождения водителя";
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(175, 16);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(134, 22);
            this.FirstNameField.TabIndex = 3;
            // 
            // SecondaryNameField
            // 
            this.SecondaryNameField.Location = new System.Drawing.Point(175, 54);
            this.SecondaryNameField.Name = "SecondaryNameField";
            this.SecondaryNameField.Size = new System.Drawing.Size(134, 22);
            this.SecondaryNameField.TabIndex = 4;
            this.SecondaryNameField.Tag = "";
            // 
            // BirthDateField
            // 
            this.BirthDateField.Location = new System.Drawing.Point(175, 104);
            this.BirthDateField.Name = "BirthDateField";
            this.BirthDateField.Size = new System.Drawing.Size(100, 22);
            this.BirthDateField.TabIndex = 5;
            // 
            // AddDriver
            // 
            this.AddDriver.Location = new System.Drawing.Point(126, 143);
            this.AddDriver.Name = "AddDriver";
            this.AddDriver.Size = new System.Drawing.Size(75, 23);
            this.AddDriver.TabIndex = 6;
            this.AddDriver.Text = "Добавить";
            this.AddDriver.UseVisualStyleBackColor = true;
            this.AddDriver.Click += new System.EventHandler(this.AddDriver_Click);
            // 
            // inputMask
            // 
            this.inputMask.AutoSize = true;
            this.inputMask.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.inputMask.Location = new System.Drawing.Point(195, 89);
            this.inputMask.Name = "inputMask";
            this.inputMask.Size = new System.Drawing.Size(57, 13);
            this.inputMask.TabIndex = 7;
            this.inputMask.Text = "дд.мм.гггг";
            // 
            // CreateDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 189);
            this.Controls.Add(this.inputMask);
            this.Controls.Add(this.AddDriver);
            this.Controls.Add(this.BirthDateField);
            this.Controls.Add(this.SecondaryNameField);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.BirthDateDisplayname);
            this.Controls.Add(this.SecondaryNameDisplayname);
            this.Controls.Add(this.FirstNameDisplayname);
            this.Name = "CreateDriver";
            this.Text = "Добавление водителя";
            this.Load += new System.EventHandler(this.CreateDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameDisplayname;
        private System.Windows.Forms.Label SecondaryNameDisplayname;
        private System.Windows.Forms.Label BirthDateDisplayname;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox SecondaryNameField;
        private System.Windows.Forms.TextBox BirthDateField;
        private System.Windows.Forms.Button AddDriver;
        private System.Windows.Forms.Label inputMask;
    }
}