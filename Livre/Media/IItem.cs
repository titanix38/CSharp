namespace Livre.Media
{
    public interface IItem
    {
        int Id { get; set; }
        double Price { get; set; }
        string Title { get; set; }
    }
}