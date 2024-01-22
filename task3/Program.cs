int n = Convert.ToInt32(Console.ReadLine());
int Odd;
int []arr= new int[n];
for(int i=n;i>=0;i/=10)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
    
}
for(int i=n;i>=0;i/=10){
    if(arr[i]%2!=0)
    {
        System.Console.Write($"arr[i] ");
    }
}



