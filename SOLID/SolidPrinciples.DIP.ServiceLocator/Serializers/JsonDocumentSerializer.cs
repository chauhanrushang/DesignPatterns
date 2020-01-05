using Newtonsoft.Json;

namespace SolidPrinciples.DIP.ServiceLocator.Serializers
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            return JsonConvert.SerializeObject(document);
        }
    }
}