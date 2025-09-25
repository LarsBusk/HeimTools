using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class NodeBase
    {
        public static string NodeSeparator;// = Properties.Settings.Default.NodeSeparator;
        public static string OpcNameSpace;// = Properties.Settings.Default.OpcNameSpace;

        public List<string> NodeTree = new List<string>();

        protected string FolderName;

        /// <summary>
        /// Returns a new opcnode
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="folder">The root folder of the node</param>
        /// <param name="name">The name of the node</param>
        /// <returns></returns>
        public OpcDataVariableNode<T> CreateOpcUaNode<T>(OpcFolderNode folder, string name)
        {
            return new OpcDataVariableNode<T>(folder, name, NodeId(name));
        }

        /// <summary>
        /// Returns a new opcnode and gives it a default value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="folder">The root folder of the node</param>
        /// <param name="name">The name of the node</param>
        /// <param name="value">Default value of the node</param>
        /// <returns></returns>
        public OpcDataVariableNode<T> CreateOpcUaNode<T>(OpcFolderNode folder, string name, T value)
        {
            return new OpcDataVariableNode<T>(folder, name, NodeId(name), value);
        }

        /// <summary>
        /// Returns a new opcnode and adds it to a list of nodes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="folder">The root folder of the node</param>
        /// <param name="name">The name of the node</param>
        /// <param name="nodeList">List of nodes to which the new node is added</param>
        /// <returns></returns>
        public OpcDataVariableNode<T> CreateOpcUaNode<T>(OpcFolderNode folder, string name, List<IOpcNode> nodeList)
        {
            var node = new OpcDataVariableNode<T>(folder, name, NodeId(name));
            nodeList.Add(node);
            return node;
        }

        public void SetNodeTree(OpcFolderNode parentFolder, string folderName)
        {
            NodeTree.AddRange(parentFolder.Id.ValueAsString.Split('/'));
            NodeTree.Add(folderName);
        }

        private OpcNodeId NodeId(string node)
        {
            List<string> nodeTree = new List<string>(NodeTree);
            nodeTree.Add(node);
            var homefolder = nodeTree[0];
            nodeTree.RemoveAt(0);
            string name = homefolder + string.Join(NodeSeparator, nodeTree);
            return $"ns={OpcNameSpace};s={name}";
        }
    }
}
