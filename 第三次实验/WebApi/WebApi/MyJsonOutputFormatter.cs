using Microsoft.AspNetCore.Mvc.Formatters.Json.Internal;
using Newtonsoft.Json;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class MyJsonOutputFormatter : Microsoft.AspNetCore.Mvc.Formatters.JsonOutputFormatter
    {
        public MyJsonOutputFormatter(JsonSerializerSettings serializerSettings) : base(serializerSettings, ArrayPool<char>.Shared) { }
        public new JsonSerializerSettings SerializerSettings => base.SerializerSettings;
        protected override JsonWriter CreateJsonWriter(TextWriter writer) {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }
            var jsonWriter = new NullJsonWriter(writer)
            {
                ArrayPool = new JsonArrayPool<char>(ArrayPool<char>.Shared),
                CloseOutput = false, AutoCompleteOnClose = false
            };
            return jsonWriter;
        }
    }
    public class NullJsonWriter : JsonTextWriter {
        public NullJsonWriter(TextWriter textWriter) : base(textWriter)
        { }
        public override void WriteNull()
        {
            this.WriteValue(String.Empty);
        }
    }

}
