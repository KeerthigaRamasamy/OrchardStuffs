#include<stdio.h>
#define EVEN 0
#define ODD 1
#define TRUE 1

int frequencyCountOfNumbers(int mat[100][100], int nrows, int ncols, int flag);
// mat[][] is the array
//nrows is number of rows, ncols is number of columns
// flag is 0 implies frequency of even numbers returns
// flag is 1 implies frequency of odd numbers returns

int main()
{
	int nrows, ncols, temp;
	int i, j, matrix[100][100];

	printf("Enter the number of rows in matrix  : ");
	scanf("%d", &nrows);
	printf("Enter the number of columns in matrix : ");
	scanf("%d", &ncols);
	printf("Enter the elements in the matrix:\n");
	for (i = 0; i<nrows; i++)
	{
		for (j = 0; j<ncols; j++)
		{
			printf("Enter the element in matrix [%d][%d] : ", i, j);
			scanf("%d", &matrix[i][j]);
			printf("\n");
		}
	}



	printf("\nFrequency of even numbers = %d", frequencyCountOfNumbers(matrix, nrows, ncols, EVEN));
	printf("\n");
	printf("\nFrequency of odd numbers= %d", frequencyCountOfNumbers(matrix, nrows, ncols, ODD));
	return TRUE;
	system("PAUSE");
}
int frequencyCountOfNumbers(int mat[100][100], int nrows, int ncols, int flag)
{
	int i, j, even = 0, odd = 0;
	for (i = 0; i<nrows; i++)
	{
		for (j = 0; j<ncols; j++)
		{
			if (mat[i][j] % 2 == 0)
			{
				even++;
			}
			else
			{
				odd++;
			}
		}
	}
	if (flag ==0)
		return even;
	else
		return odd;


}