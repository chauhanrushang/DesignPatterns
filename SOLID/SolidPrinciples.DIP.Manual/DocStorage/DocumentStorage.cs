namespace SolidPrinciples.DIP.Manual.DocStorage
{
    public abstract class DocumentStorage : IInputRetriever, IDocumentPersister
    {
        public abstract string GetData(string fileName);
        public abstract void PersistDocument(string serializedDocument, string targetFileName);
    }
}
