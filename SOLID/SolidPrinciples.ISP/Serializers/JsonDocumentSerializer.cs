using Newtonsoft.Json;

namespace SolidPrinciples.ISP.Serializers
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serialize(Document document)
        {
            return JsonConvert.SerializeObject(document);
        }
    }
}