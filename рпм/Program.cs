
//Console.WriteLine("/////  /////  /  //  /////  /////  /////");
//Console.WriteLine("/   /  /   /  / / /  /   /  /        /");
//Console.WriteLine("/   /  /////  / / /  ////   /////    /");
//Console.WriteLine("/   /  /      / / /  /   /  /        /");
//Console.WriteLine("/   /  /      //  /  ////   /////    /");

//char[,] a = new char[5, 5];

//for (int i = 0; i < a.Length; i++) 
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if
//        a[i,j] = '/';
//    }
//}
////int[] k = {1, 2, 3};// числа которые подставляем вместо х и у
////int x =1; int y = 1;
////double w = Math.Pow(x,2) + 6*y + 3;//формула
////double[,] m = new double[k.Length + 1, k.Length + 1];
////m[0,0] = 0;  
////for (int l = 0; l < k.Length; l++)
////{
////    m[0, l + 1] = k[l];
////}
////for (int u = 0; u < k.Length; u++)
////{
////    m[u + 1, 0] = k[u];
////}
////for (int i = 0; i < k.Length; i++)
////{
////    x = k[i];
////    for (int j = 0; j < k.Length; j++)
////    { 
////        y = k[j];
////        w = Math.Pow(x, 2) + 6 * y + 3;
////        m[i+1,j+1] = w;
////    }
////}
////for (int i = 0; i < k.Length+1; i++)
////{
////    for (int p = 0; p < k.Length+1; p++)
////    {
////        Console.Write(m[i, p] + " ");
////    }
////    Console.WriteLine("");
////}

//int q = 5; //число
//int e = 1;
//for (int i = 1; i <= 5; i++)
//{
//    e *= i;
//}
//Console.WriteLine(e);

//Console.WriteLine("введите длину массива");
//int w = Convert.ToInt32(Console.ReadLine());
//int[] q = new int[w];
//for (int i = 0; i < q.Length; i++)
//{
//   Console.WriteLine($"напишите значение q[{i}]");
//   q[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.Write("ответ: ");
//int o = 1;
//for (int i = 0; i < q.Length; i++)
//{
//    if (i % 2 != 0 && i != 0)
//    {
//        o *= q[i];
//    }
//}
//Console.WriteLpri
namespace рпм;

class Human
{
    public virtual void Print()
    {

    }

    
}

class Student : Human
{
    public override void Print()
    {

    }
}