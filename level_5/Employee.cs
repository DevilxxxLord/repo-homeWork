using System;

namespace Level_5
{
    class Employee
    {
        public string FIO { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public Employee(string FIO, string Positon, string Email, string Number, int Salary, int Age)
        {
            this.FIO = FIO;
            this.Position = Position;
            this.Email = Email;
            this.Number = Number;
            this.Salary = Salary;
            this.Age = Age;
        }
        public string Info()
        {
            return
                this.FIO + ", " +
                this.Position + ". Email: " +
                this.Email + ". Phone number: " +
                this.Number + ", " +
                this.Salary + ", " +
                this.Age;
        }
    }
}
