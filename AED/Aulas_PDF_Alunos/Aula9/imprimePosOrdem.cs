	/* Given a binary tree, print its nodes in postorder*/
	void imprimePosOrdem(Node node)
	{
		if (node == null)
			return;

		// first recur on left subtree
		imprimePosOrdem(node.left);

		// then recur on right subtree
		imprimePosOrdem(node.right);

		// now deal with the node
		System.out.print(node.key + " ");
	}