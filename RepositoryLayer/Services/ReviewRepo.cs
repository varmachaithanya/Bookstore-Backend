using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Services
{
    public class ReviewRepo:IReviewRepo
    {
        string connectionstring = @"Data Source=BOOK-L13QO8KE6K\SQLEXPRESS01;Initial Catalog=Bookstore;Integrated Security=True";


        public ReviewModel AddReview(ReviewModel model, int userid)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("spAddReview", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    cmd.Parameters.AddWithValue("@Review", model.Review);
                    cmd.Parameters.AddWithValue("@Star", model.Star);
                    cmd.Parameters.AddWithValue("@BookId", model.BookId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return model;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return null;
            }
        }


        public List<Review> GetReviews(int bookid)
        {

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("spGetReview", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookId", bookid);

                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    List<Review> reviews = new List<Review>();

                    while (dataReader.Read())
                    {
                        Review review = new Review();
                        review.FullName = dataReader["FullName"].ToString();
                        review.Reviews = dataReader["Review"].ToString();
                        review.Star = Convert.ToInt32(dataReader["Star"]);
                        review.BookId = Convert.ToInt32(dataReader["BookId"]);

                        reviews.Add(review);

                    }
                    return reviews;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return null;
            }
        }

    }
}
