using eTakeoff.Domain;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace SerializerTest
{
    public class JSONStringWriter : RStrmOut
    {
        private JsonTextWriter _writer;
        private StringBuilder _sb;

        public JSONStringWriter()
        {
            _sb = new StringBuilder();
            StringWriter sw = new StringWriter(_sb);
            _writer = new JsonTextWriter(sw);
        }

        public override void ObjectBegin(string name)
        {
            if (!string.IsNullOrEmpty(name))
                _writer.WritePropertyName(name);
            _writer.WriteStartObject();
        }

        public override void ObjectEnd()
        {
            _writer.WriteEndObject();
        }

        public override void WriteBoolean(string name, bool data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteDateTime(string name, DateTime? data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteDouble(string name, double data, int numberOfDecimalPoints)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteIdent(string name, string data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteInteger(string name, int data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteString(string name, string data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public override void WriteToken(string name, string data)
        {
            _writer.WritePropertyName(name);
            _writer.WriteValue(data);
        }

        public string GetText()
        {
            return _sb.ToString().Trim();
        }
    }
}
