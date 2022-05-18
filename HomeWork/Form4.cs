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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test";
            MySqlConnection conn = new MySqlConnection(connectStr);  //并没有去跟数据库建立连接
            string 学号 = textBox1.Text;
            try
            {
                conn.Open();   //与MySQL数据库建立连接
                string sql = "delete from 学生表 where 学号 = "+学号;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();   //执行sql添加语句
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                Console.WriteLine(e.ToString());

            }
            finally
            {
                conn.Close();
            }
            Form2.frm2.button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
