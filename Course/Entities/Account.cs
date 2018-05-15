namespace Course.Entities {
    class Account : IAccount, IFundable {

        public int Number { get; set; }
        public double Balance { get; set; }

        public void deposit(double amount) {
            Balance += amount;
        }

        public void loan(double amount) {
            Balance += amount;
        }

        public void withdraw(double amount) {
            Balance -= amount;
        }
    }
}
