using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    internal class DataBaseController
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrthographicsDB.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static long Authorize(string login, string password)
        {
            string query = "SELECT * FROM [User] WHERE Login=@login AND Password=@password";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("login", login);
            command.Parameters.AddWithValue("password", password);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                connection.Close();
                return reader.GetInt64(0);
            }
            connection.Close();
            return -1;
        }

        /// <summary>
        /// Получение вопросов по id теории. 
        /// </summary>
        /// <param name="theoryId"></param>
        /// <returns></returns>
        public static List<Question> GetTheoryQuestions(long theoryId)
        {
            List<Question> questionList = new List<Question>();

            string query = "SELECT QuestionID, Type, Image, Rank FROM [Question] " +
                           "INNER JOIN [TheoryQuestion] " +
                           "ON Question.QuestionId = TheoryQuestion.Question " +
                           "WHERE Theory = @theoryId";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("theoryId", theoryId);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    questionList.Add(new Question(reader.GetInt64(0),
                        reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            connection.Close();
            return questionList;
        }

        /// <summary>
        /// Получение id теории по id вопроса.
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public static long GetTheoryByQuestion(long questionId)
        {
            string query = "SELECT Theory FROM [TheoryQuestion] " +
                           "WHERE Question = @questionId";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            long id = (long)command.ExecuteScalar();
            return id;
        }

        /// <summary>
        /// Получение следующего вопроса пользователя.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static long GetNextUserQuestion(long userId)
        {
            string query = "SELECT Question, MAX([Date]) FROM [Game] " +
                           "WHERE User = @userId " +
                           "GROUP BY Question";
            // TODO: Под вопросом!
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;


            return -1;
        }

        /**
         *  1. 
         *  
         */

    }
}
