#include<stdio.h>
int check(int, int,int,int,int);
void main()
{
	int x1, x2, x3, y1, y2, y3, r, c1, c2,n,n1,n2;
	printf("\nenter the first coordinate\n");
	scanf("%d%d", &x1, &y1);
	printf("\nenter the second coordinate\n");
	scanf("%d%d", &x2, &y2);
	printf("\nenter the third coordinate\n");
	scanf("%d%d", &x3, &y3);
	printf("\n enter the radius");
	scanf("%d", &r);
	printf("\n enter the centre coordinate");
	scanf("%d%d", &c1, &c2);
	printf("%d%d", x1,y1);
	printf("\n");
	printf("%d%d", x2, y2);
	printf("\n");
	printf("%d%d", x3, y3);
	printf("\n");
	n = check(x1, y1,c1,c2,r);
	n1 = check(x2, y2,c1,c2,r);
	n2 = check(x3, y3,c1,c2,r);
	printf("\n the n values are%d\t%d\t%d\t", n, n1, n2);
	if (n==n1==n2==1)
	{
		printf("\n all the coordinates are inside the circle\n");
	}
	else
	{
		printf("\n not all the coordinates are inside the circle");
	}
	getch();
}
int check(int x, int y,int c1,int c2,int r)
{
	int a, b, c, d;
	a = c1 - r;
	b = c1 + r;
	c = c2 - r;
	d = c2 + r;
	printf("%d\n%d\n%d\n%d\n", a, b, c, d);
	if (x >= c && x <= b)
	{ 
		printf("\nThe first condition satisfied\n");
		if (y>=a && y <= d)
		{
			printf("the y and a values are%d\t%d", y, a);
			printf("\n the second condition is satisfied\n");
			return 1;
		}
		else
		{
			return 0;
		}
	}
	else
	{
		return 0;
	}
}