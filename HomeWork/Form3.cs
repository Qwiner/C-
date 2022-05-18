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
    public partial class Form3 : Form
    {
        
        public object DbHelperMySQL { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string 学号 = textBox1.Text;
            string 学生姓名 = textBox2.Text;
            string 学生性别 = "男";
            string 学生年龄 = textBox4.Text;
            string 班级编号 = textBox5.Text;
            string 生源所在地 = textBox6.Text;
            string 已修学分总数 = textBox7.Text;
            if (reMale.Checked)
            {
                学生性别 = "男";
            }
            else
            {
                学生性别 = "女";
            }
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();
                String sql = "INSERT INTO 学生表 VALUES('" + 学号 + "','" + 学生姓名 + "','" + 学生性别 + "','"
                   + 学生年龄 + "','" + 班级编号 + "','" + 生源所在地 + "','" + 已修学分总数 + "')";//SQL语句实现表数据的读取

                MySqlCommand co = new MySqlCommand(sql, conn);  //往表内添加记录

                co.ExecuteNonQuery();   //执行sql添加语句
                MessageBox.Show("已建立连接", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
            }
            catch (MySqlException)	//catch捕获异常
            {
                MessageBox.Show("请检查学号是否存在或者信息是否为空", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            finally
            {
                conn.Close();	//关闭连接
            }
            Form2.frm2.button1_Click(sender, e);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
