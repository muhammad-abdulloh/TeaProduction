namespace TeaProduction.Domain.Entities
{
    public class Tea : Auditable
    {
        public string TeaName { get; set; }
        public string TeaType { get; set; }
        public string ProductionCountry { get; set; }
        public decimal TeaPrice { get; set; }
        public DateTimeOffset StartExpireDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset EndExpireDate { get; set; }

        public int MachineId { get; set; }

    }
}
