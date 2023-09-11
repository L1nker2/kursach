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
    public partial class EditForm : Form
    {
        public int _id;
        public EditForm(int id)
        {
            _id = id;
            InitializeComponent();
            using (var dbContext = new StudentDbContext())
            {
                var entity = dbContext.Students.Find(id);
                if (entity != null)
                {
                    Fn_Tb.Text = entity.FirstName;
                    Sn_Tb.Text = entity.SecondName;
                    Rn_Tb.Text = entity.RoomNumber;
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            using (var context = new StudentDbContext())
            {
                var record = context.Students.Find(_id);

                if (record != null)
                {
                    record.FirstName = Fn_Tb.Text;
                    record.SecondName = Sn_Tb.Text;
                    record.RoomNumber = Rn_Tb.Text;
                    context.SaveChanges();
                    MessageBox.Show("Изменение прошло успешно!");
                }
            }
        }
    }
}
