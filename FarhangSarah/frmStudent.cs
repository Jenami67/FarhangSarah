using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarhangSarah
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        FarhangSarahDBEntities ctx = new FarhangSarahDBEntities();
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                dgvStudents.DataSource = ctx.Student.ToList<Student>();
            }
        }
    }
}
