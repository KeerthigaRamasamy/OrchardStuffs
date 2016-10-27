#include <stdio.h>
#include <stdlib.h>
#define MAX 10
#define BOOLEAN int
#define TRUE 1
#define FALSE 0

void sortAscending(int[][MAX], int, int);
void sortDescending(int[][MAX], int, int);
void rearrangeMatrix(int[][MAX], int);

void main() {
	int mat[MAX][MAX];
	int order;
	int i = 0, j = 0;

	//Reading the order of the matrix from the user.
	printf("Enter Order of the Matrix : ");
	do{
		scanf("%d", &order);
	} while (order <= 0);

	//Reading elements of the matrix from the user.
	for (i = 0; i < order; i++)
	for (j = 0; j < order; j++)
		scanf("%d", &mat[i][j]);

	//Displaying the matrix input.
	printf("\nInput Matrix : \n");
	for (i = 0; i < order; i++) {
		for (j = 0; j < order; j++)
			printf("%d\t", mat[i][j]);
		printf("\n");
	}

	//Rearranging the matrix.
	rearrangeMatrix(mat, order);

	//Displaying the rearranged matrix.
	printf("\nRearranged Matrix : \n");
	for (i = 0; i < order; i++) {
		for (j = 0; j < order; j++)
			printf("%d\t", mat[i][j]);
		printf("\n");
	}
	system("PAUSE");
}
void rearrangeMatrix(int input[][MAX], int order)
{

}
void sortAscending(int input[][MAX], int order, int rowIndex)
{
	int k = 0, i, j, a[MAX], p, q;
	for (i = rowIndex, j = 0; j<order; j++)
	{
		a[k] = input[i][j];
		k = k + 1;
	}
	a[k] = NULL;
	for (p = 0; p<k - 1; p++)
	{
		for (q = 0; q<k; q++)
		{
			if (a[q + 1]<a[q])
			{
				int temp;
				temp = a[q + 1];
				a[q + 1] = a[q];
				a[q] = temp;
			}
		}
	}
	k = 0;
	for (i = rowIndex, j = 0; j<order; j++)
	{
		input[i][j] = a[k];
		k = k + 1;
	}
}
void sortDescending(int input[][MAX], int order, int rowIndex)
{
	int k = 0, i, j, a[MAX], p, q;
	for (i = rowIndex, j = 0; j<order; j++)
	{
		a[k] = input[i][j];
		k = k + 1;
	}
	a[k] = NULL;
	for (p = 0; p<k - 1; p++)
	{
		for (q = 0; q<k; q++)
		{
			if (a[q + 1]>a[q])
			{
				int temp;
				temp = a[q + 1];
				a[q + 1] = a[q];
				a[q] = temp;
			}
		}
	}
	k = 0;
	for (i = rowIndex, j = 0; j<order; j++)
	{
		input[i][j] = a[k];
		k = k + 1;
	}
}