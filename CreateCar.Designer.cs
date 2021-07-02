
namespace TransferDirectories
{
    partial class CreateCar
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
            this.AddCar = new System.Windows.Forms.Button();
            this.ModelDisplayname = new System.Windows.Forms.Label();
            this.RegNumberDisplayname = new System.Windows.Forms.Label();
            this.YearOfProdDisplayname = new System.Windows.Forms.Label();
            this.ColorDisplayname = new System.Windows.Forms.Label();
            this.ModelField = new System.Windows.Forms.TextBox();
            this.RegNumberField = new System.Windows.Forms.TextBox();
            this.YearOfProdField = new System.Windows.Forms.TextBox();
            this.ColorField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(154, 172);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(75, 23);
            this.AddCar.TabIndex = 1;
            this.AddCar.Text = "Добавить";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // ModelDisplayname
            // 
            this.ModelDisplayname.AutoSize = true;
            this.ModelDisplayname.Location = new System.Drawing.Point(12, 11);
            this.ModelDisplayname.Name = "ModelDisplayname";
            this.ModelDisplayname.Size = new System.Drawing.Size(48, 13);
            this.ModelDisplayname.TabIndex = 2;
            this.ModelDisplayname.Text = "Модель";
            // 
            // RegNumberDisplayname
            // 
            this.RegNumberDisplayname.AutoSize = true;
            this.RegNumberDisplayname.Location = new System.Drawing.Point(14, 42);
            this.RegNumberDisplayname.Name = "RegNumberDisplayname";
            this.RegNumberDisplayname.Size = new System.Drawing.Size(141, 13);
            this.RegNumberDisplayname.TabIndex = 3;
            this.RegNumberDisplayname.Text = "Регистрационный номер";
            // 
            // YearOfProdDisplayname
            // 
            this.YearOfProdDisplayname.AutoSize = true;
            this.YearOfProdDisplayname.Location = new System.Drawing.Point(14, 77);
            this.YearOfProdDisplayname.Name = "YearOfProdDisplayname";
            this.YearOfProdDisplayname.Size = new System.Drawing.Size(71, 13);
            this.YearOfProdDisplayname.TabIndex = 4;
            this.YearOfProdDisplayname.Text = "Год выпуска";
            // 
            // ColorDisplayname
            // 
            this.ColorDisplayname.AutoSize = true;
            this.ColorDisplayname.Location = new System.Drawing.Point(16, 110);
            this.ColorDisplayname.Name = "ColorDisplayname";
            this.ColorDisplayname.Size = new System.Drawing.Size(33, 13);
            this.ColorDisplayname.TabIndex = 5;
            this.ColorDisplayname.Text = "Цвет";
            // 
            // ModelField
            // 
            this.ModelField.Location = new System.Drawing.Point(183, 11);
            this.ModelField.Name = "ModelField";
            this.ModelField.Size = new System.Drawing.Size(196, 22);
            this.ModelField.TabIndex = 6;
            // 
            // RegNumberField
            // 
            this.RegNumberField.Location = new System.Drawing.Point(183, 42);
            this.RegNumberField.Name = "RegNumberField";
            this.RegNumberField.Size = new System.Drawing.Size(100, 22);
            this.RegNumberField.TabIndex = 7;
            // 
            // YearOfProdField
            // 
            this.YearOfProdField.Location = new System.Drawing.Point(183, 77);
            this.YearOfProdField.Name = "YearOfProdField";
            this.YearOfProdField.Size = new System.Drawing.Size(100, 22);
            this.YearOfProdField.TabIndex = 8;
            // 
            // ColorField
            // 
            this.ColorField.Location = new System.Drawing.Point(183, 110);
            this.ColorField.Name = "ColorField";
            this.ColorField.Size = new System.Drawing.Size(100, 22);
            this.ColorField.TabIndex = 9;
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 218);
            this.Controls.Add(this.ColorField);
            this.Controls.Add(this.YearOfProdField);
            this.Controls.Add(this.RegNumberField);
            this.Controls.Add(this.ModelField);
            this.Controls.Add(this.ColorDisplayname);
            this.Controls.Add(this.YearOfProdDisplayname);
            this.Controls.Add(this.RegNumberDisplayname);
            this.Controls.Add(this.ModelDisplayname);
            this.Controls.Add(this.AddCar);
            this.Name = "CreateCar";
            this.Text = "Добавление машины";
            this.Load += new System.EventHandler(this.CreateCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Label ModelDisplayname;
        private System.Windows.Forms.Label RegNumberDisplayname;
        private System.Windows.Forms.Label YearOfProdDisplayname;
        private System.Windows.Forms.Label ColorDisplayname;
        private System.Windows.Forms.TextBox ModelField;
        private System.Windows.Forms.TextBox RegNumberField;
        private System.Windows.Forms.TextBox YearOfProdField;
        private System.Windows.Forms.TextBox ColorField;
    }
}