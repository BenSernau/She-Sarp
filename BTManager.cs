using System;

namespace TrinaryBees
{
	public class BTNode
	{
		public string nodeName;
		public BTNode leftNode;
		public BTNode rightNode;

		public BTNode()
		{
			nodeName = "root";
			leftNode = null;
			rightNode = null;
		}

		public BTNode(string nameToUse)
		{
			nodeName = nameToUse;
			leftNode = null;
			rightNode = null;
		}

		public BTNode getLeftNode()
		{
			return leftNode;
		}

		public BTNode getRightNode()
		{
			return rightNode;
		}

		public string getNodeName()
		{
			return nodeName;
		}

		public void setLeftNode(BTNode leftToGive)
		{
			leftNode = leftToGive;
		}

		public void setRightNode(BTNode rightToGive)
		{
			rightNode = rightToGive;
		}

		public void setName(string newName)
		{
			nodeName = newName;
		}
	}

	public class BinaryTree
	{
		public BTNode rootNode;

		public BinaryTree(string rootNodeName, string leftNodeName, string rightNodeName)
		{
			rootNode = new BTNode(rootNodeName);
			rootNode.setLeftNode(new BTNode(leftNodeName));
			rootNode.setRightNode(new BTNode(rightNodeName));
		}

		public void displayTree(BTNode nodePointer, BTNode parentNode)
		{
			if (nodePointer.getLeftNode() == null && nodePointer.getRightNode() == null)
			{
				if (parentNode == null)
				{
					Console.WriteLine(nodePointer.getNodeName());
				}

				else
				{
					Console.WriteLine(nodePointer.getNodeName() + " (parent node/biological child:) " + parentNode.getNodeName());
				}
				
				return;
			}

			else if (nodePointer.getLeftNode() == null)
			{
				if (parentNode == null)
				{
					Console.WriteLine(nodePointer.getNodeName());
				}

				else
				{
					Console.WriteLine(nodePointer.getNodeName() + " (parent node/biological child:) " + parentNode.getNodeName());
				}
				
				displayTree(nodePointer.getRightNode(), nodePointer);
			}

			else if (nodePointer.getRightNode() == null)
			{
				displayTree(nodePointer.getLeftNode(), nodePointer);

				if (parentNode == null)
				{
					Console.WriteLine(nodePointer.getNodeName());
				}

				else
				{
					Console.WriteLine(nodePointer.getNodeName() + " (parent node/biological child:) " + parentNode.getNodeName());
				}
			}

			else
			{	
				displayTree(nodePointer.getLeftNode(), nodePointer);

				if (parentNode == null)
				{
					Console.WriteLine("(root node:) " + nodePointer.getNodeName());
				}

				else
				{
					Console.WriteLine(nodePointer.getNodeName() + " (parent node/biological child:) " + parentNode.getNodeName());
				}

				displayTree(nodePointer.getRightNode(), nodePointer);
			}
		}		
	}

	public class BTManager
	{
		static BinaryTree theTree = new BinaryTree("Ben and Eliot", "Stephanie", "Ron");

		public static void Main(string[] args)
		{
			theTree.rootNode.getLeftNode().setLeftNode(new BTNode("Sally"));
			theTree.rootNode.getLeftNode().setRightNode(new BTNode("John"));
			theTree.rootNode.getRightNode().setLeftNode(new BTNode("Molly"));
			theTree.rootNode.getRightNode().setRightNode(new BTNode("Gerald"));
			theTree.rootNode.getRightNode().getRightNode().setRightNode(new BTNode("Geraldo de Riviera"));
			theTree.rootNode.getLeftNode().getLeftNode().setLeftNode(new BTNode("Aveline de Grandpre"));
			theTree.rootNode.getLeftNode().getRightNode().setLeftNode(new BTNode("Mortimette"));
			theTree.rootNode.getLeftNode().getRightNode().setRightNode(new BTNode("Richard"));
			theTree.displayTree(theTree.rootNode, null);
		}
	}
}