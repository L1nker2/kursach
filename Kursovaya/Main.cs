using System.Data;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Main : Form
    {
        public void LoadData()
        {
            using (var context = new StudentDbContext())
            {
                var students = context.Students.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер студента", typeof(int));
                dataTable.Columns.Add("Имя студента", typeof(string));
                dataTable.Columns.Add("Фамилия студента", typeof(string));
                dataTable.Columns.Add("Номер комнаты", typeof(string));
                foreach (var student in students)
                {
                    dataTable.Rows.Add(student.Id, student.FirstName, student.SecondName, student.RoomNumber);
                }
                datagridview.DataSource = dataTable;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;
                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridview.RowHeadersVisible = false;
            }
        }
        public Main()
        {
            InitializeComponent();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
            f.FormClosed += AddFormClosed;
        }
        private void AddFormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview.SelectedRows[0];
                string fieldValue = selectedRow.Cells["Номер студента"].Value.ToString();
                EditForm f = new EditForm(int.Parse(fieldValue));
                f.Show();
                f.FormClosed += AddFormClosed;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать студента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview.SelectedRows[0];
                string fieldValue = selectedRow.Cells["Номер студента"].Value.ToString();
                DbWork.DeleteStudent(int.Parse(fieldValue));
                MessageBox.Show("Студент удален успешно!");
                LoadData();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите базу данных!");
            openFileDialog1.Filter = "MDF files (*.mdf)|*.mdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={openFileDialog1.FileName};Integrated Security=True";
                StudentDbContext.sqlstr = connectionString;
                LoadData();
            }
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработал Кириллов Евгений Алексеевич студент группы 404 - ИС");
        }

        private void floor_one_btn_Click(object sender, EventArgs e)
        {
            using (var context = new StudentDbContext())
            {
                var students = context.Students.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер студента", typeof(int));
                dataTable.Columns.Add("Имя студента", typeof(string));
                dataTable.Columns.Add("Фамилия студента", typeof(string));
                dataTable.Columns.Add("Номер комнаты", typeof(string));
                foreach (var student in students)
                {
                    if (Convert.ToInt32(student.RoomNumber) >= 100 && Convert.ToInt32(student.RoomNumber) < 200)
                    {
                        dataTable.Rows.Add(student.Id, student.FirstName, student.SecondName, student.RoomNumber);
                    }
                }
                datagridview.DataSource = dataTable;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;
                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridview.RowHeadersVisible = false;
            }
        }

        private void floor_two_btn_Click(object sender, EventArgs e)
        {
            using (var context = new StudentDbContext())
            {
                var students = context.Students.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер студента", typeof(int));
                dataTable.Columns.Add("Имя студента", typeof(string));
                dataTable.Columns.Add("Фамилия студента", typeof(string));
                dataTable.Columns.Add("Номер комнаты", typeof(string));
                foreach (var student in students)
                {
                    if (Convert.ToInt32(student.RoomNumber) >= 200 && Convert.ToInt32(student.RoomNumber) < 300)
                    {
                        dataTable.Rows.Add(student.Id, student.FirstName, student.SecondName, student.RoomNumber);
                    }
                }
                datagridview.DataSource = dataTable;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;
                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridview.RowHeadersVisible = false;
            }
        }

        private void floor_three_btn_Click(object sender, EventArgs e)
        {
            using (var context = new StudentDbContext())
            {
                var students = context.Students.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер студента", typeof(int));
                dataTable.Columns.Add("Имя студента", typeof(string));
                dataTable.Columns.Add("Фамилия студента", typeof(string));
                dataTable.Columns.Add("Номер комнаты", typeof(string));
                foreach (var student in students)
                {
                    if (Convert.ToInt32(student.RoomNumber) >= 300)
                    {
                        dataTable.Rows.Add(student.Id, student.FirstName, student.SecondName, student.RoomNumber);
                    }
                }
                datagridview.DataSource = dataTable;
                datagridview.ReadOnly = true;
                datagridview.AllowUserToAddRows = false;
                datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridview.RowHeadersVisible = false;
            }
        }
    }
}