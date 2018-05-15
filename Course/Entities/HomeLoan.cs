namespace Course.Entities {
    class HomeLoan : IFundable, IPayable {

        public double BalanceDue { get; set; }

        public void loan(double amount) {
            BalanceDue += amount;
        }

        public void pay(double amount) {
            BalanceDue -= amount;
        }
    }
}
