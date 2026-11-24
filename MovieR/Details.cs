using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MovieR
{
    class Details
    {
        
            public int MId { get; set; }
            public string Movie { get; set; }
            public string Actor { get; set; }
            public string Actress { get; set; }
            public string Genre { get; set; }
            public int Rating { get; set; }
            public string Release { get; set; }
            public string HallName { get; set; }



        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\MovieR.mdf;Integrated Security=True;Connect Timeout=30";

            public DataTable showAllDetails()
            {
                string q = "Select * From MovieR";
                SqlDataAdapter sda = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
            }
            public bool insert(Details d)
            {
                bool isSuccess = false;

                SqlConnection sqc = new SqlConnection(connection);
                sqc.Open();

            string q = "INSERT into MovieR (MId, Movie, Actor, Actress, Genre, HallName, Rating, Release) " +
        "Values (@MId,@Movie,@Actor,@Actress,@Genre,@HallName,@Rating,@Release)";

            SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@MId", d.MId);
                sq.Parameters.AddWithValue("@Movie", d.Movie);
                sq.Parameters.AddWithValue("@Actor", d.Actor);
                sq.Parameters.AddWithValue("@Actress", d.Actress);
                sq.Parameters.AddWithValue("@Genre", d.Genre);
                sq.Parameters.AddWithValue("@Rating", d.Rating);
                sq.Parameters.AddWithValue("@Release", d.Release);
                sq.Parameters.AddWithValue("@HallName", d.HallName);


            if (sqc.State == ConnectionState.Open)
                {
                    int row = sq.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }

                sqc.Close();


                return isSuccess;
            }

        public bool Update(Details d)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = "Update MovieR set Movie=@Movie, Actor=@Actor, Actress=@Actress, Genre=@Genre, Rating=@Rating, HallName=@HallName, Release=@Release " +
           "Where MId=@MId";

                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@MId", d.MId);
                sq.Parameters.AddWithValue("@Movie", d.Movie);
                sq.Parameters.AddWithValue("@Actor", d.Actor);
                sq.Parameters.AddWithValue("@Actress", d.Actress);
                sq.Parameters.AddWithValue("@Genre", d.Genre);
                sq.Parameters.AddWithValue("@Rating", d.Rating);
                sq.Parameters.AddWithValue("@Release", d.Release);
                sq.Parameters.AddWithValue("@HallName", d.HallName);




                if (sqc.State == ConnectionState.Open)
                {
                    int row = sq.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception e)
            {
                return isSuccess;
            }
            finally
            {
                sqc.Close();
            }

            return isSuccess;
        }
        public bool Delete(Details d)
        {
            bool isSuccess = false;

            SqlConnection sqc = new SqlConnection(connection);
            sqc.Open();
            try
            {
                string q = "Delete from MovieR where MId=@MId";
                SqlCommand sq = new SqlCommand(q, sqc);
                sq.Parameters.AddWithValue("@MId", d.MId);

                if (sqc.State == ConnectionState.Open)
                {
                    int row = sq.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception e)
            {
                return isSuccess;
            }
            finally
            {
                sqc.Close();
            }

            return isSuccess;
        }

    }
}
