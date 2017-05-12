using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Queue
/// </summary>
public class Queue
{
    private const int default_size = 8;

    private int size;
    private int front;
    private int back;
    private int[] values;
    public Queue(int size)
    {
        this.size = size;
        values = new int[size];
        front = 0;
        back = 0;
    }
    public Boolean IsFull()
    {
        if ((back + 1) % size == front)
            return true;
        else
            return false;
    }
    public Boolean IsEmpty()
    {
        if (back == front)
            return true;
        else
            return false;
    }
    public void EnQueue(int x)
    {
        if (!IsFull())
        {
            back = (back + 1) % size;
            values[back] = x;
        }
    }
    public int DeQueue()
    {
        if (!IsEmpty())
        {
            front = (front + 1) % size;
            return values[front];
        }
        return 0;
    }





}