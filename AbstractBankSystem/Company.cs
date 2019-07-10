namespace AbstractBankSystem
{
    internal class Company : Customer
    {
        private string name;

        public Company(string name)
        {
            this.name = name;
            this.IsCompany = true;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
