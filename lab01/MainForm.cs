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

        // �������� ������ �� �����
        private void LoadStudentsFromFile()
        {
            try
            {
                string filePath = "D:\\projects\\database\\student.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("������! ����� �� ����������!");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("������! ���������� ������� ������, ��� ��� ���� ����");
                    return;
                }

                _list.Clear(); //������� ������ ��� ���� ����� ��������� ����� ������

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    //�������� �� ������������ ������
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
                        //������� ������ � �������� ��������
                        MessageBox.Show("��������� ������ � ������������ �������� ������: " + line);
                    }
                }

                statusStrip1.Items[1].Text = _list.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �������� ������: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string StudentSurname = StSurname.Text.Trim();

            //������ ���� ��������
            if (string.IsNullOrEmpty(StudentSurname))
            {
                MessageBox.Show("������� ������� ��������!");
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
                MessageBox.Show("���������� �� �������!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string StudentSurname = StSurname2.Text.Trim();

            if (string.IsNullOrEmpty(StudentSurname))
            {
                MessageBox.Show("������� ������� ��������!");
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
                MessageBox.Show("���������� �� �������!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            string TeacherSurname = TSurname.Text.Trim();

            if (string.IsNullOrEmpty(TeacherSurname))
            {
                MessageBox.Show("������� ������� �������������!");
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
                MessageBox.Show("���������� �� �������!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            if (!int.TryParse(BusNumber.Text.Trim(), out int BusNum))
            {
                MessageBox.Show("������� ���������� ����� ��������!");
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
                MessageBox.Show("���������� �� �������!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int counter = 0;
            if (!int.TryParse(GradeTB.Text.Trim(), out int Grade))
            {
                MessageBox.Show("������� �����!");
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
                MessageBox.Show("���������� �� �������!");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsFromFile();
        }
    }
}
