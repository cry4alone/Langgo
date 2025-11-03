namespace Langgo.Domain.Entities;

public class WordDictionary
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public List<WordPair> Entries { get; set; }
}