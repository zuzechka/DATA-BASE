using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace lab01
{
    public partial class MainForm : Form
    {
        private List<Student> _list;

        public MainForm()
        {
            InitializeComponent();
            _list = new List<Student>();
        }

        // загрузка данных из файла
        private void LoadStudentsFromFile()
        {
            try
            {
                string filePath = "D:\\projects\\database\\student.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("ОШИБКА! Файла не существует!");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("ОШИБКА! Невозможно считать данные, так как файл пуст");
                    return;
                }

                _list.Clear(); //очищаем список для того чтобы загрузить новые данные

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    //проверка на правильность данных
                    if (data.Length == 7)
                    {
                        Student student = new Student
                        {
                            StLastName = data[0].Trim(),
                            StFirstName = data[1].Trim(),
                            Grade = int.Parse(data[2].Trim()),
                            Classroom = int.Parse(data[3].Trim()),
                            Bus = int.Parse(data[4].Trim()),
                            TLastName = data[5].Trim(),
                            TFirstName = data[6].Trim()
                        };

                        _list.Add(student);
                    }
                    else
                    {
                        //пропуск строки с неверным форматом
                        MessageBox.Show("Пропущена строка с некорректным форматом данных: " + line);
                    }
                }

                statusStrip1.Items[1].Text = _list.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string StudentSurname = StSurname.Text.Trim();

            //пустой ввод проверка
            if (string.IsNullOrEmpty(StudentSurname))
            {
                MessageBox.Show("Введите фамилию студента!");
                return;
            }

            foreach (var item in _list)
            {
                if (item.StLastName.Equals(StudentSurname, StringComparison.OrdinalIgnoreCase))
                {
                    result.Text += item.ToStringStudentsTeacher();
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string StudentSurname = StSurname2.Text.Trim();

            if (string.IsNullOrEmpty(StudentSurname))
            {
                MessageBox.Show("Введите фамилию студента!");
                return;
            }

            foreach (var item in _list)
            {
                if (item.StLastName.Equals(StudentSurname, StringComparison.OrdinalIgnoreCase))
                {
                    result.Text += item.ToStringBusStudent();
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string TeacherSurname = TSurname.Text.Trim();

            if (string.IsNullOrEmpty(TeacherSurname))
            {
                MessageBox.Show("Введите фамилию преподавателя!");
                return;
            }

            foreach (var item in _list)
            {
                if (item.TLastName.Equals(TeacherSurname, StringComparison.OrdinalIgnoreCase))
                {
                    result.Text += item.ToStringTeacher();
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            if (!int.TryParse(BusNumber.Text.Trim(), out int BusNum))
            {
                MessageBox.Show("Введите допустимый номер автобуса!");
                return;
            }

            foreach (var item in _list)
            {
                if (item.Bus == BusNum)
                {
                    result.Text += item.ToStringStudentsBus();
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            if (!int.TryParse(GradeTB.Text.Trim(), out int Grade))
            {
                MessageBox.Show("Введите класс!");
                return;
            }

            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    result.Text += item.ToStrinStudentsGrade();
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsFromFile();
        }
    }
}
