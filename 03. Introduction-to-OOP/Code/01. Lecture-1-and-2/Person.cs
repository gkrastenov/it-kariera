namespace Demo
{
    public class Person // наследява system.object
    {
        // fields
        private int age; // 0
        private string name; // null
        private bool flag;

        // предефиниране на default constructor       
        public Person() : this(10, "Pesho")
        {

        }


        public Person(int age, string name) // конструктор по подразбиране/parameterized constructor
        {
            this.Age = age;
            this.Name = name;
        }

        public Person(int age)
        {
            this.Age = age;
            this.Name = "";
        }

        /*
        public Person(Person person) // copy constructor
        {

        }*/

        public int Age
        {
            get { return CalculateAge(); }
            set { IsValidAge(value); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Не се използва често
        // В c++ / java се използва постоянно
        public bool GetFlag()
        {
            return flag;
        }

        public void SetFlag(bool flag)
        {
            this.flag = flag;
        }

        // Propery Age -> age (age е privete тоест скрито от външния свят)
        // propfull + tab + tabl -> изкарва ви field с property
        // ctor + tab + tab -> създава ми constructor

        public override string ToString()
        {
            return $"Name: {this.name} and age: {this.age}";
        }

        private void IsValidAge(int age)
        {
            if (age < 0)
            {
                this.age = 0; // or throw exeption
            }
            else
            {
                this.age = age;
            }
        }

        private int CalculateAge()
        {
            return this.age * 7;
        }
    }
}