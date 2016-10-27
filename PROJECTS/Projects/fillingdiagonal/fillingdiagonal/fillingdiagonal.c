#include<stdio.h>
#define TRUE 1

void fillMainDiagonalOFMatrixByValue(int mat[10][10], int order, int value);

int main()
{
	int i, j, mat[10][10];
	int order, value;
	do
	{
		printf("Enter the order of matrix:");
		scanf("%d", &order);
	} while (order<1 || order >10);
	printf("Enter the elements in the matrix:\n");
	for (i = 0; i<order; i++)
	{
		for (j = 0; j<order; j++)
		{
			printf("Enter element for matrix[%d][%d]:", i, j);
			scanf("%d", &mat[i][j]);
		}
	}
	printf("Enter the value to be inserted in the Leading(Main) Diagonal of matrix:");
	scanf("%d", &value);
	printf("The input matrix is: \n");
	for (i = 0; i<order; i++)
	{
		for (j = 0; j<order; j++)
		{
			printf("%d\t", mat[i][j]);
		}
		printf("\n");
	}

	fillMainDiagonalOFMatrixByValue(mat, order, value);
	printf("The matrix after filling the Leading(Main) Diagonal by %d is:\n", value);
	for (i = 0; i<order; i++)
	{
		for (j = 0; j<order; j++)
		{
			printf("%d\t", mat[i][j]);
			if (j == order - 1)
				printf("\n");
		}
	}
	system("PAUSE");
	return TRUE;
}
void fillMainDiagonalOFMatrixByValue(int mat[10][10], int order, int value)
{
	int i = 0;
	while (i <= 9)
	{
		mat[i][i] = value;
		i++;
	}
}