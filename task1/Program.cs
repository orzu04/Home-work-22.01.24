int n = Convert.ToInt32(Console.ReadLine());

int Even = 0;
int Odd = 0;
  int Zeros = 0;
int cnt =0;
int min = n%10;
int Max = n%10;
int Sum = 0;
while (n>0)
{
    cnt ++;
   
    Sum+=n%10;
    if((n%10)%2==0 && n%10!=0)
    {
       Even++ ;
    }
    else if((n%10)%2!=0 && n%10!=0){

        Odd++;
    }
    else if(n%10==0)
    {
         Zeros++;
    }
    if(min<=n%10)min=n%10;
    else if(Max>=n%10) Max=n%10;
    
    n/=10;
}

System.Console.WriteLine($"Even : {Even}");
System.Console.WriteLine($"Odd : {Odd}");
System.Console.WriteLine($"Zeros : {Zeros}");
System.Console.WriteLine($"Digits : {cnt}");
System.Console.WriteLine($"Sum : {Sum}");
System.Console.WriteLine($"min : {min}");
System.Console.WriteLine($"Max : {Max}");