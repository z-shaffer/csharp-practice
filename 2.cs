using System;

public class BSEArray
{
    Public static void Shownames ()
    {
        Console.Write("Zach Shaffer");
    }

    Public static void ShowArray (int[] A)
    {
        int i = 0;
        try
        {
            foreach(int x in A)
            {
                i++;
                Console.Write("Item " + i + ":" + x);
            }
        }
        catch(Exception e) {
            Console.Write(e);
        }
    }

    public static double MeanValue(int[] A)
    {
        double i = 0;
        try
        {
            foreach(int x in A)
            {
                i += x;
            }
            return (i / A.Length);
        }
        catch(Exception e) {
            return -1;
        }
    }

    public static int MaxValue(int[] A)
    {
        try
        {
            int i = A[0];
            foreach(int x in A)
            {
                if (x > i)
                {
                    i = x;
                }
            }
            return i;
        }
        catch(Exception e) {
            return -1;
        }
    }

    public static int MinValue(int[] A)
    {
        try
        {
            int i = A[0];
            foreach(int x in A)
            {
                if (x < i)
                {
                    i = x;
                }
            }
            return i;
        }
        catch(Exception e) {
            return -1;
        }
    }

    public static bool RemoveValueAt(int[] A, int idx)
    {
        try
        {
            if (idx >= 0 && idx < A.Length && A.Length > 0)
            {
                A[idx] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception e) {
            return false;
        }
    }

    public static bool RemoveValue(int[] A, int value)
    {
        try
        {
            int i = 0;
            foreach(int x in A)
            {
                if (x == value)
                {
                    x = 0;
                    i = 1;
                }
            }
            if (i == 1)
            {
                return true;
            }
            return false;
        }
        catch(Exception e) {
            return false;
        }
    }

    public static int Count(int[] A, int value)
    {
        int i = 0;
        try
        {
            foreach(int x in A)
            {
                if (x == value)
                {
                    i++;
                }
            }
            return i;
        }
        catch(Exception e) {
            return -1;
        }
    }

    public static bool IsFull(int[] A)
    {
        int i = 0;
        try
        {
            foreach(int x in A)
            {
                if (x != 0)
                {
                    i++;
                }
            }
            if (i == A.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception e) {
            return false;
        }
    }

    public static int[] GetFreePositions(int[] A)
    {
        int x = 0;
        int C = 0;
        try
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    C++;
                }
            }
            int[] B = new int[C];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    B[x] = i;
                    x++;
                }
            }
            return B;
        }
        catch(Exception e) {
            return 0;
        }
    }

    public static bool Contains(int[] A, int value)
    {
        try
        {
            foreach(int x in A)
            {
                if (x == value)
                {
                    return true;
                }
            }
            return false;
        }
        catch(Exception e) {
            return false;
        }
    }

    public static int[] Contains(int value, int[] A)
    {
        int x = 0;
        int C = 0;
        try
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == value)
                {
                    C++;
                }
            }
            int[] B = new int[C];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == value)
                {
                    B[x] = i;
                    x++;
                }
            }
            return B;
        }
        catch(Exception e) {
            return 0;
        }
    }
}
