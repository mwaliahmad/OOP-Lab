using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Problem01.BL;
using Problem01.DL;
namespace Problem01
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string role = textBox3.Text;
            string path = "data.txt";
            User U = new User(name, pass, role);
            UserCRUD.AddUserToList(U);
            UserCRUD.DatatoFile(U, path);
            MessageBox.Show("User Added");
            ClearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
