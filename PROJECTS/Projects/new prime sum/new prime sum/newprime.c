#include<stdio.h>
#include<conio.h>
void main()
{
	long int n,s;
	int i, j, k,m,c[50],b[50],a[50];
	printf("\n enter the value of n");
	scanf("%d", &n);
	printf("\nThe prime numbers till the number is");
	i = 2;
	s = 0;
	printf("%d\n", i);
	while (i < n)
	{
		j = 0;
		k = 0;
		for (c[j] < n)
		{
			if (!(c[j]%i == 0))
			{
				a[k] = c[j];
				b[k] = c[j];
				k++;
				a[k] = "\0";
				b[k] = "\0";	
			}
			j++;
		}
		i = a[0];
		for (m = 0; m < k; m++)
		{
			c[m] = b[m];
		}
		s = s + a[0];
		printf("\%d", a[o]);
		printf("\n");
	}
	getch();
}
