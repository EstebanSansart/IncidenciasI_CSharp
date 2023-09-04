namespace Domain.Entities;
public class IncidenceDetail
{
    public string Description { get; set; }
    public int IdWorkToolFk { get; set; }
    public WorkTool WorkTool { get; set; }
}