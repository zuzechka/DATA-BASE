namespace lab02
{
    internal class Student
    {
        public string StLastName { get; set; }
        public string StFirstName { get; set; }
        public int Grade { get; set; }
        public int Classroom { get; set; }
        public int Bus { get; set; }

        public override string ToString()
        {
            return $"Имя студента: {StLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {StFirstName}{Environment.NewLine}" +
                   $"Степень обучения: {Grade}{Environment.NewLine}" +
                   $"Номер класса: {Classroom}{Environment.NewLine}" +
                   $"Номер автобуса: {Bus}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;
        }

        public string ToStringStudent()
        {
            return $"Имя студента: {StLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {StFirstName}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;
        }

        public string ToStringBusStudent()
        {
            return $"Имя студента: {StFirstName}{Environment.NewLine}" +
                   $"Автобус: {Bus}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;
        }

        public string ToStringTeacher()
        {
            return $"Имя студента: {StLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {StFirstName}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;

        }

        public string ToStringStudentsBus()
        {
            return $"Имя студента: {StLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {StFirstName}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;
        }

        public string ToStrinStudentsGrade()
        {
            return $"Имя студента:{StLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {StFirstName}{Environment.NewLine}" +
                   "--------------------------------------" + Environment.NewLine;
        }
    }
}
