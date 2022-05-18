using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWork
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string 学号 = textBox1.Text;
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test;";
            MySqlConnection conn = null;
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句


                string sql = "select * from 学生表 where 学号 =" +学号;//sql语句

                MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);//读取表数据

                DataTable dt = new DataTable();//dt是一个表类型。

                sda.Fill(dt);//把sda读取的数据填到dt里

                dataGridView1.DataSource = dt;//把dt的内容绑定到Gridview1里显示。

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("失败", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            switch (keyData)
            {
                //Esc
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.button1.Focus();
                    break;
            }
            return false;
        }

    }
}
