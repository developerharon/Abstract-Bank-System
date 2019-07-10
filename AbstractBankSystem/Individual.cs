namespace AbstractBankSystem
{
    internal class Individual: Customer
    {
        private string firstName;
        private string lastName;

        public Individual(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.IsCompany = false;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
