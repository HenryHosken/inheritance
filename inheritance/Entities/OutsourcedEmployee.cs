namespace inheritance.Entities
{
    internal class OutsourcedEmployee : Empeloyee
    {
        public double additionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }
    }
}
