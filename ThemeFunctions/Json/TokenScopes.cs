using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ThemeFunctions.Json
{
    public class TokenScopes
    {
        public TokenScopes()
        {
            Languages = new List<SyntaxLanguage>();

            Syntaxes = new List<SyntaxScope>();

        }
                
        [JsonProperty("syntaxes")]
        public List<SyntaxScope> Syntaxes { get; set; }

        [JsonProperty("languages")]
        public List<SyntaxLanguage> Languages { get; set; }
     
        public List<string> ScopeList()
        {
            return Syntaxes.Select(s => s.Name).ToList();
        }

    }

    public class SyntaxLanguage
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class SyntaxScope
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}

   







