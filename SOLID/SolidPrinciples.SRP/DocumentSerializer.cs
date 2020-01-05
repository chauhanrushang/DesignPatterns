using Newtonsoft.Json;

namespace SolidPrinciples.SRP
{
    public class DocumentSerializer
    {
        public string Serialize(Document document)
        {
            return JsonConvert.SerializeObject(document);
        }
    }
}