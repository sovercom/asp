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
    public partial class 머신DB입력 : MetroForm
    {
        public 머신DB입력()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            insertDB();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            머신DBList newform2 = new 머신DBList();
            newform2.Show();
        }

        public void insertDB()
        {
            string connectString = "Server=127.0.0.1;Database=gydb;Uid=gyuser;Pwd=4321";
            MySqlConnection connection = new MySqlConnection(connectString);


            String insertquery = String.Format("insert into tbl_machine" +
                                 "(managerName,machineName,temperature,power,runtime)" +
                                 "values('{0}','{1}','{2}','{3}','{4}');", managerName.Text, machineName.Text,
                                                                           temperature.Text, power.Text, runtime.Text);

            try
            {
                connection.Open();
                Console.WriteLine("DB연결이 성공하였습니다.");

                MySqlCommand mySqlCommand = new MySqlCommand(insertquery, connection);
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("DB접속이 실패했습니다.");
            }
        }
    }
}
