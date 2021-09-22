using System;

namespace Lesson19_18_09_2021
{
public static class ArrayHelper<T>
{
    public static T Pop(ref T[] array)
    {
       var arr=new T [array.Length-1];
       T end = array[array.Length-1];
       for(int i=0; i<array.Length-1; ++i)
       {
           arr[i]=array[i];
       }
       array=arr;
       return end;
    }
    public static int Push(ref T[] array , T element)
    {
        var arr=new T[array.Length+1];
       arr[array.Length]= element;
        for(int i=0; i<array.Length; ++i)
        {
            arr[i]=array[i];
        }
        array=arr;
    return array.Length; 
    }
    public static T Shift( ref T[] array)
    { 
        var arr= new T[array.Length-1];
        T begin=array[0];
         for(int i=1; i<array.Length; ++i)
         {
             arr[i-1]=array[i];
         }
         array=arr;
         return begin;
    }
    public static int UnShift(ref T[] array, T element)
    {
        var arr= new T[array.Length+1];
         arr[0]=element;
         for(int i=0; i<array.Length; ++i)
         {
             arr[i+1]=array[i];
         }
         array=arr;
         return array.Length;
    }
    public static T[] Slice(T[] array, int index)
    {
         if(index>array.Length)
        {
            var  arr= new T[0] ;
         return arr;
        }
         else if(index<0)
         {
             index=array.Length-Math.Abs(index)-1;
             var arr=new T[index+1];
             for(int i=0; i<=index; ++i)
             {
                arr[i]=array[i];
             }
             return arr;
         }      
         else 
         {
            var arr=new T[array.Length-index];
             for(int i=index; i<array.Length; ++i)
             {
                 arr[i-index]=array[i];
             }
             return arr;
         }
    }
    public static T[] Slice(T[] array,int b_index,int e_index)
    {
               if(e_index<0)
       {
          e_index=array.Length-1 -Math.Abs(e_index);
               if(e_index<=b_index) 
               { 
                   var arr=new T[0];
                   return arr;
               }
               else
               {
                   var arr=new T[e_index-b_index+1];
                   for(int i=b_index; i<=e_index; ++i)
                    arr[i-b_index]=array[i];
                    return arr;
               }
       }
       else
       {
           if(e_index<=b_index) 
           {
               var arr=new T[0];
               return arr;
           }
           else 
           {
               var arr=new T[ e_index-b_index];
               for(int i=b_index; i<e_index; ++i)
               {
                   arr[i-b_index]=array[i];
               }
               return arr;
           }
       }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
         int[] array =new int[]{1,2,3,4,5,6,12,13,15,23,31,32,45};
          Mas(array);
            Console.WriteLine($"Удаляем последный элемент массива и возврашаемь этот элемен: {ArrayHelper<int>.Pop(ref  array)}");
            Mas(array);
            Console.WriteLine($"Добовляемь 15 в конце массива и возвращаем длину массива:"+
            $" {ArrayHelper<int>.Push(ref array,15)}");
                Mas(array);
            Console.WriteLine($"Удаляем первый элемент и возвращает этот удалённый элемент: {ArrayHelper<int>.Shift(ref array)}");
               Mas(array);
            Console.WriteLine($"Добовляем 100 в начале массива и возвращаем длину массива: {ArrayHelper<int>.UnShift(ref array,100)}");   
            Mas(array);
            Console.WriteLine("Выпольнения метод Slice(mas,3)");
            Mas(ArrayHelper<int>.Slice(array,3));
        Console.WriteLine("Выпольнения метод Slice(mas,-2)");
        Mas(ArrayHelper<int>.Slice(array,-2));
        Console.WriteLine("Выпольнения метод Slice(mas,17)");
        Mas(ArrayHelper<int>.Slice(array,17));
          Console.WriteLine("Выполнение метод Slice(array,3,9)");
               Mas(ArrayHelper<int>.Slice(array,3,9));
           Console.WriteLine("Выполнение метод Slice(array,2,-4)");
               Mas(ArrayHelper<int>.Slice(array,2,-4));
         
        }
    static void Mas(int[] mas)
    {
        Console.WriteLine("Наш массив");
         foreach (var item in mas)
         {
             Console.Write($"{item}\t");
         }
       Console.WriteLine();            
    }
}

}
