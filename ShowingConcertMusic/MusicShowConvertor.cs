﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    public class MusicShowConvertor : JsonConverter<CMusicShow>
    {
        public override CMusicShow Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDoc = JsonDocument.ParseValue(ref reader);

            try
            {
                
                string type = jsonDoc.RootElement.GetProperty("$type").GetString();

                switch (type)
                {
                    case "CDefaultMusicShow":
                        return JsonSerializer.Deserialize<CDefaultMusicShow>(jsonDoc.RootElement.GetRawText(), options);
                    case "CBalletOpera":
                        return JsonSerializer.Deserialize<CBalletOpera>(jsonDoc.RootElement.GetRawText(), options);
                    case "CRockConcert":
                        return JsonSerializer.Deserialize<CRockConcert>(jsonDoc.RootElement.GetRawText(), options);
                    default:
                        throw new NotSupportedException($"Unknown type: {type}");
                }
            }
            finally
            {
                jsonDoc.Dispose();
            }
        }

        public override void Write(Utf8JsonWriter writer, CMusicShow value, JsonSerializerOptions options)
        {
            string type = value.GetType().Name;

            string json = JsonSerializer.Serialize(value, value.GetType(), options);
            var jsonDoc = JsonDocument.Parse(json);

            try
            {
                writer.WriteStartObject();
                writer.WriteString("$type", type);

                foreach (var property in jsonDoc.RootElement.EnumerateObject())
                {
                    property.WriteTo(writer);
                }

                writer.WriteEndObject();
            }
            finally
            {
                jsonDoc.Dispose();
            }
        }
    }
}
