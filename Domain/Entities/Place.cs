namespace Domain.Entities;
public class Place
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int IdAreaFk { get; set; }
    public Area Area { get; set; }
}
