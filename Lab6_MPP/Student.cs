namespace Lab6_MPP
{
    public class Student
    {
        private string name;
        private byte age;
        private byte course;
        private string faculty;
        private string speciality;
        private bool isPaid;

        public Student(string name, byte age, byte course, string faculty, string speciality, bool isPaid)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.faculty = faculty;
            this.speciality = speciality;
            this.isPaid = isPaid;
        }

        public string GetInfo()
        {
            return "Имя: " + name + "\n" + "Возраст: " + age + "\n" + "Курс: " + course + "\n" + "Факультет: " + faculty + "\n" +
                "Специальность: " + speciality + "\n" + "Основа: " + (isPaid ? "Платная":"Бюджет") + "\n";
        }
    }
}
