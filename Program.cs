using System;

namespace AddelementsToTheArry
{
class Program
{
    static void Main(string[] args)
    {
        int index;
        int n;
        int x;
        int m;
        int [] myArry = new int[10];
    
        
        Console.WriteLine("Nhap so phan tu trong mang ");
        n= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap {0} phan tu vao trong mang: ", n);
       
        for (index = 0; index < n; index++)
        {
            Console.Write("Phan tu - {0}: ", index);
            myArry[index] = Convert.ToInt32(Console.ReadLine());
        }
         
         Console.WriteLine("Moi nhap phan tu moi can chen: ");
         m = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Phan tu moi can chen la: {0}", m);

         Console.WriteLine("Moi nhap vi tri can chen phan tu: ");
         x = Convert.ToInt32(Console.ReadLine());   
         Console.WriteLine("Vi tri can chen phan tu moi la: {0}", x);

         Console.Write("Mang ban dau la: \n");
         for (index = 0; index < n; index++)
         {
            Console.Write("{0} ", myArry[index]);
         }
         //di chuyen vi tri cac phan tu ben phai cua mang
         for (index = n; index >= x; index--)
         {
            myArry[index] = myArry[index - 1];
         }   
        //chen gia tri vao vi tri da cho
        myArry[x-1] = m;

         Console.WriteLine("\nSau khi chen phan tu mang co dang: ");

         for (index = 0; index <= n; index++)
         {
            Console.Write("{0} ", myArry[index]);
            Console.Write("");
         }

         Console.WriteLine();
    }   
}
}


