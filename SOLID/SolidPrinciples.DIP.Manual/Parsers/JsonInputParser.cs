﻿using Newtonsoft.Json;
using System;

namespace SolidPrinciples.DIP.Manual.Parsers
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