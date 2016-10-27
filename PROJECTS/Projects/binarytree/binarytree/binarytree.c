#include<stdio.h>
#include<stdlib.h>
struct node
{
	struct node*left;
	struct node*right;
	int key;

};
struct node *newnode(int item)
{
	struct node *temp =(struct node *)malloc(sizeof(struct node));
	temp->key = item;
	temp->left = NULL;
	temp->right = NULL;
	return temp;
}
struct node* insert(struct node*node,int key)
{
	if (node == NULL)
	{
		return newnode(key);
	}
	else if (node->key > key)
	{
		node->left=insert(node->left, key);
	}
	else if (node->key < key)
	{
		node->right=insert(node->right, key);
	}
	return node;
}
void inorder(struct node* root)
{
	if (root!= NULL)
	{
		printf("%d", root->key);
		inorder(root->left);
		inorder(root->right);
	}
}
int search(struct node*root, int k)
{
	if (root->key == k)
		return 1;
	else
	{
		search(root->left, k);
	}
}
void main()
{
	int k,b;
	struct node* root =NULL;
	root=insert(root, 8);
    insert(root, 5);
	insert(root, 2);
	insert(root, 7);
	insert(root, 9);
	inorder(root);
	printf("\n enter the key\n");
	scanf("%d", &k);
	b = search(root, k);
	if (root == 1)
	{
		printf("\n the key is found");
	}
	else
	{
		printf("\n the key is not found");
	}
}