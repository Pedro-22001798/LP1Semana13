using System;
using System.Collections.Generic;

public class SuperList : List<double>
{
    public void GetMinMax1(out double min, out double max)
    {
        min = double.MaxValue;
        max = double.MinValue;

        foreach (double num in this)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }
    }

    public (double min, double max) GetMinMax2()
    {
        if (Count == 0)
            throw new InvalidOperationException("Empty list.");

        double min = double.MaxValue;
        double max = double.MinValue;

        foreach (double num in this)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }

        return (min, max);
    }

    public void GetMinMax3(ref double min, ref double max)
    {
        if (Count == 0)
            throw new InvalidOperationException("Empty list.");

        min = double.MaxValue;
        max = double.MinValue;

        foreach (double num in this)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }
    }

    public (double Min, double Max) GetMinMax4()
    {
        if (Count == 0)
            throw new InvalidOperationException("Empty list.");

        double min = double.MaxValue;
        double max = double.MinValue;

        foreach (double num in this)
        {
            if (num < min)
                min = num;

            if (num > max)
                max = num;
        }

        return (Min: min, Max: max);
    }
}
