#include <stdio.h>
#define TRUE 1
#define FALSE 0

int reduceToSingle(int numb);
int main()
{
	int numb;
	do {
		printf("Enter a Positive Number: ");
		scanf("%d", &numb);
	} while (!(numb > 0));

	printf("Original = %d Single digit = %d\n", numb, reduceToSingle(numb));
	system("PAUSE");
	return TRUE;
}
int reduceToSingle(int numb)
{
	static int sum = 0;
	int r;
	while (numb != 0)
	{
		r = numb % 10;
		sum = sum + r;
		numb = numb / 10;
	}
	if(sum/10==0)
	{
		return sum;
	}
	else
	{
		reduceToSingle(sum);
	}


}