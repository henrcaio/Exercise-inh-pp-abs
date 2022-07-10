namespace Exercise_inh_pp_abs.Entities {
    abstract class Taxpayer {
        
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer(string name, double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public virtual string taxes() {
            return Name
                + ": US$"
                + Tax().ToString("F2");
        }
    }
}
