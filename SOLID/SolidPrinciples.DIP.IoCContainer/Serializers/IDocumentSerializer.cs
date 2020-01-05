namespace SolidPrinciples.DIP.IoCContainer.Serializers
{
    public interface IDocumentSerializer
    {
        string Serialize(Document document);
    }
}