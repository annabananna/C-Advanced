namespace Models4
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public string BatchNumber { get; set; }

        public virtual string PrintVehicle()
        {
            return $"{Id}. {Type} [{YearOfProduction}]";
        }
    }
}