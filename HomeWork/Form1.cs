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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //弹窗提醒取消
            if (MessageBox.Show("Leave this user?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)

            {

                this.Close();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 1.连接数据库 判断是否相等 相等则关闭当前 显示新窗口
             */
            string userName = this.textBox1.Text;
            string userPassword = this.textBox2.Text;
            
            //1.验证数据  空值
            if(userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("账号或密码不能为空");
            }

            //2.不会空 验证与数据库是否匹配
            else
            {
                String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test;";
                
                MySqlConnection conn = new MySqlConnection(connetStr);
                try
                {
                    conn.Open();//打开通道，建立连接
                    string strSql = "select * from 用户登陆 where 学生账号 = '" + this.textBox1.Text.Trim().ToString() + "'and 账号密码 = '" +
                    this.textBox2.Text.Trim().ToString() + "'";
                    //this.textBox1.Text.Trim().ToString()获取文本框的值，往数据库里查询
                    MySqlCommand comm = new MySqlCommand(strSql, conn);
                    MySqlDataReader dr = comm.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        label1.Visible = false ;
                        label2.Visible = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;

                        timer1.Start();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！");
                    }

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location.X>210)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X-5,pictureBox1.Location.Y+1);
            }
            else
            {
                timer1.Stop();
                this.Hide();  //登录成功后，隐藏该页面
                Form2 f2 = new Form2(); //new到另一个面板
                Form2.frm2.button1_Click(sender, e);
                f2.ShowDialog();  //展示登录后的面板
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
