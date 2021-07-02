using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferDirectories
{
    public partial class CreateCrew : Form
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }

        public CreateCrew()
        {
            InitializeComponent();
        }

        private void CreateCrew_Load(object sender, EventArgs e)
        {
            CrewCarField.Text = CarName;
            CrewDriverField.Text = DriverName;
            GridsLoad();
        }

        private void GridsLoad()
        {
            //Проверяем подключение к базе
            if (DirectoriesForm.sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
                return;
            }

            DataTable CrewCarsTable = new DataTable();
            DataTable CrewDriversTable = new DataTable();
            
            String crewCarssqlQuery;
            String crewDriverssqlQuery;

            //Получаем выборку для каждой таблицы

            crewCarssqlQuery = "SELECT Id, model || ' г/н ' || registryNumber FROM Cars";
            crewDriverssqlQuery = "SELECT Id, FirstName || ' ' || SecondaryName FROM Drivers";
            //Загружаем данные в гриды
            GetDataForGrid(CrewCarsTable, crewCarssqlQuery, сrewCarsGrid);
            GetDataForGrid(CrewDriversTable, crewDriverssqlQuery, сrewDriversGrid);
        }

        private void GetDataForGrid(DataTable dTable, string sqlQuery, DataGridView grid)
        {
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, DirectoriesForm.sqliteConn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    grid.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        grid.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Таблица " + dTable.TableName + " не содержит записей");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Обработка селектов строк грида
        private void CrewCarGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CarId = int.Parse(сrewCarsGrid.CurrentRow.Cells[0].Value.ToString());
            CarName = сrewCarsGrid.CurrentRow.Cells[1].Value.ToString();
            CrewCarField.Text = сrewCarsGrid.CurrentRow.Cells[1].Value.ToString();
        }
        private void CrewDriversGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DriverId = int.Parse(сrewDriversGrid.CurrentRow.Cells[0].Value.ToString());
            DriverName = сrewDriversGrid.CurrentRow.Cells[1].Value.ToString();
            CrewDriverField.Text = сrewDriversGrid.CurrentRow.Cells[1].Value.ToString();
        }
        //Обработка кнопки 'Добавить'
        private void AddCrew_Click(object sender, EventArgs e)
        {
            
            if (CarId == 0) MessageBox.Show("Выберите машину");
            else if (DriverId == 0) MessageBox.Show("Выберите водителя");
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
