#include<stdio.h>
#include<string.h>
void check(char s[50],int);
void main()
{
	char s[50];
	int i, l;
	printf("\nenter the string\n");
	gets(s);
	for (i = 0; i < 100; i++)
	{
		if (s[i] == NULL)
		{
			l = i;
		}
	}
	printf("\n the length of the string is\n%d", l);
	system("PAUSE");
		
}
void check(char s[50],int l)
{
	int i,count=1,j;
	for (i = 0; i < l-1; i++)
	{
		if (s[i] == s[i + 1])
		{
			count++;
			j = count;
		}
		else
		{
			j = 1;
		}
		printf("%c%d", s[i], j);
	}
}