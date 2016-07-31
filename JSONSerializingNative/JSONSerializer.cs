// Made with ❤ in Berlin by Loek van den Ouweland
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JSONSerializingNative
{
    public class JSONSerializer<T>
    {
        public string Serialize(T o)
        {
            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(ms, o);
                var reader = new StreamReader(ms);
                ms.Position = 0;
                return reader.ReadToEnd();
            }
        }

        public T Deserialize(string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                var deserializer = new DataContractJsonSerializer(typeof(T));
                return (T)deserializer.ReadObject(ms);
            }
        }
    }
}
