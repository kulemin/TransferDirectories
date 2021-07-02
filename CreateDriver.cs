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
    public partial class CreateDriver : Form
    {
        public String FirstName { get; set; }
        public String SecondaryName { get; set; }
        public string BirthDate { get; set; }
        public CreateDriver()
        {
            InitializeComponent();
        }

        private void CreateDriver_Load(object sender, EventArgs e)
        {
            FirstNameField.Text = FirstName;
            SecondaryNameField.Text = SecondaryName;
            BirthDateField.Text = BirthDate;
        }
        //Обработка кнопки 'Добавить'
        private void AddDriver_Click(object sender, EventArgs e)
        {
            DateTime BirthDateValue = new DateTime();
            if (FirstNameField.Text == "") MessageBox.Show("Введите имя водителя");
            else if (SecondaryNameField.Text == "") MessageBox.Show("Введите фамилию водителя");
            else if (DateTime.TryParse(BirthDateField.Text, out BirthDateValue) == false) MessageBox.Show("Введите корректную дату рождения");
            else
            {
                FirstName = FirstNameField.Text;
                SecondaryName = SecondaryNameField.Text;
                BirthDate = BirthDateField.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
