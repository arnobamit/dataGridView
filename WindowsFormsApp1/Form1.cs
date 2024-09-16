using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arnob\OneDrive\Documents\DemoDB.mdf;Integrated Security=True;Connect Timeout=30;");

        private void Reset()
        {
            IdTb.Text = "";
            NameTb.Text = "";
            EmailTb.Text = "";
            AgeTb.Text = "";
            PhoneTb.Text = "";
            BgCb.SelectedIndex = -1;           
        }

        private void populate()
        {
            con.Open();
            string query = "select * from InfoTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NameTb.Text == "" || EmailTb.Text == "" || AgeTb.Text == "" ||  PhoneTb.Text == "" || BgCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "insert into InfoTable values('" + IdTb.Text + "', '" + NameTb.Text + "', '" + EmailTb.Text + "', '" + AgeTb.Text + "', '" + PhoneTb.Text + "', '" + BgCb.SelectedItem.ToString() + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Information Successfully Saved");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from InfoTable where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", IdTb.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Successfully Deleted");
            populate();
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update InfoTable set Id=@Id, Name=@Name, Email=@Email, Age=@Age, Phone=@Phone, Blood_Group=@Blood_Group", con);
            cmd.Parameters.AddWithValue("@Id", IdTb.Text);
            cmd.Parameters.AddWithValue("@Name", NameTb.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTb.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(AgeTb.Text));
            cmd.Parameters.AddWithValue("@Phone", int.Parse(PhoneTb.Text));
            cmd.Parameters.AddWithValue("@Blood_Group", BgCb.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information Successfully Updated");
            populate();
            Reset();
        }
    }
}
