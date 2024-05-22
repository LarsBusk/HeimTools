using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePsc2KepserverCsvFiles
{
    public class CsvNodeFileCreator
    {
        private int stringAddress = 1;
        private int numberAddress = 1;

        public void CreateCsvFiles(IEnumerable<XmlNodeFileReader.OpcUaNodeContent> nodeContents, string fileName)
        {
            CreateCsvFile($"{fileName}KepServerStandard.csv", nodeContents, true);
            CreateCsvFile($"{fileName}KepServerMemoryBased.csv", nodeContents, false);
        }

        private void CreateCsvFile(string fileName, IEnumerable<XmlNodeFileReader.OpcUaNodeContent> nodeContents,
            bool isStandard)
        {
            CreateNewFile(fileName);
            var nodes = nodeContents.Select(n => CreateLine(n, isStandard));
            File.AppendAllLines(fileName, nodes);
        }

        private void CreateNewFile(string fileName)
        {
            var headers =
                "Tag Name,Address,Data Type,Respect Data Type,Client Access,Scan Rate,Scaling,Raw Low,Raw High,Scaled Low," +
                "Scaled High,Scaled Data Type,Clamp Low,Clamp High,Eng Units,Description,Negate Value\n";
            File.WriteAllText(fileName, headers);
        }

        private string CreateLine(XmlNodeFileReader.OpcUaNodeContent nodeContent, bool isStandard)
        {
            var nodeType = GetType(nodeContent.Type, nodeContent.IsArray);
            var nodeIdentifier = nodeContent.NodeIdentifier;
            var address = isStandard ? "?" : nodeContent.IsArray ? NextArrayAddress(nodeType, nodeContent.ArrayDimension) : NextAddress(nodeType);
            return $"\"{nodeIdentifier}\",\"{address}\",{nodeType},1,R/W,100,,,,,,,,,,\"\",";
        }

        private static string GetType(string typeName, bool isArray)
        {
            switch (typeName)
            {
                case "Int32":
                    return "Long";
                case "UInt32":
                    return isArray ? "DWordArray" : "DWord";
                case "UInt16":
                    return isArray ? "WordArray" : "Word";
                default:
                    return typeName;

            }
        }

        private string NextAddress(string type)
        {
            string address;

            switch (type)
            {
                case "String":
                    address = $"S{stringAddress:D5}";
                    stringAddress += 2;
                    break;
                case "Boolean":
                    address = $"D{numberAddress:D5}.1";
                    numberAddress += 2;
                    break;
                case "DateTime":
                    address = "?";
                    break;
                case "DWord":
                    address = $"D{numberAddress:D5}";
                    numberAddress += 4;
                    break;
                case "Long":
                    address = $"D{numberAddress:D5}";
                    numberAddress += 4;
                    break;
                case "Float":
                    address = $"D{numberAddress:D5}";
                    numberAddress += 4;
                    break;
                case "Double":
                    address = $"D{numberAddress:D5}";
                    numberAddress += 8;
                    break;
                default:
                    address = $"D{numberAddress:D5}";
                    numberAddress += 2;
                    break;
            }
            
            return address;
        }

        private string NextArrayAddress(string type, int dimension)
        {
            string address;

            switch (type)
            {
                case "String":
                    address = "?";
                    break;
                case "DWordArray":
                    address = $"D{numberAddress:D5}[{dimension}]";
                    numberAddress += 4 * dimension;
                    break;
                case "WordArray":
                    address = $"D{numberAddress:D5}[{dimension}]";
                    numberAddress += 2 * dimension;
                    break;
                default:
                    address = "?";
                    break;
            }

            return address;
        }
    }
}
