namespace SolidPrinciples.DIP.ServiceLocator.DocStorage
{
    public interface IInputRetriever
    {
        string GetData(string fileName);
    }
}