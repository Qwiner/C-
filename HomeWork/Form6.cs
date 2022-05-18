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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string 学生账号 = textBox1.Text;
            string 账号密码 = textBox2.Text;
            
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                String sql = "INSERT INTO 用户登陆 VALUES('" + 学生账号 + "','" + 账号密码 + "')";//SQL语句实现表数据的读取

                MySqlCommand co = new MySqlCommand(sql, conn);  //往表内添加记录

                co.ExecuteNonQuery();   //执行sql添加语句
                MessageBox.Show("注册成功", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }



            catch (MySqlException)	//catch捕获异常
            {
                MessageBox.Show("注册失败", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            finally
            {
                conn.Close();	//关闭连接
            }
            Form6 f6 = new Form6();
            f6.Close();

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
