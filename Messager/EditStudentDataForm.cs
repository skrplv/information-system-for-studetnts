using MaterialSkin;
using MaterialSkin.Controls;
using DataUsers;
using System.Windows.Forms;

namespace Messager
{
    public partial class EditStudentDataForm : MaterialForm
    {        
            public EditStudentDataForm()
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

        private void EditStudentDataForm_Load(object sender, System.EventArgs e)
        {
           //Загрузка данных страницы
            userNameLabel.Text = DataUser.UserName;
            FirstNameTextBox.Text = DataStudent.FirstName;
            LastNameTextBox.Text = DataStudent.LastName;
            PatronymicTextBox.Text = DataStudent.Patronymic;
            PhoneTextBox.Text = DataStudent.Phone;
            GroupTextBox.Text = DataStudent.Group;
            CourseTextBox.Text = DataStudent.Course;                   
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
           // Проверка введения новых данных
            if (FirstNameTextBox.Text == DataStudent.FirstName && LastNameTextBox.Text == DataStudent.LastName && PatronymicTextBox.Text == DataStudent.Patronymic && PhoneTextBox.Text == DataStudent.Phone)
            {
                MessageBox.Show("Внесите изменения");
            }            
            else
            {
                // Внесение изменений
                UpdateUserClass updateUser = new UpdateUserClass();
                updateUser.UpdateData(FirstNameTextBox.Text, LastNameTextBox.Text, PatronymicTextBox.Text, PhoneTextBox.Text/*,GroupTextBox.Text,CourseTextBox.Text*/);
                //Проверка успешности изменений данных
                if (updateUser.isSuccesful == true)
                {
                    MessageBox.Show("Изменения успешно сохранены");
                    // Открытие формы студента
                    StudMainForm studForm = new StudMainForm();
                    studForm.Show();
                    // Закрытие текущей формы
                    Close();
                }
                else
                {
                    MessageBox.Show("Операция не выполнена");
                }
            }                        
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            // Открытие формы студента
            StudMainForm studForm = new StudMainForm();
            studForm.Show();
            // Закрытие текущей формы
            Close();
        }
    }
}
