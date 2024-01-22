int n = Convert.ToInt32(Console.ReadLine());

string CheckGrade(int n)
{
    if(n>=90 && n<=100)
    {
        return "A";
    }
    else if (n>=80 && n<=89)
    {
        return "B";
    }
    else if(n>=70 && n<=79){
        return "C";
    }
    else 
    {
        return "D";
    }
    
}


System.Console.WriteLine(CheckGrade(n));

