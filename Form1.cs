using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp1;






namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        static String Sql = "Data Source=DESKTOP-TPH4P1C\\SQLEXPRESS;Initial Catalog=UserEmailPass;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(Sql);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUserTable();
        }


        public DataTable LoadUserTable()
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM UserEmailPass";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO UserEmailPass (UserName , Email , Password) VALUES  (@UserName , @Email ,  @Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Saved");
            dataGridView1.DataSource = LoadUserTable();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE UserEmailPass SET UserName=@UserName , Email=@Email , Password=@Password WHERE ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Updated");
            dataGridView1.DataSource = LoadUserTable();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM UserEmailPass WHERE ID =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
            dataGridView1.DataSource = LoadUserTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM UserEmailPass WHERE UserName LIKE '%"+txtSearch.Text+"%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;


        }
    }




}