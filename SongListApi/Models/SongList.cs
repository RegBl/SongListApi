namespace SongListApi.Models;

public class SongList
{
    public int Id { get; set; }
    public List<Song> Songs { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
}