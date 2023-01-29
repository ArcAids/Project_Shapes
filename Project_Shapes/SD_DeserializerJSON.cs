using System;
using System.Text.Json;

namespace Project_Shapes
{
    class SD_DeserializerJSON : SD_DeserializerBase, IDeserializeSD
    {
        public override ShapeData DeserializeString(string data)
        {
            try
            {
                ShapeData shapeData = JsonSerializer.Deserialize<ShapeData>(data);   //Deserializes Json to class object.
                return shapeData;
            }
            catch (Exception e)
            {
                Console.WriteLine("Json Deserialization Exception:" + e.ToString());
                throw e;
            }
            
        }
    }
}
