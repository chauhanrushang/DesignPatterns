namespace SolidPrinciples.LSP.Serializers
{
    public interface IDocumentSerializer
    {
        string Serialize(Document document);
    }
}