/* Given a binary tree, print its nodes in inorder*/
	void imprimeEmOrdem(Node node)
	{
		if (node == null)
			return;

		/* first recur on left child */
		imprimeEmOrdem(node.left);

		/* then print the data of node */
		System.out.print(node.key + " ");

		/* now recur on right child */
		imprimeEmOrdem(node.right);
	}
