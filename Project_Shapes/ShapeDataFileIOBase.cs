using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Diagnostics;

namespace Project_Shapes
{
    class ShapeDataFileIOBase
    {
        public ShapeDataFileIOBase()
        {

        }
        public ShapeData ReadFile(string fileName)
        {
            Debug.Assert(fileName.Trim().Length > 0);

            string fileContent = File.ReadAllText(fileName);

            ShapeData shapeData = JsonSerializer.Deserialize<ShapeData>(fileContent);


            return shapeData;
        }

        public void WriteToFile(string fileName, ShapeData shapeData)
        {
            StringBuilder outputString = new StringBuilder();
            


        }
    }
}
