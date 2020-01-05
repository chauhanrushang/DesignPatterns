namespace SolidPrinciples.DIP.ServiceLocator.DocStorage
{
    public interface IDocumentPersister
    {
        void PersistDocument(string serializedDocument, string targetFileName);
    }
}