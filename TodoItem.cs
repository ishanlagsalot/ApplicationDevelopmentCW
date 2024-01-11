namespace ApplicationDevelopmentCW;

public class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; }

    // for second todo
    public TodoItem(string text)
    {
        Text = text;
    }
    public string Text { get; set; }
    public bool Completed { get; set; }
}
