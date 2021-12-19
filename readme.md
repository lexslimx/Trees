Binary Tree
Tree for which every node has at most 2 child nodes.

Binary Search Trees
Invariant: For every node x the values in the left subtree are less or equal to x and the nodes in the right subtrees are greater or equal to x, x being the root.

Storing Rooted Trees
Always maintain a pointer to the root.Each node has access to all of its children. Maintain a pointer to the parent node to make reverse traversal easy. - this isn't necessary thanks to recursive calls.

It can thus be represented as an array. This also works for n-array trees. The root is always index 0. For the children:
left child = 2i+1
right child = 2i+2
parent = Floor((i-1)/2)


