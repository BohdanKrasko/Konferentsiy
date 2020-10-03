using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static public MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            try
            {
                con.ConnectionString = "server=localhost;User Id=root;Persist Security Info=True;database=konfentsiyi_6";
                con.Open();
                MessageBox.Show("Підключення відбулося успішно");
            }
            catch {
                MessageBox.Show("Помилка при підключенні");
            }
        }

        private void довідникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void конференціїToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Ви впевнені, що хочете завершити роботу?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) {
                Close();
            }
        }
    }
}
