using System.Diagnostics;

namespace Project_Shapes
{
    class ShapesCalculatinator
    {
        private const string inputFileName = "../../../../Shapes-49464.json";
        private const string outputFileName = "../../../../Shapes-Result.csv";

        //Could take the input and output names as args.
        public void DoTheThing()
        {
            string fileData = FileIO.ReadFile(inputFileName);

            //It would be easy to automate check on file extension and choose either Json or csv(Doesn't exist yet) Deserializer accordingly.
            IDeserializeSD dataFileIO = new SD_DeserializerJSON();
            var data = dataFileIO.DeserializeString(fileData);

            Debug.Assert(data != null, "Couldn't read the file specified.");

            FileIO.WriteFile(outputFileName, data.GetAreaAndPerimiterString());
        }
    }
}
