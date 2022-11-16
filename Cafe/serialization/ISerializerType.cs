using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public interface ISerializerType
    {

        void Serialize(Type type, ISerializable obj);

        ISerializable Deserialize(Type type, ISerializable obj);
    }
}
