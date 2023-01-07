using System;
using MaterialSkin;
using MaterialSkin.Controls;
using DataUsers;
using System.Windows.Forms;
using Authorization;

namespace Messager
{
    public partial class StudMainForm : MaterialForm
    {
        public StudMainForm()
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
        private void StudMainForm_Load(object sender, EventArgs e)
        {
            // Получение данных страницы            
            GetStudentInfoClass a = new GetStudentInfoClass();
            a.GetStudentInfo(DataUser.ID);
            // Проверка успешности полученных данных
            if (a.isSucsessful)
            {
                // Присвоение полученных данных
                userNameLabel.Text = DataUser.UserName;
                FIOlabel.Text = DataStudent.FirstName + " " + DataStudent.LastName + " " + DataStudent.Patronymic;
                phoneLabel.Text = DataStudent.Phone;
                groupLabel.Text = DataStudent.Group;
                courseLabel.Text = DataStudent.Course;
            }
            else
            {
                MessageBox.Show("Студент не найден");
            }
            
        }

        private void ReLogin_Click_1(object sender, EventArgs e)
        {           
            // Открытие формы авторизации
            LoginForm f1 = new LoginForm();
            f1.Show();
            // Закрытие данной формы
            Close();

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы
            Close();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Открытие формы редактирования данных
            EditStudentDataForm studEditForm = new EditStudentDataForm();
            studEditForm.Show();
            // Закрытие данной формы
            Close();
        }
    }
}

