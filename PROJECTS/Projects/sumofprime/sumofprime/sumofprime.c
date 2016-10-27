#include<stdio.h>
#include<conio.h>
#define MAX 100000
void main()
{
	unsigned long n,sum;
	int i, j, k = 0, a[MAX],l;
	printf("\n enter the max value\n");
	scanf("%d", &n);
	for (j = 2;j < n; j++)
	{
			while(i <= j / 2)
			{
				if ((j != i))
				{
					if (!(j%i == 0))
					{
						a[k] = j;
						k++;
						a[k] = "\0";
					}
				}
				i++;
			}
	}
	for (i = 0; i < MAX; i++)
	{
		if (a[i] == "\0")
		{
			l = i;
		}
	}
	for (j = 0; j < l; j++)
	{
		sum = sum + a[j];
	}
	getch();
	
}