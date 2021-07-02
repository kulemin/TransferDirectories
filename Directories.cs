using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace TransferDirectories
{
    public partial class DirectoriesForm : Form
    {
        internal String sqliteFileName;
        internal static SQLiteConnection sqliteConn;
        internal SQLiteCommand sqliteCmd;
        private int currentCarId = 0;
        private int currentDriverId = 0;
        private int currentCrewId = 0;
        private int crewCarId = 0;
        private int crewDriverId = 0;

        public DirectoriesForm()
        {
            InitializeComponent();
        }

        private void DirectoriesForm_Load(object sender, EventArgs e)
        {
            sqliteConn = new SQLiteConnection();
            sqliteCmd = new SQLiteCommand();

            sqliteFileName = "TransferDirectories.sqlite";

            //При первом запуске, если еще не создана БД, - создаем и наполняем тестовыми данными, иначе - подключаемся к БД
            if (!File.Exists(sqliteFileName))
                CreateSqliteDB();
            else ConnectSqliteDB();

            GridsLoad();

        }

        private void CreateSqliteDB()
        {
            //Создаем файл с БД
            SQLiteConnection.CreateFile(sqliteFileName);

            //Подключаемся к БД
            ConnectSqliteDB();
            try
            {
                sqliteCmd.CommandText = "CREATE TABLE IF NOT EXISTS Cars (id INTEGER PRIMARY KEY AUTOINCREMENT, model TEXT, " +
                                        "registryNumber TEXT, yearOfProduction INTEGER, color TEXT)";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "CREATE TABLE IF NOT EXISTS Drivers (id INTEGER PRIMARY KEY AUTOINCREMENT, firstName TEXT, " +
                                        "secondaryName TEXT, birthDate TEXT)";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "CREATE TABLE IF NOT EXISTS Crews (id INTEGER PRIMARY KEY AUTOINCREMENT, carId INTEGER, " +
                                        "driverId INTEGER, FOREIGN KEY (carId) REFERENCES Cars(id), FOREIGN KEY (driverId) REFERENCES Drivers(id))";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Cars ('model', 'registryNumber', 'yearOfProduction', 'color') " +
                                        "values ('Volkswagen Transporter', 'A001EE16', 1976, 'Yellow')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Cars ('model', 'registryNumber', 'yearOfProduction', 'color') " +
                                        "values ('Ford Transit', 'T003EO77', 1997, 'Green')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Cars ('model', 'registryNumber', 'yearOfProduction', 'color') " +
                                        "values ('Mersedes Vito', 'X021AE18', 2003, 'Gray')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Drivers ('firstName', 'secondaryName', 'birthDate') values ('Александр', 'Новиков', '06.08.1984')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Drivers ('firstName', 'secondaryName', 'birthDate') values ('Владимир', 'Алексеев', '14.11.1978')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Drivers ('firstName', 'secondaryName', 'birthDate') values ('Антон', 'Ковалев', '21.02.1991')";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Crews ('carId', 'driverId') values (1, 2)";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Crews ('carId', 'driverId') values (2, 3)";
                sqliteCmd.ExecuteNonQuery();
                sqliteCmd.CommandText = "INSERT INTO Crews ('carId', 'driverId') values (3, 1)";
                sqliteCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ConnectSqliteDB()
        {
            try
            {
                sqliteConn = new SQLiteConnection("Data Source=" + sqliteFileName + ";Version=3;");
                sqliteConn.Open();
                sqliteCmd.Connection = sqliteConn;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GridsLoad()
        {
            //Проверяем подключение к базе
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
                return;
            }

            DataTable CarsTable = new DataTable();
            DataTable DriversTable = new DataTable();
            DataTable CrewssTable = new DataTable();
            String carsSqlQuery;
            String driverssqlQuery;
            String crewssqlQuery;

            //Получаем выборку для каждой таблицы
            carsSqlQuery = "SELECT Id, model, registryNumber, yearOfProduction, color FROM Cars";
            driverssqlQuery = "SELECT Id, firstName, secondaryName, birthDate FROM Drivers";
            crewssqlQuery = "SELECT Cr.Id, Cr.carId, Cr.driverId, C.model || ' г/н ' || C.registryNumber AS car, D.firstName || ' ' || D.secondaryName AS driver FROM Crews Cr " +
                            "inner join Cars C on Cr.carId = C.Id " +
                            "inner join Drivers D on Cr.driverId = D.Id";

            //Загружаем данные в гриды
            GetDataForGrid(CarsTable, carsSqlQuery, carsGrid);
            GetDataForGrid(DriversTable, driverssqlQuery, driversGrid);
            GetDataForGrid(CrewssTable, crewssqlQuery, crewsGrid);
        }

        private void GetDataForGrid(DataTable dTable, string sqlQuery, DataGridView grid)
        {
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, sqliteConn);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        //Обработка селектов строки грида
        private void carsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentCarId = int.Parse(carsGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void driversGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentDriverId = int.Parse(driversGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void crewsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentCrewId = int.Parse(crewsGrid.CurrentRow.Cells[0].Value.ToString());
            crewCarId = int.Parse(crewsGrid.CurrentRow.Cells[1].Value.ToString());
            crewDriverId = int.Parse(crewsGrid.CurrentRow.Cells[2].Value.ToString());
        }

        //Создание новой машины
        private void CreateCar_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            CreateCar addCar = new CreateCar();
            if (addCar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "INSERT INTO Cars ('model', 'registryNumber', 'yearOfProduction', 'color') " +
                                            "values ('" + addCar.Model + "', '" + addCar.RegistrationNumber + "', " + addCar.YearOfProduction + ", '" + addCar.Color + "')";

                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Изменение машины
        private void ChangeCar_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentCarId == 0)
            {
                MessageBox.Show("Выберите машину для изменения");
                return;
            }

            CreateCar changeCar = new CreateCar();
            changeCar.Model = carsGrid.CurrentRow.Cells[1].Value.ToString();
            changeCar.RegistrationNumber = carsGrid.CurrentRow.Cells[2].Value.ToString();
            changeCar.YearOfProduction = int.Parse(carsGrid.CurrentRow.Cells[3].Value.ToString());
            changeCar.Color = carsGrid.CurrentRow.Cells[4].Value.ToString();
            if (changeCar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "UPDATE Cars SET model = '" + changeCar.Model + "', registryNumber = '" + changeCar.RegistrationNumber + 
                                            "', yearOfProduction = " + changeCar.YearOfProduction + ", color = '" + changeCar.Color + "' where Id = " + currentCarId;
                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Удаление машины
        private void DeleteCar_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentCarId == 0)
            {
                MessageBox.Show("Выберите машину для удаления");
                return;
            }

            try
            {
                sqliteCmd.CommandText = "DELETE FROM Cars where Id = " + currentCarId;

                sqliteCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            GridsLoad();
        }
       
        //Создание водителя
        private void CreateDriver_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            CreateDriver addDriver = new CreateDriver();
            if (addDriver.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "INSERT INTO Drivers ('firstName', 'secondaryName', 'birthDate') " +
                                            "values ('" + addDriver.FirstName + "', '" + addDriver.SecondaryName + "', '" + addDriver.BirthDate + "')";

                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Изменение водителя
        private void ChangeDriver_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentDriverId == 0)
            {
                MessageBox.Show("Выберите водителя для изменения");
                return;
            }

            CreateDriver changeDriver = new CreateDriver();
            changeDriver.FirstName = driversGrid.CurrentRow.Cells[1].Value.ToString();
            changeDriver.SecondaryName = driversGrid.CurrentRow.Cells[2].Value.ToString();
            changeDriver.BirthDate = driversGrid.CurrentRow.Cells[3].Value.ToString();
         
            if (changeDriver.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "UPDATE Drivers SET firstName = '" + changeDriver.FirstName + "', secondaryName = '" + changeDriver.SecondaryName +
                                            "', birthDate = '" + changeDriver.BirthDate + "' where Id = " + currentDriverId;
                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Удаление водителя
        private void DeleteDriver_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentDriverId == 0)
            {
                MessageBox.Show("Выберите водителя для удаления");
                return;
            }

            try
            {
                sqliteCmd.CommandText = "DELETE FROM Drivers where Id = " + currentDriverId;

                sqliteCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            GridsLoad();
        }

        //Создание экипажа
        private void CreateCrew_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            CreateCrew addCrew = new CreateCrew();
            if (addCrew.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "INSERT INTO Crews ('carId', 'driverId') " +
                                            "values (" + addCrew.CarId + ", " + addCrew.DriverId + ")";

                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Изменение экипажа
        private void ChangeCrew_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentCrewId == 0)
            {
                MessageBox.Show("Выберите экипаж для изменения");
                return;
            }

            CreateCrew addCrew = new CreateCrew();
            addCrew.CarId = crewCarId;
            addCrew.CarName = crewsGrid.CurrentRow.Cells[3].Value.ToString();
            addCrew.DriverId = crewDriverId;
            addCrew.DriverName = crewsGrid.CurrentRow.Cells[4].Value.ToString();

            if (addCrew.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqliteCmd.CommandText = "UPDATE Crews SET carId = " + addCrew.CarId + ", driverId = " + addCrew.DriverId + " WHERE Id = " + currentCrewId;
                    sqliteCmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            GridsLoad();
        }

        //Удаление экипажа
        private void DeleteCrew_Click(object sender, EventArgs e)
        {
            if (sqliteConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Нет подключения к базе данных");
                return;
            }

            if (currentCrewId == 0)
            {
                MessageBox.Show("Выберите экипаж для удаления");
                return;
            }

            try
            {
                sqliteCmd.CommandText = "DELETE FROM Crews where Id = " + currentCrewId;

                sqliteCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            GridsLoad();
        }
    }
}
