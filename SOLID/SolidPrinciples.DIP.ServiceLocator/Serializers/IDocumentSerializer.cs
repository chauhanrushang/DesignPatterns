namespace SolidPrinciples.DIP.ServiceLocator.Serializers
{
    public interface IDocumentSerializer
    {
        string Serialize(Document document);
    }
}