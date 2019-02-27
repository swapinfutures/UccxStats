using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UccxStats.AgentStats
{
    /// <inheritdoc />
    /// <summary>
    /// This Converter is used to handle JSON Attribute name changes between
    /// UCCX versions. The 'reasonCode' attribute was renamed to reason in
    /// later versions of UCCX.
    /// </summary>
    internal class VoiceCSQDetailConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass;
        }

        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var instance = objectType.GetConstructor(Type.EmptyTypes)?.Invoke(null);
            var properties = objectType.GetProperties();
            var jsonObject = JObject.Load(reader);

            foreach (var jproperty in jsonObject.Properties())
            {
                var name = jproperty.Name;
                if(string.Equals(name, "reasonCode", StringComparison.OrdinalIgnoreCase))
                {
                    name = "reason";
                }

                var property = properties.FirstOrDefault(pinfo =>
                    pinfo.CanWrite && string.Equals(pinfo.Name, name, StringComparison.OrdinalIgnoreCase));

                if (property != null)
                    property.SetValue(instance, jproperty.Value.ToObject(property.PropertyType, serializer));
            }
            return instance;
        }

        /// <inheritdoc />
        /// <summary>
        /// The current version of this application does not need this method but it is
        /// required by the interface. A Not Implemented Exception will be thrown.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
