using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datedisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Day: ");
    int day = Convert.ToInt32(Console.ReadLine()); ;
    Console.Write("Enter Month: ");
    int month = Convert.ToInt32(Console.ReadLine()); ;
    Console.Write("Enter Year: ");
    int year = Convert.ToInt32(Console.ReadLine()); ;

    Console.WriteLine("Input Date: " + day + "/" + month + "/" + year);

    DateDisplayer displayer = new DateDisplayer();

    if (displayer.isValidDate(day, month, year))
    {
        Console.WriteLine(displayer.isValidDate(day, month, year));
        string monthInWordds = "";
        monthInWordds = displayer.getMonthInWords(month);
        Console.WriteLine(day + " " + monthInWordds + " " + year);
    }
    else
    {
        Console.WriteLine("You have entered an Invalid Date.");
    }
}

        }
    }
}
class DateDisplayer
{


public virtual bool isValidDate(int day, int month, int year)
{
 
  if(year>999 && year<10000 && month>=1 && month<=12 && day>=1 && day<=31)
{
    if(month==2)
  {
    if(year%4==0 || year%400==0)
	 {
  
		if(day<=29)
        {
          return true;
        }
     }
      else if(day<=28)
        return true;
  }
    if(month==1 ||month==3 ||month==5||month==7||month==8||month==10||month==12)
    {
      if(day>=1 && day<=31)
        return true;
      else
        return false;
    }
    else if(month==4 ||month==6||month==9||month==11)
    {
		if(day>=1 && day<=30)
          return true;
      else
        return false;
    }
  }
  else
    return false;
 }
    
    
      
  
}

public virtual string getMonthInWords(int month)
{
switch(month)
{
  case 1:
    return "January";
    break;
  case 2:
    return "Febraury";
    break;
    case 3:
    return "March";
    break;
    case 4:
    return "April";
    break;
    case 5:
    return "May";
    break;
    case 6:
    return "June";
    break;
    case 7:
    return "July";
    break;
    case 8:
    return "August";
    break;
    case 9:
    return "September";
    break;
    case 10:
    return "October";
    break;
    case 11:
    return "November";
    break;
    case 12:
    return "December";
    break;
    
}
  
}


