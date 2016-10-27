#include<stdio.h>
#include<string.h>
#include<conio.h>
void main()
{
	char k[50], p[50];
	char a[26] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
	int n[26] = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
	int l1,m, l2,sum=0,i,j,f;
	printf("\n enter the password\n");
	gets(p);
	printf("\n enter the key value\n");
	gets(k);
	l1 = strlen(p);
	l2 = strlen(k);
	for (j = 0; j < l2; j++)
	{
		for (i = 0; i < 26; i++)
		{
			if (k[j] == a[i])
			{
				k[j] = i;
			}
		}
	}
	for (i = 0; i < l2; i++)
	{
		sum = sum + k[i];
	}
	printf("\nThe sum of the letters in the key value is%d", sum);
	f = sum % 26;
	printf("\n the f value is%d", f);
	for (j = 0; j < l1; j++)
	{
		for (i = 0; i < 26; i++)
		{
			if (p[j] == a[i])
			{
				if ((i + f) < 26)
					p[j] = i + f;
				else
					p[j] = (i + f)-26;
			}
		}
	}
	printf("\n The encrypted word is\n");
	printf("\n");
	for (j = 0; j < l1; j++)
	{
		for (i = 0; i < 26; i++)
		{
			if (p[j] == n[i])
			{
				p[j] = a[i];
				printf("%c", p[j]);
			}
		}
	}
	getch();
}




