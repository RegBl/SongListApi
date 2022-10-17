namespace SongListApi.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Key { get; set; }
    public string? BPM { get; set; }
    public string? Lyrics { get; set; }
    public string? AdditionalInfo { get; set; }
}