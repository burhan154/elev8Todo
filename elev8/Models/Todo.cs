namespace elev8.Models
{
    public class Todo:IEntity
    {
        public int Id { get; set; }
        public required string Desc { get; set; }
        public bool IsComplete { get; set; }

    }
}
