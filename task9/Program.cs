int a = 2;
int b = 5;
int d=1;
int Daraja (int a, int b)
{
    if (b==0)
        {
            return d;
        }
    else
    {   
         d*=a;
        return Daraja(a,b-1);
    }
    }
System.Console.WriteLine(Daraja(a,b));
