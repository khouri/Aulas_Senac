/* Given a binary tree, print its nodes in preorder*/
	void imprimePreOrdem(Node node)
	{
		if (node == null)
			return;

		/* first print data of node */
		System.out.print(node.key + " ");

		/* then recur on left sutree */
		imprimePreOrdem(node.left);

		/* now recur on right subtree */
		imprimePreOrdem(node.right);
	}