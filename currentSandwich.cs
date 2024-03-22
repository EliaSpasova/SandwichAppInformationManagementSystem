using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichesDatabaseManagementProject
{
    public static class CurrentSandwichContext
    {
        public static currentSandwich CurrentSandwich { get; set; }
    }
    public class currentSandwich
    {
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Calories { get; set; }
        public string Allergens { get; set; }

        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
    public class DatabaseManagerForSandwich
    {
        public static currentSandwich cuurentSandwichMethod(string nameSandwich)
        {
            currentSandwich user = RetrieveSandwichInformation(nameSandwich); //encapsulation purposes
            return user;
        }

        internal static currentSandwich currentSandwichMethod(string? selectedSandwichName)
        {
            throw new NotImplementedException();
        }

        private static currentSandwich RetrieveSandwichInformation(string nameSandwich)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ELIASPASOVA\SQLEXPRESS; Initial Catalog=sandwiches; Integrated Security=True;"))
            {
                sqlCon.Open(); //maybe should close it after
                string Query = "SELECT COUNT(1) FROM sandwichInfo WHERE nameSandwich=@nameSandwich";
                string imgQuery = "SELECT * FROM sandwichInfo inner join sandwiches on sandwichInfo.nameSandwich=sandwiches.nameSandwich WHERE sandwichInfo.nameSandwich = @nameSandwich";

                //Usernasme
                //the @username refers to the 
                using (SqlCommand cmd = new SqlCommand(Query, sqlCon))
                {
                    using (SqlCommand imgCmd = new SqlCommand(imgQuery, sqlCon))
                    {
                        imgCmd.CommandType = CommandType.Text;
                        cmd.CommandType = CommandType.Text;


                        cmd.Parameters.AddWithValue("@nameSandwich", nameSandwich);

                        imgCmd.Parameters.AddWithValue("@nameSandwich", nameSandwich);

                        byte[] imageData;
                        string calories;
                        string allergens;
                        decimal price;
                        int amount;
                        using (SqlDataReader reader = imgCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                imageData = reader["imageSandwich"] as byte[];
                                calories = reader["calories"].ToString();
                                allergens = reader["allergens"].ToString();
                                price = Convert.ToDecimal(reader["price"]);
                                amount = Convert.ToInt32(reader["amount"]);
                                return new currentSandwich { Title = nameSandwich, Calories = calories, Image = imageData, Allergens = allergens, Price = price, Amount = amount };
                            }
                        }

                    }

                    return null;

                }
            }
        }
    }
}
