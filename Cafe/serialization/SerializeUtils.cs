using System;

namespace Cafe
{
    public class SerializeUtils
    {
        public static void Serialize(ISerializerType serializer, Type type, ISerializable obj)
        {
            serializer.Serialize(type, obj);
        }

        public static ISerializable Deserialize(ISerializerType serializer, Type type, ISerializable obj)
        {
            return serializer.Deserialize(type, obj);
        }

    }
}
