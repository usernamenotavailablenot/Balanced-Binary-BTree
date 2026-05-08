# Balanced-Binary-BTree
This is an implementation of Balanced Binary B Tree (B3 Tree), a hybrid of balanced binary search tree and B tree supporting fast search, insertion, and deletion. The idea is from B(+) tree. The lowest level of B(+) tree is a sorted linked list, and a sorted linked list is equivalent to a binary search tree (BST). Then, the lowest level of B(+) tree can be converted to a BST, and the upper levels, which serve as indexes can be discarded. The BST can be balanced by techniques like AVL tree or Red/Black tree. In this implementation, Left Leaning Red Black tree is adopted.

The B3 is similar to BST:
- Each node has exactly two children; 
- Balancing technique is the same.

The B3 is similar to B Tree: 
- Each node stores a collection of elements; 
- Collection has a lower and upper limit; 
- Insertion and deletion may involve node split and merge.

The advantages of B3: 
- more space efficient; 
- more cache friendly.

The run time complexity is obviously `Log(N)` for search, insertion, and deletion. For benchmarking, the attached unit test instantiates 128 B3 trees in a loop with different node capacity. Each B3 is then performed with 100,000 random insertions and deletions. The whole test took around 1 minute in my laptop with Intel(R) Core(TM) i7-3630QM CPU @ 2.40GHz and 8.00 GB Installed DDR3 RAM, which was purchased before 2014.

