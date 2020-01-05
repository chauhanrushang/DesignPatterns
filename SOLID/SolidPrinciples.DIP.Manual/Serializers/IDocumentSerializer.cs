namespace SolidPrinciples.DIP.Manual.Serializers
{
    public interface IDocumentSerializer
    {
        string Serialize(Document document);
    }
}