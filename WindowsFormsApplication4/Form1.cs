using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        String permission;
        SqlConnection dataA = new SqlConnection(" Data Source = DANTEVFENRIS;Initial Catalog = Cmpt391Final; Integrated Security = TRUE" /*"Data Source=MERLIN;Initial Catalog=CMPT_291_Project;Integrated Security=TRUE"*/);
        String priv;
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adapter;
        DataSet ds;
        String selectedPatient, selectedCase, selectedStaff, selectedWard;





        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            dataA.Open();
            bool login = false;
            string sql = "select * from Employees where username = '" + usernameTextbox.Text + "' and password = '" + passwordTextbox.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, dataA);
            SqlDataReader dr = cmd.ExecuteReader();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            String hidEmployee = "1";
            while (dr.Read())
            {

                priv = dr[2].ToString().Replace(" ", String.Empty);// privledge
                hidEmployee = dr[1].ToString().Replace(" ", String.Empty);
                login = true;

                //String str = dr.GetValue(6);

            }
            dr.Close();
            dataA.Close();
            if (login)
            {
                tabControl1.SelectedTab = tabPage2;
                MessageBox.Show("Thank you for logging in");
                passwordTextbox.Text = "";
                usernameTextbox.Text = "";


                String str = "Select name, phoneNumber, price, availability, roomNumber, capacity from Rooms as R, Clients as C where R.hid = 1 and C.id = R.id";
                SqlCommand sc = new SqlCommand(str, dataA);
                //sc.Parameters.Add("@search", SqlDbType.NVarChar).Value = searchPatient.Text;
                //String str = "Select * from patientPhone where  (Name like '%' + @search + '%')";
                dataA.Open();
                //sc.ExecuteNonQuery();
                adapter = new SqlDataAdapter(str, dataA);
                adapter.SelectCommand = sc;
                ds = new System.Data.DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataA.Close();

            }
            else MessageBox.Show("Wrong username or password");

        }

 

        public Form1()
        {
            InitializeComponent();
        }
    }
}
