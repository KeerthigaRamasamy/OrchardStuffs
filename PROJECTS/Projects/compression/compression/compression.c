#include<stdio.h>
#include<string.h>
void check(char[50], int);
void main()
{
	char s[50];
	int i, l;
	printf("\nenter the string\n");
	gets(s);
	for (i = 0; i < 50; i++)
	{
		if (s[i] == NULL)
		{
			l = i;
			break;
		}
	}
	
	printf("\n");
	check(s,l);
	
	getch();
}
void check(char s[50], int l)
{
	int i, count = 1, k = 0, c,l1,m,n,p,flag=0;
	char s1[50];
	printf("\n the compressed code is\t");
	for (i = 0; i < l; i++)
	{
			if(s[i] == s[i + 1] && i != l)
			{
				count++;
				flag = 1;
			}
			else
			{
				if (count == 1)
				{
					printf("%c", s[i]);
				}
				else
				{
					printf("%c%d", s[i], count);
				}
				
					s1[k] = s[i];
					s1[k + 1] = count;
					k = k + 2;
				count = 1;
				
			}
			s1[k] = "\0";
			
		
	}
	printf("\n");
	printf("\n the decompressed code is\t");
	
	
	for (m = 0; m < k - 1; m++)
	{
		n = s1[m + 1];
		
		for (p = 0; p < n; p++)
		
			printf("%c", s1[m]);
		m = m + 1;
	}

}


