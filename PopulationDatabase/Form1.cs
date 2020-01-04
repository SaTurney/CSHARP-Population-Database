//Sabrina Turney
//C# I
//Population Database
//Last Edited: 10/07/2019

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace PopulationDatabase
{
    public partial class Form1 : Form
    {
        //Connect to the student form for the .mdf file to edit and use in the form design.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\School\Fall 2019\C# I\Student Sample Programs\Chap11\PopulationDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
            //Calling bindGrid() to attach to our form
            bindGrid();
        }
        //This is the form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            //Again calling bindGrid()
            bindGrid();
        }
        //Actually binding datagrid to our form.
        public void bindGrid()
        {
            //1: Open connection
            con.Open();
            //2: Use new datatable "dt"
            DataTable dt = new DataTable();
            //3: Selecting all records "from city" using SQL language
            adapt = new SqlDataAdapter("select * from city", con);
            //4: Filling data adapter with dt
            adapt.Fill(dt);
            //5: Binding grid with dt as source
            dataGridView1.DataSource = dt;
            //6: VERY IMPORTANT TO close connection!
            con.Close();
        }
        //Clear text fields  
        private void ClearData()
        {
            txtCity.Text = "";
            txtPopulation.Text = "";

        }
        //Inserting data
        private void BtnInsert_Click_1(object sender, EventArgs e)
        {
            if (txtCity.ReadOnly == true)
            {
                txtCity.ReadOnly = false;
            }
            //Validation checking if "city" and "population" textboxes are filled (or not)
            if (txtCity.Text != "" && txtPopulation.Text != "")
            {
                //If not, insert the city and population in the city table.
                cmd = new SqlCommand("insert into city (city,Population) values(@city,@Population)", con);
                con.Open();//Remember to open the connection
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@Population", float.Parse(txtPopulation.Text));
                cmd.ExecuteNonQuery();
                con.Close();//Remember to CLOSE THE CONNECTION!
                MessageBox.Show("Record Inserted Successfully");
                bindGrid();//calling bindGrid();
                ClearData();//calling ClearData() method to clear textboxes

            }
            else
            {
                //If either textbox entry is empty, show an error message: Cut it out.
                MessageBox.Show("Please Provide Details!");
            }
        }
        //Upate records
        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            //checking if city and population textbox is empty
            if (txtCity.Text != "" && txtPopulation.Text != "")
            {
                //if not command for updating records
                cmd = new SqlCommand("update city set Populationi=@Populationi where City=@city", con);
                con.Open();
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@Populationi", float.Parse(txtPopulation.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                bindGrid();//calling bindGrid() method
                ClearData(); //calling ClearData() method
            }
            else
            {
                //if empty show error message
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete record
        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            //checking if city is empty
            if (txtCity.Text != "")
            {
                //if not then query to delete record
                cmd = new SqlCommand("delete city where City=@city", con);
                con.Open(); //opening connection
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.ExecuteNonQuery();
                con.Close(); //closing connection
                MessageBox.Show("Record Deleted Successfully!");
                bindGrid(); //calling bindGrid() method
                ClearData(); //calling ClearData() method
            }
            else
            {
                //if empty then show error message
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //after row header click showing the city and population in textboxes
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCity.ReadOnly = true; //for updating population making city textbox readonly
            txtPopulation.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //code for Total Population
        private void BtnTotalPopulation_Click_1(object sender, EventArgs e)
        {
            con.Open();
            //sql query for total population
            SqlCommand cmd = new SqlCommand("select sum(Population) from city", con);
            //displaying result on label lblTotalPopulation
            lblTotalPopulation.Text = String.Format("Total Population is : " + cmd.ExecuteScalar().ToString());
            con.Close();
        }
        //code for Average Population
        private void BtnAveragePopulation_Click_1(object sender, EventArgs e)
        {
            con.Open();
            //sql query for average population
            SqlCommand cmd = new SqlCommand("select avg(Population) from city", con);
            //displaying result on label lblaveragePopulation
            lblAveragePopulation.Text = String.Format("Average Population is : " + cmd.ExecuteScalar().ToString());
            con.Close();
        }
        //code for Heighest Population
        private void BtnHighestPopulation_Click_1(object sender, EventArgs e)
        {
            con.Open();
            //sql query for heighest population
            SqlCommand cmd = new SqlCommand("select max(Population) from city", con);
            //displaying result on label lblHeighest
            lblHighestPopulation.Text = String.Format("Heighest Population is : " + cmd.ExecuteScalar().ToString());
            con.Close();
        }
        //code for Lowest Population
        private void BtnLowestPopulation_Click_1(object sender, EventArgs e)
        {
            con.Open();
            //sql query for lowest population
            SqlCommand cmd = new SqlCommand("select min(Population) from city", con);
            //displaying result on label lblLowest
            lblLowestPopulation.Text = String.Format("Lowest Population is : " + cmd.ExecuteScalar().ToString());
            con.Close();
        }

        //It was easiest to show all message boxes as labels that way they updated as they were clicked and records changed.


        private void Button1_Click(object sender, EventArgs e)
        {
            //My favorite part!
            this.Close();
        }
    }
}