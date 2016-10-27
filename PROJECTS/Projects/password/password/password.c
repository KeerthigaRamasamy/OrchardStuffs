#include<stdio.h>
#include<string.h>
#include<conio.h>
void main()
{
	char p[8];
	int s[15],a[26],b[26],n[10],i,j,k,l,m,v,v1,v2,v3,flag1,flag2,flag3,flag4,len;
	printf("\n enter the password\n");
	gets(p);
	len = strlen(p);
	if (len < 8)
		printf("\n The password length is small");
	else
	{
		for (i = 0, v = 33; i < 15, v <= 47; i++)
		{
			s[i] = v;
			v++;
		}
		for (j = 0, v3 = 48; j < 10, v3 <= 57; j++)
		{
			n[j] = j;
			v3++;
		}
		for (k = 0, v1 = 97; k < 26, v1 <= 122; k++)
		{
			a[k] =v1;
			v1++;
		}
		for (l = 0, v2 = 65; k < 26, v2 <= 90; l++)
		{
			b[l] = v2;
			v2++;
		}
		for (i = 0; i < len; i++)
		{
			j = 0, k = 0, l = 0; m = 0; flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0;
			while (j < 15)
			{
				if (p[i] == (char)s[j])
				{
					flag1 = 1;
					break;
				}
				else
				{
					j++;
				}
			}
			while (k < 10)
			{
				if ((int)p[i] == n[k])
				{
					flag2 = 1;
					break;
				}
				else
				{
					k++;
				}
			}
			while (l < 26)
			{
				if (p[i] ==(char)b[l])
				{
					flag3 = 1;
					break;
				}
				else
				{
					l++;
				}
			}
			while (m < 26)
			{
				if (p[i] ==(char) a[m])
				{
					flag4 = 1;
					break;
				}
				else
				{
					m++;
				}
			}
		}
	}
	if (flag1 == flag2 == flag3 == flag4 == 1)
	{
		printf("\n The password is valid and your password is an excellent password\n");
	}
	else if (flag1 == 0)
		printf("\nBut Your password is a good password\n");
	else if (flag2 == 0)
		printf("\n Your password is a bad password\n");
	else if (flag3==0)
		printf("\n Your password is a poor password\n");
	else if (flag3 == 0)
		printf("\n Your password is a poor password\n");
	getch();

 }