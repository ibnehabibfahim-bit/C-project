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
namespace MovieR
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        Details d = new Details();
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\MovieR.mdf;Integrated Security=True;Connect Timeout=30";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            LoginR lg = new LoginR();
            lg.Show();
            this.Hide();
        }

        private void bClick_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_Movie.Text;
                string actor = tb_ActorName.Text;
                string actress = tb_ActressName.Text;
                string genre = tb_Genre.Text;
                int rating = Convert.ToInt32(tb_Rating.Text);
                int mid = Convert.ToInt32(tb_MID.Text);
                string release = dt_release.Value.ToString();
                string hall = cb_Hall.Text;

                MessageBox.Show($"Info: \nMovie is: {name}\nMID is: { mid}\nRating is: {rating}\nActor is: {actor}\nActress is: {actress}\nGenre is: {genre}\nHall is: {hall}");

            }
            catch //jate submit korar por click korle value ashe nahole clear hoye jaito
            {
                MessageBox.Show("Please select or enter valid data first!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bNext_Click(object sender, EventArgs e)
        {
            MovieInstructions mi = new MovieInstructions();
            mi.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_ActressName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActorName_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            tb_MID.Text = null;
            tb_Movie.Text = null;
            tb_ActorName.Text = null;
            tb_ActressName.Text = null;
            tb_Genre.Text = null;
            tb_Rating.Text = null;
            dt_release.Value = DateTime.Now;
            cb_Hall.SelectedIndex = -1;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            /*  String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\MovieR.mdf;Integrated Security=True;Connect Timeout=30";
              SqlConnection sqc = new SqlConnection(connection);
              sqc.Open();
              SqlCommand scComm = new SqlCommand("INSERT into MovieR (MId, Movie,Actor,Actress,Genre,Rating) Values (@MId, @Movie)", sqc);
              scComm.Parameters.AddWithValue("@MId", Convert.ToInt32(tb_MID.Text));
              scComm.Parameters.AddWithValue("@Movie ", tb_Movie.Text);
              scComm.Parameters.AddWithValue("@MActor ", tb_ActorName.Text);
              scComm.Parameters.AddWithValue("@Actress ", tb_ActressName.Text);
              scComm.Parameters.AddWithValue("@Gnere ", tb_Genre.Text);
              scComm.Parameters.AddWithValue("@Rating ", Convert.ToInt32(tb_Rating.Text));

              //scComm.Parameters.AddWithValue("@Cgpa", Convert.ToDouble(tb_cgpa.Text));

              scComm.ExecuteNonQuery();

              sqc.Close();
              MessageBox.Show("User Added");

              tb_MID.Clear();
              tb_Movie.Clear();
            */
            try
            {
                d.MId = Convert.ToInt32(tb_MID.Text);
                d.Movie = tb_Movie.Text;
                d.Actor = tb_ActorName.Text;
                d.Actress = tb_ActressName.Text;
                d.Genre = tb_Genre.Text;
                d.Rating = Convert.ToInt32(tb_Rating.Text);
                d.Release = dt_release.Value.ToString();
                d.HallName = cb_Hall.Text;

                bool x = d.insert(d);

                if (x == true)
                {
                    MessageBox.Show("Successfully added!!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something Wrong!!");
                }

                DataTable dt = d.showAllDetails();
                dataGridView2.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Something Wrong!!");
            }
        }

        private void MName_Click(object sender, EventArgs e)
        {

        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            DataTable dt = d.showAllDetails();
            dataGridView2.DataSource = dt;
        }

        private void tb_MID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Rating_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;
            tb_MID.Text = dataGridView2.Rows[row_index].Cells[0].Value.ToString();
            tb_Movie.Text = dataGridView2.Rows[row_index].Cells[1].Value.ToString();
            tb_ActorName.Text = dataGridView2.Rows[row_index].Cells[2].Value.ToString();
            tb_ActressName.Text = dataGridView2.Rows[row_index].Cells[3].Value.ToString();
            tb_Genre.Text = dataGridView2.Rows[row_index].Cells[4].Value.ToString();
            tb_Rating.Text = dataGridView2.Rows[row_index].Cells[5].Value.ToString();
            dt_release.Text = dataGridView2.Rows[row_index].Cells[6].Value.ToString();
            cb_Hall.Text = dataGridView2.Rows[row_index].Cells[7].Value.ToString();


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
                try
                {
                    d.MId = Convert.ToInt32(tb_MID.Text);
                    d.Movie = tb_Movie.Text;
                    d.Actor = tb_ActorName.Text;
                    d.Actress = tb_ActressName.Text;
                    d.Genre = tb_Genre.Text;
                    d.Rating = Convert.ToInt32(tb_Rating.Text);
                    d.Release = dt_release.Value.ToString();
                    d.HallName = cb_Hall.Text;

                    bool x = d.Update(d);

                    if (x == true)
                    {
                        MessageBox.Show("Successfully Updated!!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!!");
                    }

                    DataTable dt = d.showAllDetails();
                    dataGridView2.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Something Wrong!!");
                }
           }
        //delete er
        private void button1_Click(object sender, EventArgs e)
        {
            d.MId = Convert.ToInt32(tb_MID.Text);

            bool x = d.Delete(d);
            if (x == true)
            {
                MessageBox.Show("Successfully Deleted!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Something went wrong!! try Again!!");
            }
            DataTable dt = d.showAllDetails();
            dataGridView2.DataSource = dt;
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();

            string q = "Select * from MovieR Where Movie Like '%" + tb_Search.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, sqc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void tb_Movie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cb_Hall_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
