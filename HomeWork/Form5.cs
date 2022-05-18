﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
           /* try
            {*/

                conn.Open();
            //    String sql = "update 学生表 set 学号='"+学号+ "'学生姓名='" + 学生姓名 + "'学生性别='" + 学生性别 + "'学生年龄='" + 学生年龄 + "'班级编号='" + 班级编号 + "'生源所在地='" +生源所在地 + "'已修学分总数='"+ 已修学分总数 + "' where 学号 = '" + 学号+"'";//SQL语句实现表数据的读取
            String sql = "update 学生表 set 学生姓名 = '" + 学生姓名 +  "',学生性别 = '" + 学生性别 + "',学生年龄 = '" + 学生年龄 + "',班级编号 = '" + 班级编号 + "',生源所在地 = '" + 生源所在地 + "',已修学分总数 = '" + 已修学分总数 + "' where 学号 = '" + 学号 + "'";
                MySqlCommand co = new MySqlCommand(sql, conn);  //往表内添加记录

                co.ExecuteNonQuery();   //执行sql添加语句
                
                MessageBox.Show("更新成功", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form2.frm2.button1_Click(sender, e);

            //   }

            /*catch (MySqlException)	//catch捕获异常
            {
                MessageBox.Show("更新失败", "用户提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }*/

            /* finally
             {
                 conn.Close();	//关闭连接
             }*/
            //Form2.frm2.button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
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
