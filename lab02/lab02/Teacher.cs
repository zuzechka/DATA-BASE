namespace lab02
{
    internal class Teacher
    {
        public string TLastName { get; set; }
        public string TFirstName { get; set; }
        public int Classroom { get; set; }

        public override string ToString()
        {
            return $"Номер класса: {Classroom}{Environment.NewLine}" +
                   $"Имя преподавателя: {TLastName}{Environment.NewLine}" +
                   $"Фамилия преподавателя: {TFirstName}{Environment.NewLine}";
        }


        public string ToStringTeacher()
        {
            return $"Имя преподавателя: {TLastName}{Environment.NewLine}" +
                   $"Фамилия студента: {TFirstName}{Environment.NewLine}";

        }

    }
}

