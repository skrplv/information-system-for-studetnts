using System;
using System.Data.SqlClient;
using DataUsers;
using ConnectionDB;

namespace Authorization
{
    public class LoginClass
    {
        public bool isSuccesful;
        // метод авторизации
        public void Login(string userName, string userPassword)
        {
            DBConnectionClass db = new DBConnectionClass();
            db.OpenConnection();
            var command = new SqlCommand("Select id From users where user_name = @login and user_password = @password", db.GetConnection());
            command.Parameters.AddWithValue("@login", userName);
            command.Parameters.AddWithValue("@password", userPassword);
            try
            {
                SqlDataReader sqlRead = command.ExecuteReader();
                if (sqlRead.Read())
                {
                    isSuccesful = true;
                    // Запись считанных данных
                    DataUser.ID = sqlRead[0].ToString();                    
                }
                else
                {
                    isSuccesful = false;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                isSuccesful = false;
            }
            db.CloseConnection();
        }
    }
    // метод получения данных о студенте
    public class GetStudentInfoClass  
    {
        public bool isSucsessful;
        public void GetStudentInfo(string UserID)
        {            
            DBConnectionClass db = new DBConnectionClass();
            db.OpenConnection();
            var command = new SqlCommand("Select * From students WHERE user_id=@UserID", db.GetConnection());
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                SqlDataReader sqlRead = command.ExecuteReader();               
                // Проверка успешности считывания данных
                if (sqlRead.Read())
                {
                    isSucsessful = true;
                    // Запись данных
                    DataStudent.FirstName = sqlRead[2].ToString();
                    DataStudent.LastName = sqlRead[3].ToString();
                    DataStudent.Patronymic = sqlRead[4].ToString();
                    DataStudent.Course = sqlRead[5].ToString();
                    DataStudent.Phone = sqlRead[6].ToString();
                    DataStudent.Group = sqlRead[7].ToString();
                }
                else
                {
                    isSucsessful=false;
                    Console.WriteLine("Студент не найден!");
                }
            }
            catch (NullReferenceException ex)
            {
                isSucsessful = false;
                _ = ex.Message;
            }
            db.CloseConnection();
        }
    }
}



