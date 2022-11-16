using System;
using System.IO;
using System.Xml.Serialization;

namespace Cafe
{
    public class XmlSerializerType : ISerializerType
    {
        private XmlSerializer serializer;

        public XmlSerializerType() { }

        public ISerializable Deserialize(Type type, ISerializable obj)
        {
            serializer = new XmlSerializer(type);
            try
            {
                using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Open))
                {
                    obj = (ISerializable)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public void Serialize(Type type, ISerializable obj)
        {
            serializer = new XmlSerializer(type);
            try
            {
                using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
