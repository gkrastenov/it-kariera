namespace PreparationForExam4.Models.People
{
    public abstract class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set { AgeValidation(value); }
        }

        public string Name
        {
            get { return name; }
            set { NameValidation(value); }
        }

        public override string ToString()
        {
            return $"Name: {name}" + Environment.NewLine + $"Age: {age}";
        }

        private void NameValidation(string name)
        {
            if (name is null || name.Length < 3 || name.Length > 30)
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            this.name = name;
        }

        protected virtual void AgeValidation(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age should be 0 or positive!");
            this.age = age;
        }
    }
}