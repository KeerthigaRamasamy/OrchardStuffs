#include<stdio.h>
#include<string.h>
int noofwords(char s[100]);
void main()
{
	char s[100];
	int i,l, n, a;
	printf("\n enter the string");
	for (i = 0; i < 100; i++)
	{
		scanf("%s", &s[i]);
	}
	n = noofwords(s);
	printf("the no of words in the sentence is");
	printf("%d", n);
	system("PAUSE");
}
int noofwords(char s[100])
{
	int i,count;
	for (i = 0; i < 100; i++)
	{
		if (s[i] == NULL)
		{
			l = i; // length of the whole sentence
		}
	}
	for (i = 0; i < l; i++)
	{
		if (s[i] == " ")
		{
			count = count + 1;
		}
	}
	return count + 1;
}
int wordlength(char s[100])
{
	int i, kount=0;
	for (i = 0; i < l; i++)
	{
		if (s[i] == " ")
		{
			j = i + 1;
		}
		else
			kount++;
	}
	return kount;
}