using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.NewFolder1;


namespace WindowsFormsApp8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new ModelEF().Users.Any(x=> x.Login == textBox1.Text && x.Password == textBox2.Text))
            {
                MessageBox.Show("Пользователь найден");
                return;
            }
            MessageBox.Show("Пользователь не найден, пройдите проверку Captcha!");
            new CaptchForm().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
