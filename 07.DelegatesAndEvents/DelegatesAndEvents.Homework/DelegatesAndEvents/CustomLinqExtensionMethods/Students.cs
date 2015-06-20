namespace CustomLinqExtensionMethods
{
    class Students
    {
        private string name;
        private int grade;

        public Students(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public int Grade { get; set; }
    }
}