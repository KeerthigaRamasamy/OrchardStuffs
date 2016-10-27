#include<stdio.h>
#define BOOLEAN int
#define TRUE 1
#define FALSE 0
#define MIN 1
#define MAX 50

BOOLEAN isUpperTriangular(int, int[MAX][MAX]);
// Returns TRUE if given matrix is Upper Triangular

int main()
{
	int mat[MAX][MAX], order, i, j;
	do{
		printf("Enter order of matrix between 1 and 50:\n");
		scanf("%d", &order);
	} while (order<MIN || order>MAX);

	for (i = 0; i<order; i++)
	{
		printf("\nEnter values for Row %d:\n", i + 1);
		for (j = 0; j<order; j++)
		{
			printf("\nEnter value for row %d col %d: ", i + 1, j + 1);
			scanf("%d", &mat[i][j]);
		}
	}
	printf("\nThe given matrix is:\n");
	for (i = 0; i<order; i++)
	{
		for (j = 0; j<order; j++)
		{
			printf("%d ", mat[i][j]);
		}
		printf("\n");
	}
	if (isUpperTriangular(order, mat))
		printf("\nGiven matrix is an Upper Triangular matrix\n");
	else
		printf("\nGiven matrix is not an Upper Triangular matrix\n");
	system("PAUSE");

	return TRUE;

} /* End of main function */
BOOLEAN isUpperTriangular(int order, int mat[MAX][MAX])
{
	int i, j, k = 0;
	while (k<order)
	{
		for (i = k + 1, j = k; i<order; i++)
		{
			if (mat[i][j] == 0)
				continue;
			else
				return FALSE;
		}
		k++;
	}
	return TRUE;
}