using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string FirstName = Tb_FN.Text;
            string SecondName = Tb_SN.Text;
            string RoomNumber = Tb_RN.Text;
            if(FirstName == "" || SecondName == "" ||  RoomNumber == "" || FirstName == null || SecondName == null || RoomNumber == null)
            {
                MessageBox.Show("Пустое поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Convert.ToInt32(RoomNumber) < 100 || Convert.ToInt32(RoomNumber) > 300)
            {
                MessageBox.Show("Номер комнаты должен быть больше 100 и меньше 300!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DbWork.AddStudent(FirstName, SecondName, RoomNumber);
                MessageBox.Show("Студент успешно добавлен!");
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
