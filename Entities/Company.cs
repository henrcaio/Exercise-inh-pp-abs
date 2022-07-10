namespace Exercise_inh_pp_abs.Entities {
    class Company : Taxpayer {
        public int NumberOfEmployees { get; set; }
        double tax;

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (NumberOfEmployees > 10) {
                tax = (AnnualIncome * 0.14);

            } else {
                tax = (AnnualIncome * 0.16);
            }

            return tax;
        }

        public override string taxes() {
            return base.taxes();
        }
    }
}
