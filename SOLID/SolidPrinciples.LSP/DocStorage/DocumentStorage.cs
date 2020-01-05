namespace SolidPrinciples.LSP.DocStorage
{
    public abstract class DocumentStorage
    {
        public abstract string GetData(string fileName);
        public abstract void PersistDocument(string serializedDocument, string targetFileName);
    }
}
