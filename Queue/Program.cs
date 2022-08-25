using System;
using System.Collections.Generic;
class Queue<T>
{
    private T[] arr = new T[0];
    //check Queue for on empty
    public void isEmpty()
    {
        if (arr.Length == 0)
            Console.WriteLine("Queue is empty");
        else
        {
            Console.WriteLine("Queue has elements");
        }
    }
    //add an element to head in Queue
    public void QAppend(T val)
    {
        T[] newArr = new T[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
            newArr[i + 1] = arr[i];
        newArr[0] = val;
        arr = newArr;
    }
    // delete the first element from Queue 
    public void QDelete()
    {
        T[] newArr = new T[arr.Length - 1];
        for (int i = 0; i < newArr.Length; i++)
            newArr[i] = arr[i];
        arr = newArr;
    }
    //show head (last element) of Queue
    public void Head()
    {
        Console.WriteLine("Head is " + arr[0]);
    }
    //show all Queue
    public void Show()
    {
        for (int i = arr.Length-1; i >= 0; i--)
            Console.WriteLine(arr[i]);
    }

}
    class Program
    {
        static void Main()
        {
            Queue<int> que = new Queue<int>();
            //add elements and show it
            que.QAppend(10);
            que.QAppend(40);
            que.QAppend(50);
            que.Show(); 
            Console.WriteLine("=======================");
            //delete elements and show it
            que.QDelete();
            que.QDelete();
            que.Show();
            que.isEmpty();
            que.Head();
        }
    }

