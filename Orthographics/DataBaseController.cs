using Orthographics.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    internal class DataBaseController
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrthographicsDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30";
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
                reader.Read();
                long result = reader.GetInt64(0);
                connection.Close();
                return result;
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
                        reader.GetString(1), reader.GetString(2), reader.GetDouble(3)));
                }
            }
            connection.Close();
            return questionList;
        }

        /// <summary>
        /// Получение теории по id вопроса.
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public static Theory GetTheoryByQuestion(long questionId)
        {
            Theory theory = null;
            string query = "SELECT TheoryID, Chapter, Path FROM [Theory] " +
                           "INNER JOIN [TheoryQuestions] " +
                           "ON Theory.TheoryID = TheoryQuestions.Theory " +
                           "WHERE Question = @questionId";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("questionId", questionId);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                theory = new Theory(reader.GetInt64(0), reader.GetString(1), reader.GetString(2));
            }
            connection.Close();
            return theory;
        }

        public static List<Theory> GetAllTheory()
        {
            var list = new List<Theory>();
            string query = "SELECT TheoryID, Chapter, Path FROM [Theory]";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new Theory(reader.GetInt64(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            connection.Close();
            return list;
        }

        public static long GetLastUserQuestion(long userId)
        {
            connection.Open();
            string query = "SELECT TOP(1) Question FROM [Game] " +
                           "WHERE User = @userId " +
                           "ORDER BY [Date] Desc";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("userId", userId);
            object question = command.ExecuteScalar();
            long questionId = question == null ? 1 : (long)question;
            connection.Close();
            return questionId;
        }

        /// <summary>
        /// Получение следующих вопросов пользователя.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<Question> GetNextUserQuestions(long userId, long theoryId)
        {
            connection.Open();
            List<Question> questionList = new List<Question>();

            string nextQuestionsQuery = "SELECT QuestionID, Type, ISNULL(Image, ''), Rank FROM [Question] " +
                                        "INNER JOIN [TheoryQuestions] " +
                                        "ON Question.QuestionId = TheoryQuestions.Question " +
                                        "WHERE Theory = @theoryId " +
                                        "AND QuestionID NOT IN ( " +
                                        "   SELECT Question FROM [Game] " +
                                        "   WHERE [User] = @userId " +
                                        ")";

            string getAnswersQuery = "SELECT AnswerID, Text, IsCorrect, [Index] FROM Answer " +
                                     "INNER JOIN [Question] " +
                                     "ON Answer.Question = Question.QuestionID " +
                                     "WHERE QuestionID = @questionId";
            string getQuestionItemsQuery = "SELECT ItemID, [Text], [Index] FROM QuestionItem " +
                                           "INNER JOIN [Question] " +
                                           "ON QuestionItem.Question = Question.QuestionID " +
                                           "WHERE QuestionID = @questionId";

            SqlCommand nextQuestionsCommand = connection.CreateCommand();
            nextQuestionsCommand.CommandText = nextQuestionsQuery;
            nextQuestionsCommand.Parameters.AddWithValue("theoryId", theoryId);
            nextQuestionsCommand.Parameters.AddWithValue("userId", userId);
            SqlDataReader reader = nextQuestionsCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Question question = new Question(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));

                    SqlCommand getAnswersCommand = connection.CreateCommand();
                    getAnswersCommand.CommandText = getAnswersQuery;
                    getAnswersCommand.Parameters.AddWithValue("questionId", question.QuestionId);
                    SqlDataReader answerReader = getAnswersCommand.ExecuteReader();

                    while (answerReader.Read())
                    {
                        question.Answers.Add(new Answer(answerReader.GetInt64(0), answerReader.GetString(1), answerReader.GetBoolean(2), answerReader.GetInt32(3)));
                    }
                    answerReader.Close();

                    SqlCommand getQuestionItemsCommand = connection.CreateCommand();
                    getQuestionItemsCommand.CommandText = getQuestionItemsQuery;
                    getQuestionItemsCommand.Parameters.AddWithValue("questionId", question.QuestionId);
                    SqlDataReader questionsReader = getQuestionItemsCommand.ExecuteReader();

                    while (questionsReader.Read())
                    {
                        question.Items.Add(new QuestionItem(questionsReader.GetInt64(0), questionsReader.GetString(1), questionsReader.GetInt32(2)));
                    }
                    questionsReader.Close();

                    questionList.Add(question);
                }
            }
            reader.Close();
            connection.Close();
            return questionList;
        }

        public static void AddUserAnswer(long userId, long questionId, double score)
        {
            connection.Open();
            string query = "INSERT INTO [Game] VALUES (@userId, @questionId, @score, @date)";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("userId", userId);
            command.Parameters.AddWithValue("questionId", questionId);
            command.Parameters.AddWithValue("score", score);
            command.Parameters.AddWithValue("date", DateTime.Now);
            command.ExecuteNonQuery();
        }

        public static double GetRate(long userId)
        {
            connection.Open();
            string query = "SELECT ISNULL(SUM([Score]), 0) FROM [Game] " +
                           "WHERE [User] = @userId";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("userId", userId);
            object rate = command.ExecuteScalar();
            connection.Close();
            return Convert.ToDouble(rate);
        }

        public static string GetUserLogin(long userId)
        {
            connection.Open();
            string query = "SELECT [Login] FROM [User] " +
                           "WHERE [UserID] = @userId";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("userId", userId);
            object login = command.ExecuteScalar();
            connection.Close();
            return Convert.ToString(login);
        }

    }
}
