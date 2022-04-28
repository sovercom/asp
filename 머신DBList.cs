using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace project01
{
    public partial class 머신DBList : MetroForm
    {
        public 머신DBList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectDB();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1/MachineManage");
        }

        public void selectDB()
        {
            string connectString = "Server=127.0.0.1;Database=gydb;Uid=gyuser;Pwd=4321";
            MySqlConnection connection = new MySqlConnection(connectString);

            try
            {
                connection.Open();
                String query = "select managerName, machineName, temperature, power, runtime from " +
                               "tbl_machine order by machineName";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable datatable = new DataTable();
                datatable.Load(mySqlDataReader);
                dataGridView01.DataSource = datatable;

                mySqlDataReader.Close();
                connection.Close();
            }

            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString() + " " + "DB연결이 실패했습니다.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
