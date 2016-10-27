#include<stdio.h>
#include<conio.h>
void move(int[][8], int, int);
void display(int[][8]);
void main()
{
	int m[8][8] = { 0 }, i, j;
	printf("\n enter the position i and j");
	scanf("%d%d", &i, &j);
	move(m, i, j);
	printf("\n the matrix is");
	system("PAUSE");
}
void move(int m[8][8], int i, int j)
{
	int a, b, k = 1;
	while ((i>=0) && (i<8) && (j>=0) && (j>8))
	{
		if ((i + 1) >= 0 && (j + 2) >= 0 && (i + 1) < 8 && (j + 2) < 8)
		{
			i = i + 1; j = j + 2;
			m[i][j] = k;
			k++;
			continue;

		}
		else if ((i + 1) >= 0 && (j - 2) >= 0 && (i + 1) < 8 && (j - 2) < 8)
		{
			i = i + 1; j = j - 2;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i - 1) >= 0 && (j + 2) >= 0 && (i - 1) < 8 && (j + 2) < 8)
		{

			i = i - 1; j = j + 2;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i - 1) >= 0 && (j - 2) >= 0 && (i - 1) < 8 && (j - 2) < 8)
		{

			i = a - 1; j = b - 2;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i + 2) >= 0 && (j + 1) >= 0 && (i + 2) < 8 && (j + 1) < 8)
		{

			i = i + 2; j = j + 1;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i + 2) >= 0 && (j - 1) >= 0 && (i + 2) < 8 && (j - 1) < 8)
		{

			i = i + 2; j = j - 1;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i - 2) >= 0 && (j + 1) >= 0 && (i - 2) < 8 && (j + 1) < 8)
		{

			i = i - 2; j = j + 1;
			m[i][j] = k;
			k++;
			continue;
		}
		else if ((i - 2) >= 0 && (j - 1) >= 0 && (i - 2) < 8 && (j - 1) < 8)
		{

			i = i - 2; j = j - 1;
			m[i][j] = k;
			k++;
			continue;
		}

	}
	display(m);
	
}
void display(int m[8][8])
{
	int p, q;
	printf("\n");
	for (p = 0; p<8; p++)
	{
		for (q = 0; q<8; q++)
		{
			printf("%d", m[p][q]);
			printf("\t");
		}
		printf("\n");
	}
}



