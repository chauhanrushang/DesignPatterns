namespace SolidPrinciples.ISP.DocStorage
{
    public interface IDocumentPersister
    {
        void PersistDocument(string serializedDocument, string targetFileName);
    }
}