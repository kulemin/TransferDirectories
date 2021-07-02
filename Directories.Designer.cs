
namespace TransferDirectories
{
    partial class DirectoriesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCar = new System.Windows.Forms.Button();
            this.carsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversGrid = new System.Windows.Forms.DataGridView();
            this.drId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateDriver = new System.Windows.Forms.Button();
            this.ChangeCar = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.ChangeDriver = new System.Windows.Forms.Button();
            this.DeleteDriver = new System.Windows.Forms.Button();
            this.CreateCrew = new System.Windows.Forms.Button();
            this.crId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeCrew = new System.Windows.Forms.Button();
            this.DeleteCrew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCar
            // 
            this.CreateCar.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateCar.Location = new System.Drawing.Point(20, 31);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(123, 23);
            this.CreateCar.TabIndex = 1;
            this.CreateCar.Text = "Добавить машину";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // carsGrid
            // 
            this.carsGrid.AllowUserToAddRows = false;
            this.carsGrid.AllowUserToDeleteRows = false;
            this.carsGrid.CausesValidation = false;
            this.carsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Model,
            this.RegistryNumber,
            this.YearOfProduction,
            this.Color});
            this.carsGrid.Location = new System.Drawing.Point(20, 61);
            this.carsGrid.MultiSelect = false;
            this.carsGrid.Name = "carsGrid";
            this.carsGrid.ReadOnly = true;
            this.carsGrid.RowTemplate.Height = 24;
            this.carsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsGrid.Size = new System.Drawing.Size(504, 193);
            this.carsGrid.TabIndex = 2;
            this.carsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.carsGrid_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 120;
            // 
            // RegistryNumber
            // 
            this.RegistryNumber.HeaderText = "Регистрационный номер";
            this.RegistryNumber.Name = "RegistryNumber";
            this.RegistryNumber.ReadOnly = true;
            this.RegistryNumber.Width = 120;
            // 
            // YearOfProduction
            // 
            this.YearOfProduction.HeaderText = "Год выпуска";
            this.YearOfProduction.Name = "YearOfProduction";
            this.YearOfProduction.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 110;
            // 
            // driversGrid
            // 
            this.driversGrid.AllowUserToAddRows = false;
            this.driversGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drId,
            this.FirstName,
            this.LastName,
            this.BirthDate});
            this.driversGrid.Location = new System.Drawing.Point(23, 332);
            this.driversGrid.MultiSelect = false;
            this.driversGrid.Name = "driversGrid";
            this.driversGrid.ReadOnly = true;
            this.driversGrid.RowTemplate.Height = 24;
            this.driversGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driversGrid.Size = new System.Drawing.Size(501, 190);
            this.driversGrid.TabIndex = 3;
            this.driversGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.driversGrid_CellMouseClick);
            // 
            // drId
            // 
            this.drId.HeaderText = "drId";
            this.drId.Name = "drId";
            this.drId.ReadOnly = true;
            this.drId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 150;
            // 
            // crewsGrid
            // 
            this.crewsGrid.AllowUserToAddRows = false;
            this.crewsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crId,
            this.crCarId,
            this.crDriverId,
            this.Car,
            this.Driver});
            this.crewsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.crewsGrid.Location = new System.Drawing.Point(540, 60);
            this.crewsGrid.MultiSelect = false;
            this.crewsGrid.Name = "crewsGrid";
            this.crewsGrid.ReadOnly = true;
            this.crewsGrid.RowTemplate.Height = 24;
            this.crewsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crewsGrid.Size = new System.Drawing.Size(439, 194);
            this.crewsGrid.TabIndex = 4;
            this.crewsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crewsGrid_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Водители";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Экипажи";
            // 
            // CreateDriver
            // 
            this.CreateDriver.Location = new System.Drawing.Point(23, 302);
            this.CreateDriver.Name = "CreateDriver";
            this.CreateDriver.Size = new System.Drawing.Size(120, 23);
            this.CreateDriver.TabIndex = 8;
            this.CreateDriver.Text = "Добавить водителя";
            this.CreateDriver.UseVisualStyleBackColor = true;
            this.CreateDriver.Click += new System.EventHandler(this.CreateDriver_Click);
            // 
            // ChangeCar
            // 
            this.ChangeCar.Location = new System.Drawing.Point(172, 31);
            this.ChangeCar.Name = "ChangeCar";
            this.ChangeCar.Size = new System.Drawing.Size(97, 23);
            this.ChangeCar.TabIndex = 9;
            this.ChangeCar.Text = "Редактировать";
            this.ChangeCar.UseVisualStyleBackColor = true;
            this.ChangeCar.Click += new System.EventHandler(this.ChangeCar_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(299, 31);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(119, 23);
            this.DeleteCar.TabIndex = 10;
            this.DeleteCar.Text = "Удалить машину";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // ChangeDriver
            // 
            this.ChangeDriver.Location = new System.Drawing.Point(172, 302);
            this.ChangeDriver.Name = "ChangeDriver";
            this.ChangeDriver.Size = new System.Drawing.Size(97, 23);
            this.ChangeDriver.TabIndex = 11;
            this.ChangeDriver.Text = "Редактировать";
            this.ChangeDriver.UseVisualStyleBackColor = true;
            this.ChangeDriver.Click += new System.EventHandler(this.ChangeDriver_Click);
            // 
            // DeleteDriver
            // 
            this.DeleteDriver.Location = new System.Drawing.Point(299, 302);
            this.DeleteDriver.Name = "DeleteDriver";
            this.DeleteDriver.Size = new System.Drawing.Size(119, 23);
            this.DeleteDriver.TabIndex = 12;
            this.DeleteDriver.Text = "Удалить водителя";
            this.DeleteDriver.UseVisualStyleBackColor = true;
            this.DeleteDriver.Click += new System.EventHandler(this.DeleteDriver_Click);
            // 
            // CreateCrew
            // 
            this.CreateCrew.Location = new System.Drawing.Point(540, 31);
            this.CreateCrew.Name = "CreateCrew";
            this.CreateCrew.Size = new System.Drawing.Size(121, 23);
            this.CreateCrew.TabIndex = 13;
            this.CreateCrew.Text = "Добавить экипаж";
            this.CreateCrew.UseVisualStyleBackColor = true;
            this.CreateCrew.Click += new System.EventHandler(this.CreateCrew_Click);
            // 
            // crId
            // 
            this.crId.HeaderText = "crId";
            this.crId.Name = "crId";
            this.crId.ReadOnly = true;
            this.crId.Visible = false;
            // 
            // crCarId
            // 
            this.crCarId.HeaderText = "crCarId";
            this.crCarId.Name = "crCarId";
            this.crCarId.ReadOnly = true;
            this.crCarId.Visible = false;
            // 
            // crDriverId
            // 
            this.crDriverId.HeaderText = "crDriverId";
            this.crDriverId.Name = "crDriverId";
            this.crDriverId.ReadOnly = true;
            this.crDriverId.Visible = false;
            // 
            // Car
            // 
            this.Car.FillWeight = 250F;
            this.Car.HeaderText = "Машина";
            this.Car.Name = "Car";
            this.Car.ReadOnly = true;
            this.Car.Width = 200;
            // 
            // Driver
            // 
            this.Driver.HeaderText = "Водитель";
            this.Driver.Name = "Driver";
            this.Driver.ReadOnly = true;
            this.Driver.Width = 180;
            // 
            // ChangeCrew
            // 
            this.ChangeCrew.Location = new System.Drawing.Point(682, 31);
            this.ChangeCrew.Name = "ChangeCrew";
            this.ChangeCrew.Size = new System.Drawing.Size(98, 23);
            this.ChangeCrew.TabIndex = 14;
            this.ChangeCrew.Text = "Редактировать";
            this.ChangeCrew.UseVisualStyleBackColor = true;
            this.ChangeCrew.Click += new System.EventHandler(this.ChangeCrew_Click);
            // 
            // DeleteCrew
            // 
            this.DeleteCrew.Location = new System.Drawing.Point(801, 31);
            this.DeleteCrew.Name = "DeleteCrew";
            this.DeleteCrew.Size = new System.Drawing.Size(113, 23);
            this.DeleteCrew.TabIndex = 15;
            this.DeleteCrew.Text = "Удалить экипаж";
            this.DeleteCrew.UseVisualStyleBackColor = true;
            this.DeleteCrew.Click += new System.EventHandler(this.DeleteCrew_Click);
            // 
            // DirectoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 545);
            this.Controls.Add(this.DeleteCrew);
            this.Controls.Add(this.ChangeCrew);
            this.Controls.Add(this.CreateCrew);
            this.Controls.Add(this.DeleteDriver);
            this.Controls.Add(this.ChangeDriver);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.ChangeCar);
            this.Controls.Add(this.CreateDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crewsGrid);
            this.Controls.Add(this.driversGrid);
            this.Controls.Add(this.carsGrid);
            this.Controls.Add(this.CreateCar);
            this.Name = "DirectoriesForm";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.DirectoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.DataGridView carsGrid;
        private System.Windows.Forms.DataGridView driversGrid;
        private System.Windows.Forms.DataGridView crewsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverId;
        private System.Windows.Forms.Button ChangeCar;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Button ChangeDriver;
        private System.Windows.Forms.Button DeleteDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn drId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.Button CreateCrew;
        private System.Windows.Forms.DataGridViewTextBoxColumn crId;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.Button ChangeCrew;
        private System.Windows.Forms.Button DeleteCrew;
    }
}

