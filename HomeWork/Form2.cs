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
    public partial class Form2 : Form
    {
        public static Form2 frm2;
        public Form2()
        {
            InitializeComponent();
            frm2 = this;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //对timer1进行相关设置
            timer1.Interval = 1000;
            timer1.Start();
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            switch (keyData)
            {
                //Esc
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* String conString = "server=127.0.0.1;port=3306;user=root;password=123456; database=test;";
             int width = 0;
             for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
             {
                 this.dataGridView1.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                 width += this.dataGridView1.Columns[i].Width;
             }
             if (width > this.dataGridView1.Size.Width)
             {
                 this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
             }
             else
             {
                 this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             }

             MySqlConnection conn = new MySqlConnection(conString); //新建连接
             try
             {
                 conn.Open();
                 MessageBox.Show("已经建立连接");
                 string sqlCmd = "select * from 学生表";
                 MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
                 MySqlDataReader reader = cmd.ExecuteReader();

                 BindingSource bs = new BindingSource();
                 bs.DataSource = reader;
                 this.dataGridView1.DataSource = bs;
             }
             catch (MySqlException ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 conn.Close();
             }*/
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //设置timer控件时间
            this.toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹窗提醒取消
            if (MessageBox.Show("Leave this user?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)

            {

                this.Close();

            }
        }

        private void 新建学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=test;";
            MySqlConnection conn = null;
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句

                MessageBox.Show("连接成功");

                string sql = "select * from 学生表";//sql语句

                MySqlDataAdapter sda = new MySqlDataAdapter(sql, conn);//读取表数据

                DataTable dt = new DataTable();//dt是一个表类型。

                sda.Fill(dt);//把sda读取的数据填到dt里

                dataGridView1.DataSource = dt;//把dt的内容绑定到Gridview1里显示。

            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); //new到另一个面板
            f4.ShowDialog();  //展示登录后的面板
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); //new到另一个面板
            f4.ShowDialog();  //展示登录后的面板
        }

        private void 查找学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
