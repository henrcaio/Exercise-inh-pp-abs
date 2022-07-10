namespace Exercise_inh_pp_abs.Entities {
    class Individual : Taxpayer {
        public double HealthExpenses { get; set; }
        double tax;

        public Individual(string name, double annualIncome, double healthExpenses) : base(name, annualIncome) {
            HealthExpenses = healthExpenses;
        }

        public override double Tax() {
            if (AnnualIncome < 20000) {
                tax = (AnnualIncome * 0.15);
                if (HealthExpenses > 0) {
                    tax = tax - (HealthExpenses / 2);
                }

            } else if (AnnualIncome >= 20000) {
                tax = (AnnualIncome * 0.25);
                if (HealthExpenses > 0) {
                    tax = tax - (HealthExpenses / 2);
                }
            }

            return tax;
        }

        public override string taxes() {
            return base.taxes();
        }
    }
}
