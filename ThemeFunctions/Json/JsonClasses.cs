using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ThemeFunctions.Json
{
   
    // This is the class we write for "./themes/[themefile].json" 
    public class ColorTheme
    {

        public ColorTheme()
        {
            TokenColors = new List<TokenColor>();
            EnvironmentColors = new List<ThemeColor>();
        }

        [JsonProperty("name")]
        public string ThemeName { get; set; }

        [JsonProperty("$schema")]
        public string Schema { get; set; } = "vscode://schemas/color-theme";

        [JsonProperty("type")]
        public string ThemeType { get; set; } = "dark";

        [JsonProperty("colors")]
        [JsonConverter(typeof(ThemeColorConverter<ThemeColor>))]
        public List<ThemeColor> EnvironmentColors { get; set; }
                
        [JsonProperty("tokenColors")]
        public List<TokenColor> TokenColors { get; set; }
        
        public void SetTokenNullNames()
        {
            var num = 1;

            foreach (var tk in TokenColors)
            {
                if (String.IsNullOrEmpty(tk.Name))
                {
                    tk.Name = $"token{num}";
                    num++;
                }
            }
        }

    }

    public class ThemeColor
    {

        public ThemeColor()
        {

        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hexColor")]
        public string HexColor { get; set; }

        public override string ToString()
        {
            return $"{Name}:{HexColor}";
        }
    }

    public class TokenColor
    {

        public TokenColor()
        {
            Settings = new TokenSettings();
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scope")]
        [JsonConverter(typeof(SingleOrArrayConverter<String>))]
        public List<string> Scope { get; set; }

        [JsonProperty("settings")]
        public TokenSettings Settings { get; set; }

    }


    public class TokenSettings
    {

        // Hex Color
        [JsonProperty("foreground")]
        public string Foreground { get; set; }

        // Hex Color
        [JsonProperty("background")]
        public string Background { get; set; }

        // 'italic' or 'bold'
        [JsonProperty("fontStyle")]
        public string FontStyle { get; set; }
    }

    // This is the class we write for the "~company-aplication-version/package.json"
    public class ColorPackage
    {

        public ColorPackage()
        {

            publisher = "";
            engines = new Engines() { vscode = "^1.0.0" };
            categories = new List<string>() { "Themes" };
            contributes = new Contributes();

        }

        public string name { get; set; }

        public string displayName { get; set; }

        public string publisher { get; set; }
               
        public Version version { get; set; } = new Version(1, 0, 0);

        public Engines engines { get; set; }

        public List<string> categories { get; set; }

        public Contributes contributes { get; set; }
    }

    public class Engines
    {
        public string vscode { get; set; }

    }

    public class Contributes
    {
        public Contributes()
        {
            themes = new List<TitleTheme>();
        }

        public List<TitleTheme> themes { get; set; }
    }


    public class TitleTheme
    {
        public string label { get; set; }
        public string uiTheme { get; set; }
        public string path { get; set; }
    }


    public class EditorToken
    {
        public EditorToken()
        { }

        public string name { get; set; }

        public List<String> scope { get; set; }

        public string fontStyle { get; set; }

        public string foreground { get; set; }

        public string background { get; set; }
    }
}


