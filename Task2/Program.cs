namespace Task2
{
    internal class Program
    {
        class Passport
        {
            public string PassportNumber { get; private set; }
            public string FullName { get; private set; }
            public DateTime IssueDate { get; private set; }
            public DateTime ExpiryDate { get; private set; }
            public string Nationality { get; private set; }

            public Passport(string passportNumber, string fullName, DateTime issueDate, DateTime expiryDate, string nationality)
            {
                if (string.IsNullOrWhiteSpace(passportNumber))
                    throw new ArgumentException("Номер паспорта не може бути пустим.");

                if (string.IsNullOrWhiteSpace(fullName))
                    throw new ArgumentException("ПІБ власника не може бути пустим.");

                if (issueDate >= expiryDate)
                    throw new ArgumentException("Дата видачі не може бути пізнішою або рівною даті закінчення.");

                if (string.IsNullOrWhiteSpace(nationality))
                    throw new ArgumentException("Національність не може бути пустою.");

                PassportNumber = passportNumber;
                FullName = fullName;
                IssueDate = issueDate;
                ExpiryDate = expiryDate;
                Nationality = nationality;
            }

            public override string ToString()
            {
                return $"Паспорт: {PassportNumber}\nВласник: {FullName}\nВиданий: {IssueDate.ToShortDateString()}\nДійсний до: {ExpiryDate.ToShortDateString()}\nНаціональність: {Nationality}";
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Passport passport = new Passport("AA1234567", "Name", new DateTime(2022, 5, 20), new DateTime(2032, 5, 20), "Україна");
                Console.WriteLine(passport);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
