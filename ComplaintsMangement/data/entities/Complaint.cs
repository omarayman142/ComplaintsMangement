namespace ComplaintsMangement.data.entities
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        
        public Guid CreatorId { get; set; }
        
}
}
