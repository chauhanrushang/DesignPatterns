namespace SolidPrinciples.DIP.Manual.DocStorage
{
    public interface IDocumentPersister
    {
        void PersistDocument(string serializedDocument, string targetFileName);
    }
}