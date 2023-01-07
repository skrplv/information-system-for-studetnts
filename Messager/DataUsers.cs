namespace DataUsers
{   
    // Данные о студенте
    public class DataStudent
    {
        public static string ID { get; set; }
        public static string UserID { get; set;}
        
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Patronymic { get; set; }
        public static string Course { get; set; }
        public static string Group { get; set; }
        public static string Phone { get; set; }
    }
   // Данные о пользователе
    public class DataUser
    {
        public static string ID { get; set; }
        public static string UserName { get; set; }
        public static string UserPassword { get; set; }               
    }
}
