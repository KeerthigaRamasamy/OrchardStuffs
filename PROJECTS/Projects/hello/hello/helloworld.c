#include <stdio.h>
#define TRUE 1

int sumSeries(int n);        //Returns Sum of n terms of series

int main()
{
	int n;


	do
	{
		printf("Enter a positive integer: \n");
		scanf("%d", &n);
	} while (!(n>0 && n<10000));


	printf("The sum of  the series 1+3+5+... upto  %d terms is %d\n", n, sumSeries(n));
	system("PAUSE");

	return TRUE;

}
int sumSeries(int n)
{
	int a = 0, i = 0;
	while (i<n)
	{
		static j = 1;
		a = a + j;
		j = j + 2;
		i++;
	}
	return a;
}