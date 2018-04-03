using eTakeoff.Domain;
using Newtonsoft.Json;
using System;
using System.IO;

namespace SerializerTest
{
    public class JSONStringReader : RStrmIn
    {
        private JsonTextReader _reader;
        private JsonToken _tokenType;

        public JSONStringReader(string json)
        {
            _reader = new JsonTextReader(new StringReader(json));
        }

        public override int GetPropertyId(RKwdMap map)
        {
            return map.GetId(_reader.Value == null ? string.Empty : _reader.Value.ToString());
        }

        public override bool MoveNext()
        {
            var result = _reader.Read();
            _tokenType = _reader.TokenType;
            if (result && (_reader.TokenType == JsonToken.StartObject))
            {
                result = _reader.Read();
                _tokenType = _reader.TokenType;
            }
            if (_reader.TokenType == JsonToken.EndObject)
                return false;

            return result;
        }

        public override bool ReadBoolean()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            bool result = false;
            if (_reader.Value != null && !string.IsNullOrEmpty(_reader.Value.ToString()))
                result = Boolean.Parse(_reader.Value.ToString());
            return result;
        }

        public override DateTime? ReadDateTime()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            return DateTime.Now;
        }

        public override double ReadDouble()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            double result = 0.0;
            if (_reader.Value != null && !string.IsNullOrEmpty(_reader.Value.ToString()))
                result = Convert.ToDouble(_reader.Value.ToString());
            return result;
        }

        public override string ReadIdent()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            string result = "";
            return result;
        }

        public override int ReadInteger()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            int result = 0;
            if (_reader.Value != null && !string.IsNullOrEmpty(_reader.Value.ToString()))
                result = Convert.ToInt32(_reader.Value.ToString());
            return result;
        }

        public override string ReadString()
        {
            if (_tokenType == JsonToken.PropertyName)
            {
                _reader.Read();
                _tokenType = _reader.TokenType;
            }
            string result = string.Empty;
            if (_reader.Value != null && !string.IsNullOrEmpty(_reader.Value.ToString()))
                result = _reader.Value.ToString();
            return result;
        }
    }
}
