using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferDirectories
{
    public partial class CreateCar : Form
    {
        public String Model { get; set; }
        public String RegistrationNumber { get; set; }
        public int YearOfProduction { get; set; }
        public String Color { get; set; }
        public CreateCar()
        {
            InitializeComponent();
        }

        private void CreateCar_Load(object sender, EventArgs e)
        {
            ModelField.Text = Model;
            RegNumberField.Text = RegistrationNumber;
            YearOfProdField.Text = YearOfProduction.ToString();
            ColorField.Text = Color;
        }
        //Обработка кнопки 'Добавить'
        private void AddCar_Click(object sender, EventArgs e)
        {
            int yearOfProdValue = 0;
            if (ModelField.Text == "") MessageBox.Show("Введите модель машины");
            else if (RegNumberField.Text == "") MessageBox.Show("Введите регистрационный машины");
            else if (int.TryParse(YearOfProdField.Text, out yearOfProdValue) == false) MessageBox.Show("Введите корректный год выпуска машины");
            else if (ColorField.Text == "") MessageBox.Show("Введите цвет машины");
            else
            {
                Model = ModelField.Text;
                RegistrationNumber = RegNumberField.Text;
                YearOfProduction = yearOfProdValue;
                Color = ColorField.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
