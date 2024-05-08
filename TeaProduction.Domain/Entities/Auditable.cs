namespace TeaProduction.Domain.Entities
{
    public class Auditable
    {
        public int Id { get; set; }

        public Boolean IsDeleted { get; set; } = false;
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset ModifyDate { get; set; }
        public DateTimeOffset DeletedDate { get; set; }
    }
}
