﻿using System;
using Newtonsoft.Json;

namespace SolidPrinciples.LSP.Parsers
{
    public class JsonInputParser : InputParser
    {
        public override Document ParseInput(string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<Document>(input);
            }
            catch (Exception)
            {
                return base.ParseInput(input);
            }
        }
    }
}