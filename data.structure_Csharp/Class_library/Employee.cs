namespace Class_library
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public Date BornDate { get; set; } = null!;
        public Date? HireDate { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{LastName}\n\t" +
                   $"Hire.................: {BornDate}";
        }

        public abstract decimal GetValueToPay();
    }
}