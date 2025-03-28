namespace TaskManager;

public class Item
{
    public int Id { get; set; }
    public string Task { get; set; } = "";
    public bool IsComplete { get; set; } = false;
    public List<CheckboxItem> Categories { get; set; } = [];  
}