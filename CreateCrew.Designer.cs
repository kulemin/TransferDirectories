
namespace TransferDirectories
{
    partial class CreateCrew
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
            this.CurrentCrew = new System.Windows.Forms.Label();
            this.CrewCarDisplayname = new System.Windows.Forms.Label();
            this.CrewCarField = new System.Windows.Forms.TextBox();
            this.CrewDriverDisplayname = new System.Windows.Forms.Label();
            this.CrewDriverField = new System.Windows.Forms.TextBox();
            this.сrewCarsGrid = new System.Windows.Forms.DataGridView();
            this.ChooseCarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseCarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarChoose = new System.Windows.Forms.Label();
            this.DriverChoose = new System.Windows.Forms.Label();
            this.сrewDriversGrid = new System.Windows.Forms.DataGridView();
            this.ChooseDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCrew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.сrewCarsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сrewDriversGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentCrew
            // 
            this.CurrentCrew.AutoSize = true;
            this.CurrentCrew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CurrentCrew.Location = new System.Drawing.Point(22, 23);
            this.CurrentCrew.Name = "CurrentCrew";
            this.CurrentCrew.Size = new System.Drawing.Size(96, 13);
            this.CurrentCrew.TabIndex = 0;
            this.CurrentCrew.Text = "Текущий экипаж";
            // 
            // CrewCarDisplayname
            // 
            this.CrewCarDisplayname.AutoSize = true;
            this.CrewCarDisplayname.Location = new System.Drawing.Point(25, 51);
            this.CrewCarDisplayname.Name = "CrewCarDisplayname";
            this.CrewCarDisplayname.Size = new System.Drawing.Size(52, 13);
            this.CrewCarDisplayname.TabIndex = 1;
            this.CrewCarDisplayname.Text = "Машина";
            // 
            // CrewCarField
            // 
            this.CrewCarField.Location = new System.Drawing.Point(97, 47);
            this.CrewCarField.Name = "CrewCarField";
            this.CrewCarField.Size = new System.Drawing.Size(189, 22);
            this.CrewCarField.TabIndex = 2;
            // 
            // CrewDriverDisplayname
            // 
            this.CrewDriverDisplayname.AutoSize = true;
            this.CrewDriverDisplayname.Location = new System.Drawing.Point(25, 78);
            this.CrewDriverDisplayname.Name = "CrewDriverDisplayname";
            this.CrewDriverDisplayname.Size = new System.Drawing.Size(57, 13);
            this.CrewDriverDisplayname.TabIndex = 3;
            this.CrewDriverDisplayname.Text = "Водитель";
            // 
            // CrewDriverField
            // 
            this.CrewDriverField.Location = new System.Drawing.Point(97, 75);
            this.CrewDriverField.Name = "CrewDriverField";
            this.CrewDriverField.Size = new System.Drawing.Size(189, 22);
            this.CrewDriverField.TabIndex = 4;
            // 
            // сrewCarsGrid
            // 
            this.сrewCarsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сrewCarsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseCarId,
            this.ChooseCarName});
            this.сrewCarsGrid.Location = new System.Drawing.Point(28, 134);
            this.сrewCarsGrid.Name = "сrewCarsGrid";
            this.сrewCarsGrid.RowTemplate.Height = 24;
            this.сrewCarsGrid.Size = new System.Drawing.Size(310, 150);
            this.сrewCarsGrid.TabIndex = 5;
            this.сrewCarsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CrewCarGrid_CellMouseClick);
            // 
            // ChooseCarId
            // 
            this.ChooseCarId.HeaderText = "ChooseCarId";
            this.ChooseCarId.Name = "ChooseCarId";
            this.ChooseCarId.ReadOnly = true;
            this.ChooseCarId.Visible = false;
            // 
            // ChooseCarName
            // 
            this.ChooseCarName.HeaderText = "Машина";
            this.ChooseCarName.Name = "ChooseCarName";
            this.ChooseCarName.ReadOnly = true;
            this.ChooseCarName.Width = 220;
            // 
            // CarChoose
            // 
            this.CarChoose.AutoSize = true;
            this.CarChoose.Location = new System.Drawing.Point(28, 115);
            this.CarChoose.Name = "CarChoose";
            this.CarChoose.Size = new System.Drawing.Size(106, 13);
            this.CarChoose.TabIndex = 6;
            this.CarChoose.Text = "Выберите машину";
            // 
            // DriverChoose
            // 
            this.DriverChoose.AutoSize = true;
            this.DriverChoose.Location = new System.Drawing.Point(366, 115);
            this.DriverChoose.Name = "DriverChoose";
            this.DriverChoose.Size = new System.Drawing.Size(112, 13);
            this.DriverChoose.TabIndex = 7;
            this.DriverChoose.Text = "Выберите водителя";
            // 
            // сrewDriversGrid
            // 
            this.сrewDriversGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сrewDriversGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseDriverId,
            this.ChooseDriverName});
            this.сrewDriversGrid.Location = new System.Drawing.Point(358, 134);
            this.сrewDriversGrid.Name = "сrewDriversGrid";
            this.сrewDriversGrid.RowTemplate.Height = 24;
            this.сrewDriversGrid.Size = new System.Drawing.Size(294, 150);
            this.сrewDriversGrid.TabIndex = 8;
            this.сrewDriversGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CrewDriversGrid_CellMouseClick);
            // 
            // ChooseDriverId
            // 
            this.ChooseDriverId.HeaderText = "ChooseDriverId";
            this.ChooseDriverId.Name = "ChooseDriverId";
            this.ChooseDriverId.Visible = false;
            // 
            // ChooseDriverName
            // 
            this.ChooseDriverName.HeaderText = "Водитель";
            this.ChooseDriverName.Name = "ChooseDriverName";
            this.ChooseDriverName.ReadOnly = true;
            this.ChooseDriverName.Width = 220;
            // 
            // AddCrew
            // 
            this.AddCrew.Location = new System.Drawing.Point(305, 308);
            this.AddCrew.Name = "AddCrew";
            this.AddCrew.Size = new System.Drawing.Size(75, 23);
            this.AddCrew.TabIndex = 9;
            this.AddCrew.Text = "Добавить";
            this.AddCrew.UseVisualStyleBackColor = true;
            this.AddCrew.Click += new System.EventHandler(this.AddCrew_Click);
            // 
            // CreateCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 343);
            this.Controls.Add(this.AddCrew);
            this.Controls.Add(this.сrewDriversGrid);
            this.Controls.Add(this.DriverChoose);
            this.Controls.Add(this.CarChoose);
            this.Controls.Add(this.сrewCarsGrid);
            this.Controls.Add(this.CrewDriverField);
            this.Controls.Add(this.CrewDriverDisplayname);
            this.Controls.Add(this.CrewCarField);
            this.Controls.Add(this.CrewCarDisplayname);
            this.Controls.Add(this.CurrentCrew);
            this.Name = "CreateCrew";
            this.Text = "CreateCrew";
            this.Load += new System.EventHandler(this.CreateCrew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сrewCarsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сrewDriversGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentCrew;
        private System.Windows.Forms.Label CrewCarDisplayname;
        private System.Windows.Forms.TextBox CrewCarField;
        private System.Windows.Forms.Label CrewDriverDisplayname;
        private System.Windows.Forms.TextBox CrewDriverField;
        private System.Windows.Forms.DataGridView сrewCarsGrid;
        private System.Windows.Forms.Label CarChoose;
        private System.Windows.Forms.Label DriverChoose;
        private System.Windows.Forms.DataGridView сrewDriversGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChooseCarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChooseCarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChooseDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChooseDriverName;
        private System.Windows.Forms.Button AddCrew;
    }
}