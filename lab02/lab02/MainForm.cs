using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace lab02
{
    public partial class MainForm : Form
    {
        private List<Student> _list;
        private List<Teacher> _list1;

        public MainForm()
        {
            InitializeComponent();
            _list = new List<Student>();
            _list1 = new List<Teacher>();
        }

        // загрузка данных из файла про студентов
        private void LoadStudentsFromFile()
        {
            Stopwatch time = new Stopwatch(); //òàéìåð
            time.Start(); //ïî÷àòîê â³äë³êó ÷àñó
            try
            {
                string filePath1 = "D:\\projects\\database\\list.txt";

                if (!File.Exists(filePath1))
                {
                    MessageBox.Show("ОШИБКА! Файла не существует!");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath1);

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
                    if (data.Length == 5)
                    {
                        Student student = new Student
                        {
                            StLastName = data[0].Trim(),
                            StFirstName = data[1].Trim(),
                            Grade = int.Parse(data[2].Trim()),
                            Classroom = int.Parse(data[3].Trim()),
                            Bus = int.Parse(data[4].Trim()),
                        };

                        _list.Add(student);
                    }
                    else
                    {
                        //пропуск строки с неверным форматом
                        MessageBox.Show("Пропущена строка с некорректным форматом данных: " + line);
                    }
                }

                string filePath2 = "D:\\projects\\database\\teachers.txt";

                if (!File.Exists(filePath2))
                {
                    MessageBox.Show("ОШИБКА! Файла не существует!");
                    return;
                }

                string[] lines1 = File.ReadAllLines(filePath2);

                if (lines1.Length == 0)
                {
                    MessageBox.Show("ОШИБКА! Невозможно считать данные, так как файл пуст");
                    return;
                }

                _list1.Clear(); //очищаем список для того чтобы загрузить новые данные

                foreach (string line1 in lines1)
                {
                    string[] data1 = line1.Split(',');

                    //проверка на правильность данных
                    if (data1.Length == 3)
                    {
                        Teacher teacher = new Teacher
                        {
                            TLastName = data1[0].Trim(),
                            TFirstName = data1[1].Trim(),
                            Classroom = int.Parse(data1[2].Trim()),
                        };

                        _list1.Add(teacher);
                    }
                    else
                    {
                        //пропуск строки с неверным форматом
                        MessageBox.Show("Пропущена строка с некорректным форматом данных: " + line1);
                    }

                }
                time.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }

            statusStrip1.Items[1].Text = Convert.ToString(time.Elapsed);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            string StudentSurname = StSurname.Text.Trim();

            if (string.IsNullOrEmpty(StudentSurname))
            {
                result.Text = "Введите фамилию студента!";
                return;
            }

            StringBuilder resultText = new StringBuilder();
            Stopwatch time = new Stopwatch();
            time.Start();

            bool foundStudent = false;

            foreach (var item in _list)
            {
                if (item.StLastName == StudentSurname)
                {
                    resultText.Append(item.ToStringStudent());

                    //проверка есть ли учитель у студента
                    bool foundTeacher = false;
                    foreach (var item2 in _list1)
                    {
                        if (item2.Classroom == item.Classroom)
                        {
                            resultText.Append("  " + item2.ToStringTeacher());
                            foundTeacher = true;
                        }
                    }

                    if (!foundTeacher)
                    {
                        resultText.Append("Нет преподавателя для для этого класса!");
                    }

                    resultText.Append("__________________________________" + Environment.NewLine);
                    foundStudent = true;
                }
            }

            time.Stop();

            if (!foundStudent)
            {
                resultText.Append("Студент с фамилией " + StudentSurname + " не найден");
            }

            resultText.Append("Время работы: " + time.Elapsed.TotalMilliseconds.ToString("0.###") + " мс");
            result.Text = resultText.ToString();
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

            StringBuilder resultText = new StringBuilder();
            Stopwatch time = new Stopwatch();
            time.Start();

            foreach (var item in _list)
            {
                if (item.StLastName.Equals(StudentSurname, StringComparison.OrdinalIgnoreCase))
                {
                    resultText.Append(item.ToStringBusStudent());
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            time.Stop();

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }

            resultText.Append("Время работы: " + time.Elapsed.TotalMilliseconds.ToString("0.###") + " мс");
            result.Text = resultText.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = "";
            string TeacherSurname = TSurname.Text.Trim();

            if (string.IsNullOrEmpty(TeacherSurname))
            {
                MessageBox.Show("Введите фамилию учителя!");
                return;
            }

            StringBuilder resultText = new StringBuilder();
            Stopwatch time = new Stopwatch();
            time.Start();

            bool foundTeacher = false;

            foreach (var item in _list1)
            {
                if (item.TLastName == TeacherSurname)
                {
                    resultText.Append(item.ToStringTeacher());

                    //проверяем студентво у єтого учителя
                    bool foundStudent = false;
                    foreach (var item2 in _list)
                    {
                        if (item.Classroom == item2.Classroom)
                        {
                            resultText.Append("  " + item2.ToStringStudent());
                            foundStudent = true;
                        }
                    }

                    if (!foundStudent)
                    {
                        resultText.Append("Нет студентов для этого учителя!");
                    }

                    resultText.Append("________________________________" + Environment.NewLine);
                    foundTeacher = true;
                }
            }

            time.Stop();

            if (!foundTeacher)
            {
                resultText.Append("Учитель с фамилией " + TeacherSurname + " не найден!");
            }

            resultText.Append("Время работы: " + time.Elapsed.TotalMilliseconds.ToString("0.###") + " мс");
            result.Text = resultText.ToString();
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

            StringBuilder resultText = new StringBuilder();
            Stopwatch time = new Stopwatch();
            time.Start();

            foreach (var item in _list)
            {
                if (item.Bus == BusNum)
                {
                    resultText.Append(item.ToStringStudentsBus());
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            time.Stop();

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }

            resultText.Append("Время работы: " + time.Elapsed.TotalMilliseconds.ToString("0.###") + " мс");
            result.Text = resultText.ToString();
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

            StringBuilder resultText = new StringBuilder();
            Stopwatch time = new Stopwatch();
            time.Start();

            foreach (var item in _list)
            {
                if (item.Grade == Grade)
                {
                    resultText.Append(item.ToStrinStudentsGrade());
                    counter++;
                }

                if (counter >= 100)
                    break;
            }

            time.Stop();

            if (counter == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }

            resultText.Append("Время работы: " + time.Elapsed.TotalMilliseconds.ToString("0.###") + " мс");
            result.Text = resultText.ToString();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsFromFile();
        }
    }
}
