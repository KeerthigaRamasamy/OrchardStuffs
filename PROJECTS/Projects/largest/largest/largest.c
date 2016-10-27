#include<stdio.h>
#define TRUE 1

int maximumOfFourNumbers(int arr[4]);

int main()
{
	int num1, num2, num3, num4, max;
	int arr[4], i;
	for (i = 1; i <= 4; i++)
	{
		printf("\nEnter integer %d:", i);
		scanf("%d", &arr[i - 1]);
	}
	max = maximumOfFourNumbers(arr);
	printf("\nMaximum of four Integer is %d", max);
	return TRUE;
	system("PAUSE");
}
int maximumOfFourNumbers(int arr[4])
{
	int i, j, temp;
	for (i = 0; i<3; i++)
	{
		for (j = 0; j<3; j++)
		{
			if (arr[i + 1]>arr[i])
			{
				temp = arr[i + 1];
				arr[i + 1] = arr[i];
				arr[i] = temp;
			}
		}
	}
	return arr[0];

}