using MySql.Data.MySqlClient;
using System;

namespace SuJinChemicalMES
{
    public static class DataStorage
    {
        public static string ProductCode { get; set; }
        public static string ProductName { get; set; }

        public static void MinusMedicine(string name, string quantityToMinus)
        {
            string connectionString = "Server=10.10.32.82;Database=material;Uid=team;Pwd=team1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 데이터베이스에서 동일한 이름의 데이터가 이미 있는지 확인합니다.
                string selectQuery = $"SELECT * FROM medicine WHERE name = '{name}'";

                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 동일한 이름의 데이터가 이미 존재하면 수량(quantity)을 업데이트합니다.
                            string currentQuantity = reader.GetString("quantity");
                            int newQuantity = int.Parse(currentQuantity) - int.Parse(quantityToMinus);

                            reader.Close();
                            string updateQuery = $"UPDATE medicine SET quantity = '{newQuantity}' WHERE name = '{name}'";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                                Console.WriteLine("약품 수량이 수정되었습니다.");
                            }
                        }
                    }
                }
            }
        }
    }
}