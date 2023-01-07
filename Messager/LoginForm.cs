using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataUsers;
using Authorization;


namespace Messager
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        private void Enterbutton_Click(object sender, EventArgs e)
        {
            // Получение введенных данных
            string email = LoginField.Text;
            string password = PasswordField.Text;
            //Проверка корректности введенных данных
            if (email == "" && password != "")
            {
                MessageBox.Show("Введите логин!");
            }
            else if (email != "" && password == "")
            {
                MessageBox.Show("Введите пароль!");
            }
            else if (email == "" && password == "")
            {
                MessageBox.Show("Введите логин и пароль!");
            }
            else
            {
                // Вызов метода авторизации
                LoginClass logIn = new LoginClass();
                logIn.Login(email, password);                
                // Проверка успешности авторизации
                if (logIn.isSuccesful)
                {
                   // Присвоение данных
                    DataUser.UserName = email;
                    DataUser.UserPassword = password;
                   // Открытие формы студента
                    StudMainForm studForm = new StudMainForm();
                    studForm.Show();
                    // Скрытие текущей формы
                    Hide();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы
            Close();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
      
        }
    }
                
}
