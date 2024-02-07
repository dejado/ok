using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuJinChemicalMES
{
    internal class ex
    {

        public void InsertData(string nickName, int score)
        {
            /*
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결
                //입력할 문자 받아옴
                if (CompareScore(nickName, score) == 0)
                    return;
                CompareNickName(nickName, score);

                string insertQuery = "INSERT INTO ranking(ranking, name, score, date)" +
                    " VALUES('" + CompareRank(score) + "','" + nickName + "','" +
                    score + "', now());";
                //문자열 insertQuery 변수 선언
                //MYSQL에 전송할 명령어를 입력한다.
                //실제로 MYSQL에 전송될 명령어는 ""사이의 값
                //RANK 스키마의 RANKING테이블에 값을 추가하기 위한 변수

                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                //MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                //MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 싣한다.
                //위 정보를 command 변수에 저장

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("연결완료");
                    connection.Close();
                    ShowGrid();

                }
                else
                {
                    MessageBox.Show("재확인 요망");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CompareNickName(string nickname, int score)
        {

            string cnn = "Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                string Query = "SELECT * from ranking";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if (nickname == reader["name"].ToString())
                    {
                        UpdateRank(GetRanking(nickname));
                        DeleteName(nickname);

                    }
                }
            }
        }

        public void DeleteName(string nickname)
        {
            string cnn = "Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                // SQL 서버와 연결, database=스키마 이름
                connection.Open();

                // 입력할 문자 받아옴
                string insertQuery = "DELETE FROM ranking WHERE name=@nickname";

                // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                // 위 정보를 command 변수에 저장
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@nickname", nickname);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetRanking(string nickname)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();
            string Query = "SELECT * from ranking WHERE name=@nickname";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.Parameters.AddWithValue("@nickname", nickname);
            MySqlDataReader reader = command.ExecuteReader();
            int ranking = 0;
            if (reader.Read())
            {
                ranking = reader.GetInt32(0);
            }
            return ranking;
        }

        public void UpdateRank(int rank)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();
            string Query = "SELECT * from ranking";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ranking = reader.GetInt32(0);
                if (rank < reader.GetInt32(0))
                {
                    ranking--;
                }
                ChangeRank(ranking, reader.GetInt32(2));
            }
            connection.Close();
        }
        public int CompareScore(string nickname, int score)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();
            string Query = "SELECT * from ranking WHERE name=@nickname";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.Parameters.AddWithValue("@nickname", nickname);
            MySqlDataReader reader = command.ExecuteReader();

            int checkNum = 0;
            if (reader.HasRows == false)
            {
                checkNum = 1;
            }
            else
            {
                if (reader.Read())
                {
                    if (score > reader.GetInt32(2))
                        checkNum = 1;
                }
            }
            return checkNum;
        }


        public int CompareRank(int score)
        {

            int ranking = 1;
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();
            string Query = "SELECT * from ranking";
            //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
            MySqlCommand command = new MySqlCommand(Query, connection);
            MySqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows == false)
            {
                ranking = 1;
            }
            else
            {
                while (reader.Read())
                {
                    int updateRanking = reader.GetInt32(0);
                    if (score <= reader.GetInt32(2))
                    {
                        ranking++;
                    }
                    else if (score > reader.GetInt32(2))
                    {
                        updateRanking++;
                    }
                    ChangeRank(updateRanking, reader.GetInt32(2));
                }

            }
            connection.Close();
            return ranking;

        }

        public void ChangeRank(int ranking, int score)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
            //SQL 서버와 연결, database=스키마 이름
            connection.Open();

            string update = string.Format("UPDATE ranking SET ranking= '{0}' WHERE score='{1}'", ranking, score);


            MySqlCommand command = new MySqlCommand(update, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void ShowGrid()
        {
            dataGridView1.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=rank;Uid=root;Pwd=programRobot128!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결

                string Query = "SELECT * from ranking ORDER BY ranking ASC";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["ranking"], reader["name"], reader["score"], reader["date"]);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            */
        }
    }

}
