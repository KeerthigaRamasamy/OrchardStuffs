
#include<stdio.h>
void main()
{
	int a[100], n, i;
	printf("\n enter the number\n");
	scanf("%d", &n);
	for (i = 2; i < n/2; i++)
	{
		if (i != 1 && i != n)
		{
			if (n%i == 0)
			{
				printf("\n the number is not a prime number\n");
				
			}
			else
			{
				continue;
			}
		}
	}
	printf("\n the number is a prime number");
	
	system("PAUSE");

}