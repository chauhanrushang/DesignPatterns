using Newtonsoft.Json;

namespace SolidPrinciples.OCP.Parsers
{
    public class JsonInputParser : InputParser
    {
        public override Document ParseInput(string input)
        {
            return JsonConvert.DeserializeObject<Document>(input);
        }
    }
}