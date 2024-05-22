using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class RejectorNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<bool> Active;
        public OpcDataVariableNode<byte[]> RejectedImageJPG;
        private readonly OpcFolderNode rejectorFolder;
        private List<IOpcNode> nodes = new List<IOpcNode>();

        public RejectorNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Rejector";
            rejectorFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        public void GetNodes()
        {
            Active = CreateOpcUaNode<bool>(rejectorFolder, "Active", nodes);
            RejectedImageJPG = CreateOpcUaNode<byte[]>(rejectorFolder, "RejectedImageJPG", nodes);
        }
    }
}
