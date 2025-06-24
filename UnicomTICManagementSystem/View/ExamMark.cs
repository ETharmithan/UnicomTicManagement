using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.View
{
    public partial class ExamMark : Form
    {
        public ExamMark()
        {
            InitializeComponent();
        }

        private void b_examreg_Click(object sender, EventArgs e)
        {
            ExamRegisterForm examRegisterForm = new ExamRegisterForm();
            examRegisterForm.ShowDialog();
        }

        private void b_examview_Click(object sender, EventArgs e)
        {
            ViewExam viewExam = new ViewExam();
            viewExam.ShowDialog();
        }

        private void b_mark_Click(object sender, EventArgs e)
        {
            MarkRegister markRegister = new MarkRegister();
            markRegister.ShowDialog();
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
