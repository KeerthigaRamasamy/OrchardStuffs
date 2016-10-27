#include <stdio.h>
#define TRUE 1

int calculateGCD(int x, int y);

int main(){
	int x, y;

	do{
		printf("Enter the values of x and y: ");
		scanf("%d %d", &x, &y);
	} while ((x <= 0) || (y <= 0));

	printf("The values of x and y are %d and %d\n", x, y);
	printf("The gcd is %d \n", calculateGCD(x, y));
	system("PAUSE");

	return TRUE;

}
int calculateGCD(int x, int y)
{
	if (x = 0)
	{
		return y;
	}
	else
	{
		calculateGCD(y / x, x);
	}


}