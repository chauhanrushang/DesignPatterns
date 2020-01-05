namespace SolidPrinciples.DIP.IoCContainer.DocStorage
{
    public interface IDocumentPersister
    {
        void PersistDocument(string serializedDocument, string targetFileName);
    }
}