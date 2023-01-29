namespace Project_Shapes
{
    abstract class SD_DeserializerBase
    {
        //Future proofed for reading csv or any other format. Or I could just use an interface..
        public SD_DeserializerBase() { }
        abstract public ShapeData DeserializeString(string data);
    }

    //Or use this!!
    interface IDeserializeSD
    {
        public ShapeData DeserializeString(string data);
    }
}
