#include <stdio.h>
#define BOOLEAN int
#define TRUE 1
#define FALSE 0

BOOLEAN hasUniqueDigits(int d1, int d2, int d3, int d4);
//Returns TRUE if all digits are unique else FALSE

int main()
{
	int numb, d1, d2, d3, d4, savedNumb;

	scanf("%d", &numb);


	savedNumb = numb;
	d1 = numb % 10;
	numb = numb / 10;
	d2 = numb % 10;
	numb = numb / 10;
	d3 = numb % 10;
	numb = numb / 10;
	d4 = numb % 10;
	numb = numb / 10;

	if (hasUniqueDigits(d1, d2, d3, d4))
		printf("The Input 4-Digit Integer %d has Unique Digits\n", savedNumb);
	else
		printf("The Input 4-Digit Integer %d does not have Unique Digits\n", savedNumb);
	system("PAUSE");
}
BOOLEAN hasUniqueDigits(int d1, int d2, int d3, int d4)
{
	if (d1 != d2)
	{
		if (d1 != d3)
		{
			if (d1 != d4)
			{
				if (d2 != d3)
				{
					if (d2 != d4)
					{
						if (d3 != d4)
						{
							return TRUE;
						}
						else
							return FALSE;
					}
					else
						return FALSE;
				}
				else
					return FALSE;

			}
			else
				return FALSE;
		}
		else
			return FALSE;
	}
	else
	{
		return FALSE;
	}

}