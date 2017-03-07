using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        SqlConnection dataA = new SqlConnection(" Data Source = DANTEVFENRIS;Initial Catalog = Cmpt391Final; Integrated Security = TRUE" /*"Data Source=MERLIN;Initial Catalog=CMPT_291_Project;Integrated Security=TRUE"*/);
        String priv;
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adapter;
        DataSet ds;
        public String hidEmployee = "1";
        public int selectedRoom;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bookQuestButton_Click(object sender, EventArgs e)
        {
            String dateStartString = dateStart.Value.ToString().Split(' ')[0];
            String dateEndString = dateEnd.Value.ToString().Split(' ')[0];
            dataA.Open();
            string sql = "select Count(id) from Clients";
            SqlCommand cmd = new SqlCommand(sql, dataA);
            //cmd.CommandText = "SELECT COUNT(*) FROM table_name";
            Int32 count = (Int32)cmd.ExecuteScalar() + 1;
            dataA.Close();
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Clients (id,name,phoneNumber,creditCard,rid,startDate,endDate) VALUES ('" + count + "','" + bookName.Text + "','" + bookPhone.Text + "','" + bookCard.Text + "','" + Convert.ToInt32(selectedRoom) + "','" + dateStartString + "','" + dateEndString + "')";
            cmd.Connection = dataA;
            dataA.Open();
            try
            {
                ExecuteSqlTransaction(" Data Source = DANTEVFENRIS;Initial Catalog = Cmpt391Final; Integrated Security = TRUE" /*"Data Source=MERLIN;Initial Catalog=CMPT_291_Project;Integrated Security=TRUE"*/,count, dateStartString, dateEndString);
                //cmd.ExecuteNonQuery();
            }
            catch (Exception) { MessageBox.Show(selectedRoom.ToString()); }
            dataA.Close();
            this.Hide();
        }
        private void ExecuteSqlTransaction(string connectionString, int count, string dateStartString, string dateEndString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //"INSERT Clients (id,name,phoneNumber,creditCard,rid,startDate,endDate) VALUES ('" + count + "','" + bookName.Text + "','" + bookPhone.Text + "','" + bookCard.Text + "','" + Convert.ToInt32(selectedRoom) + "','" + dateStartString + "','" + dateEndString + "')";
                    command.CommandText =
                        "Insert into Clients (id,name,phoneNumber,creditCard,rid,startDate,endDate) VALUES ('" + count + "','" + bookName.Text + "','" + bookPhone.Text + "','" + bookCard.Text + "','" + Convert.ToInt32(selectedRoom) + "','" + dateStartString + "','" + dateEndString + "')";
                    command.ExecuteNonQuery();
                    //command.CommandText =
                      //  "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                  //  command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }
    }
    }

