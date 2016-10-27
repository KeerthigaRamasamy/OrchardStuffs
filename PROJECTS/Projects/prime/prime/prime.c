#include <stdio.h>
#define TRUE 1
#define FALSE 0
#define BOOLEAN int

BOOLEAN isPrime(int n);
//Returns TRUE if n is Prime else returns FALSE

int main()
{
	int  numb;
	BOOLEAN isPrimeNumb;

	printf("Enter a positive integer:\n");
	scanf("%d", &numb);

	isPrimeNumb = isPrime(numb);
	if (isPrimeNumb == TRUE)
		printf("%d is a prime number\n", numb);

	else
		printf("%d is not a prime number\n", numb);


	return TRUE;
	getch();

}
BOOLEAN isPrime(int n)
{
	int i,flag=0;
	if (n == 2)
	{
		flag = 0;
	}
	else if (n == 1)
	{
		flag = 1;
	}
	else
	{
		for (i = 2; i < n; i++)
		{
				if (n%i == 0)
				{
					flag = 1;
					break;
				}
		}
	}
	if (flag == 0)
		return TRUE;
	else
		return FALSE;

}