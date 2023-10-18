public class Word
{
    private string Text { get; set; }
    private bool Hidden { get; set; }

    // Constructor
    public Word(string text)
    {
        this.Hidden = false;
        this.Text = text;

    }

    // Behaviors
    public void Hide()
    {
        Hidden = true;
    }
    public void Show()
    {
        Hidden = false;
    }
    public bool IsHidden()
    {
        return Hidden;
    }
    public string GetRenderedText()
    {
        if (Hidden)
        {
            string hyphens = new('_', Text.Length);
            return hyphens;
        }
        else
        {
            return Text;
        }
    }
}