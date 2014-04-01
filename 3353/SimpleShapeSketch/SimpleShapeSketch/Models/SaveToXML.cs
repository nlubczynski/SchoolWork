using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace SimpleShapeSketch
{
    public static class XmlTools
    {
        public static string ToXmlString<T>(this T input)
        {
            using (var writer = new MemoryStream())
            {
                input.ToXml(writer);
                return Convert.ToBase64String(writer.ToArray());
            }
        }
        public static T FromXmlString<T>(string input)
        {
            byte[] b = Convert.FromBase64String(input);
            using(var stream = new MemoryStream(b))
            {
                var formatter = new BinaryFormatter();
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
        public static void ToXml<T>(this T objectToSerialize, Stream stream)
        {
            new BinaryFormatter().Serialize(stream, objectToSerialize);
        }

        public static void ToXml<T>(this T objectToSerialize, MemoryStream writer)
        {
            new BinaryFormatter().Serialize(writer, objectToSerialize);
        }
    }
}