using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace ThemeFunctions.Json
{

	public class ThemeColorConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(string));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            List<ThemeColor> props = new List<ThemeColor>();

            if (token.Children().Any())
            {
                foreach (var child in token.Children())
                {
                    var val = child.ToString().Replace("\"",string.Empty);

                    var vals = val.Split(':', StringSplitOptions.TrimEntries);

                    props.Add(new ThemeColor
                    {
                        Name = vals[0],
                        HexColor = string.IsNullOrEmpty(vals[1]) ? null : vals[1].ToLower()
                    }) ; 
                }
            }

            return props;

        }


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is List<ThemeColor>)
            {                
                var tc = (List<ThemeColor>)value;

                var dict = tc.ToDictionary(keySelector: t => t.Name, elementSelector: t => t.HexColor);

                serializer.Serialize(writer, dict);

            }
            else
            {
                serializer.Serialize(writer, value);
            }
        }

        public override bool CanWrite
        {
            get { return true; }
        }
    }


}
