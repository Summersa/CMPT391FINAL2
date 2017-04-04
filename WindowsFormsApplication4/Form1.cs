using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
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
        int selectedRoom;
        String hidEmployee = "1";
        

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataA.Open();
            string sql = "select * from distinctYearDate";
            SqlCommand cmd = new SqlCommand(sql, dataA);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
                dateYearText.Items.Add(str);

            dr.Close();
            dataA.Close();

            dataA.Open();
            sql = "select * from distinctCountryHotel";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                hotelCountryText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();

            dataA.Open();
            sql = "exec getClientDWCountry";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                clientCountryText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();


            dataA.Close();

            dataA.Open();
            sql = "select * from distinctProvinceHotel";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                hotelProvinceText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();

            dataA.Open();
            sql = "select * from distinctProvinceClient";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                clientProvinceText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();
            dataA.Open();
            sql = "select * from distinctCityHotel";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                hotelCityText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();

            dataA.Open();
            sql = "select * from distinctCityClient";
            cmd = new SqlCommand(sql, dataA);
            dr = cmd.ExecuteReader();
            priv = new List<string>();
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv.Add(dr[0].ToString().TrimEnd());

                //String str = dr.GetValue(6);

            }
            foreach (string str in priv)
            {
                clientCityText.Items.Add(str);
            }

            dr.Close();
            dataA.Close();
        }



        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)searchRoomsComboBox.SelectedItem == "Empty Rooms")
            {//Booked
                selectedRoom = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                MessageBox.Show("You selected Room with ID: " + selectedRoom.ToString());
            }
            else if ((string)searchRoomsComboBox.SelectedItem == "Booked")
            {//Booked
                selectedRoom = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                MessageBox.Show("You selected Room with ID: " + selectedRoom.ToString());
            }
        }
    
        private void searchRoomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             /*All Rooms
             Empty Rooms
             Booked
             History*/
            if ((string) searchRoomsComboBox.SelectedItem == "All Rooms")
            {
                /*EXCEPT
SELECT ProductID
FROM Production.WorkOrder;*/
                String str = "Select * from Rooms as R where hid = '" + hidEmployee + "'";
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
            else if ((string)searchRoomsComboBox.SelectedItem == "Empty Rooms")
            {
                DateTime dtNow = DateTime.Now;
                String timestring = dtNow.Date.ToString();
                timestring = timestring.Split(' ')[0];
                String str = "Select * from Rooms as R where R.hid = '" + hidEmployee + "' Except Select RR.id, RR.hid, RR.lid, RR.price, RR.roomNumber, RR.description, RR.capacity  from Rooms as RR, Clients as CC where RR.hid = '" + hidEmployee + "'and CC.rid = RR.id and CC.endDate > '" + timestring + "'";
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
            else if((string)searchRoomsComboBox.SelectedItem == "Booked")
            {
                DateTime dtNow = DateTime.Now;
                String timestring = dtNow.Date.ToString();
                timestring = timestring.Split(' ')[0];
                   String str = "Select C.id, name, phoneNumber, price, roomNumber, capacity from Rooms as R, Clients as C where R.hid = '" + hidEmployee + "' and C.rid = R.id and C.endDate > '" + timestring + "'";
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
                // Current date


            }
            else
            {
                DateTime dtNow = DateTime.Now;
                String timestring = dtNow.Date.ToString();
                timestring = timestring.Split(' ')[0];
                String str = "Select C.id, name, phoneNumber, price, roomNumber, capacity, startDate, endDate from Rooms as R, Clients as C where R.hid = '" + hidEmployee + "' and C.rid = R.id and C.endDate <= '" + timestring + "'";
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
        }

        private void bookRoomButton_Click(object sender, EventArgs e)
        {
            if(selectedRoom > 0 && (string)searchRoomsComboBox.SelectedItem == "Empty Rooms")
            {
                Form3 formBooking = new Form3();
                formBooking.Show();
                formBooking.selectedRoom = selectedRoom;
                formBooking.hidEmployee = hidEmployee;
                
            }
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
            //hidEmployee = "1"; 
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

                String str = "Select * from Rooms as R where hid = '" + hidEmployee + "'";

                SqlCommand sc = new SqlCommand(str, dataA);
                //sc.Parameters.Add("@search", SqlDbType.NVarChar).Value = searchPatient.Text;
                //String stFr = "Select * from patientPhone where  (Name like '%' + @search + '%')";
                dataA.Open();
                //sc.ExecuteNonQuery();
                adapter = new SqlDataAdapter(str, dataA);
                adapter.SelectCommand = sc;
                ds = new System.Data.DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataA.Close();

                dataA.Open();
               
                sql = "select * from Hotels where id = '" +hidEmployee+ "'";
                cmd = new SqlCommand(sql, dataA);
                dr = cmd.ExecuteReader(); 
                while (dr.Read())
                {
                    hotelNameLabel.Text = dr[1].ToString().Replace(" ", String.Empty);
                }
                dr.Close();
                dataA.Close();

            }
            else MessageBox.Show("Wrong username or password");


        }

 

        public Form1()
        {
            InitializeComponent();
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataA.Open();
            string sql = "select sum(rentalDays) from roomsDW as r, ";
            //string sql = "select sum(id) from Employees";
            bool date = false, client = false, hotel = false;
            if(dateMonthText.Text != "" || dateQuarterText.Text != "" || dateYearText.Text != "")
            {
                date = true;
                sql += "dateDW as d ";
            }
            if(clientCountryText.Text != "" || clientProvinceText.Text != "" || clientCityText.Text != "")
            {
                client = true;
                if (date) sql += ", ";
                sql += "clientDW as c ";
            }
            if(hotelCountryText.Text != "" || hotelProvinceText.Text != "" || hotelCityText.Text != "")
            {
                if (date || client) sql += ", ";
                hotel = true;
                sql += "hotelDW as h ";
            }
            sql += "where ";
            if (date)
            {
                sql += "d.dateid = r.dateid and ";
                if(dateMonthText.Text != "") sql += "d.month = '" + dateMonthText.Text + "' ";
                if(dateQuarterText.Text != "")
                {
                    if (dateMonthText.Text != "") sql += "and ";
                    sql += "d.quarter = '" + dateQuarterText.Text + "' ";
                }
                if(dateYearText.Text != "")
                {
                    if (dateMonthText.Text != "" || dateQuarterText.Text != "") sql += "and ";
                    sql += "d.year = '" + dateYearText.Text + "' ";

                }
            }
            if (client)
            {
                if (date) sql += "and ";
                sql += "c.clientid = r.clientid and ";
                if (clientCountryText.Text != "") sql += "c.country = '" + clientCountryText.Text + "' ";
                if (clientProvinceText.Text != "")
                {
                    if (clientCountryText.Text != "") sql += "and ";
                    sql += "c.province = '" + clientProvinceText.Text + "' ";
                }
                if (clientCityText.Text != "")
                {
                    if (clientCountryText.Text != "" || clientProvinceText.Text != "") sql += "and ";
                    sql += "c.city = '" + clientCityText.Text + "' ";

                }
            }
            if (hotel)
            {
                if (date || client)
                {
                    sql += "and ";
                    
                }
                sql += "h.hotelid = r.hotelid and ";
                if (hotelCountryText.Text != "") sql += "h.country = '" + hotelCountryText.Text + "' ";
                if (hotelProvinceText.Text != "")
                {
                    if (hotelCountryText.Text != "") sql += "and ";
                    sql += "h.province = '" + hotelProvinceText.Text + "' ";
                }
                if (hotelCityText.Text != "")
                {
                    if (hotelCountryText.Text != "" || hotelProvinceText.Text != "") sql += "and ";
                    sql += "h.city = '" + hotelCityText.Text + "' ";

                }
            }
            MessageBox.Show(sql);
            SqlCommand cmd = new SqlCommand(sql, dataA);
            SqlDataReader dr = cmd.ExecuteReader();
            string priv = "";
            // var columns = new List<String>();
            // var reader = cmd.ExecuteReader();
            //hidEmployee = "1"; 
            while (dr.Read())
            {

                priv = dr[0].ToString();

                //String str = dr.GetValue(6);

            }
            
            dr.Close();
            sql = sql.Replace("sum(rentalDays)", "*");
            
            adapter = new SqlDataAdapter(sql, dataA);
            SqlCommand sc = new SqlCommand(sql, dataA);
            //sc.Parameters.Add("@search", SqlDbType.NVarChar).Value = searchPatient.Text;
            //String str = "Select * from patientPhone where  (Name like '%' + @search + '%')";

            //sc.ExecuteNonQuery();
            adapter = new SqlDataAdapter(sql, dataA);
            adapter.SelectCommand = sc;
            ds = new System.Data.DataSet();
            adapter.Fill(ds);
            ds.WriteXml("c:/Users/Anthony Summers/Desktop/XMLFILE.xml");

            dataA.Close();
            roomData.Text = "Total Number of Rooms: " + priv;
        }

        private void dateMonthText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dateMonthText.Text == "January" || dateMonthText.Text == "Febuary" || dateMonthText.Text == "March")
                    dateQuarterText.Text = "1";
            else if (dateMonthText.Text == "April" || dateMonthText.Text == "May" || dateMonthText.Text == "June")
                    dateQuarterText.Text = "2"; 
            else if (dateMonthText.Text == "July" || dateMonthText.Text == "August" || dateMonthText.Text == "September")
                    dateQuarterText.Text = "3"; 
            else
                dateQuarterText.Text = "4";
        }

        private void dateQuarterText_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateMonthText.Text = "";
        }

        private void dateYearText_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
    
        }

        private void clientProvinceText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if ((string)searchRoomsComboBox.SelectedItem == "Booked")
            {
                //selectedRoom = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                //MessageBox.Show(selectedRoom.ToString());

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                String str = dataGridView1.SelectedCells[0].Value.ToString();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE Clients where id = '" + selectedRoom + "'";
                cmd.Connection = dataA;

                dataA.Open();
                cmd.ExecuteNonQuery();
                dataA.Close();



                DateTime dtNow = DateTime.Now;
                String timestring = dtNow.Date.ToString();
                timestring = timestring.Split(' ')[0];
                str = "Select C.id, name, phoneNumber, price, roomNumber, capacity from Rooms as R, Clients as C where R.hid = '" + hidEmployee + "' and C.rid = R.id and C.endDate > '" + timestring + "'";
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
           
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            hidEmployee = null;
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidEmployee = null;
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
