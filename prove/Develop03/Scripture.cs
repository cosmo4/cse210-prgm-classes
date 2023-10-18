using System;
using System.Collections.Generic;

public class Scripture
{
    // attributes
    private bool IsVisible;
    private string Reference;
    private List<Word> Words;
    private List<int> HiddenWordTracker;

    // Constructors
    public Scripture(string completeReference, List<Word> words)
    {
        this.Reference = completeReference;
        this.Words = words;
        this.IsVisible = true;
        this.HiddenWordTracker = new List<int>();
    }

    // Behaviors
    public void HideRandomWords(int count)
    {
        if (IsCompletelyHidden()) return;

        Random random = new Random();
        int wordsToHide = Math.Min(count, Words.Count - HiddenWordTracker.Count);

        while (wordsToHide > 0)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(Words.Count);
            } while (HiddenWordTracker.Contains(randomIndex));

            Words[randomIndex].Hide();
            HiddenWordTracker.Add(randomIndex);
            wordsToHide--;
        }
    }

    public void DisplayText()
    {
        Console.WriteLine($"Reference: {Reference}");
        foreach (Word word in Words)
        {
            Console.Write(word.GetRenderedText() + " ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        return HiddenWordTracker.Count == Words.Count;
    }
}