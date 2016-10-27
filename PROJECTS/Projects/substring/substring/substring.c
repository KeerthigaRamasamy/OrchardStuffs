#include<stdio.h>
#include<string.h>
void main()
{
	char s[50],s1[50];
	int l, i, a,j;
	printf("\n enter the string\n");
	gets(s);
	l = strlen(s);
	printf("\n the length of the string\n%d", l);
	printf("\n the possible substrings are\n");
	i = 0;
	while (i < l)
	{
		a = 0;
		for(j=i;j<=l;j++)
		{
			s1[a] = s[j];
			a++;
			s1[a]="\0";
			printf("%s", s1);
			printf("\n");
		}

		printf("%s", s1);
		i++;
	}
	getch();


}

