using Authorization;
using ConnectionDB;
using DataUsers;
using System;
using System.Data.SqlClient;

namespace Messager
{
    public class UpdateUserClass
    {
        public bool isSuccesful; 
       // Метод обновление данных
        public void UpdateData(string first_name,string last_name, string patronymic, string phone/*, string group,string course*/)
        {
            DBConnectionClass db = new DBConnectionClass();
            db.OpenConnection();
            try
            {
                var command = new SqlCommand("UPDATE students SET first_name = @first_name, last_name = @last_name, patronymic = @patronymic, phone = @phone WHERE user_id= @userId", db.GetConnection());
                command.Parameters.AddWithValue("@userId", DataUser.ID);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                command.Parameters.AddWithValue("@patronymic", patronymic);
                command.Parameters.AddWithValue("@phone", phone);            
                SqlDataReader sqlRead = command.ExecuteReader();
                isSuccesful = true;
               // Обновление данных в DataUsers
                DataStudent.FirstName = first_name;
                DataStudent.LastName = last_name;
                DataStudent.Patronymic = patronymic;
                DataStudent.Phone = phone;
                // Получение обновленных данных о студенте
                GetStudentInfoClass a = new GetStudentInfoClass();
                a.GetStudentInfo(DataUser.ID);                                                                           
            }

            catch (Exception ex)
            {
                _ = ex.Message;
                 isSuccesful = false;
            }
            db.CloseConnection();
        }      
        
    }
}
