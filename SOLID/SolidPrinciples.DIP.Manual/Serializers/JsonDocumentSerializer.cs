using Newtonsoft.Json;

namespace SolidPrinciples.DIP.Manual.Serializers
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            return JsonConvert.SerializeObject(document);
        }
    }
}