int kalkulator(int [] x)
{
    if (x==null)
    {
        return 0;
    }

    return x.Average();
}

int maxklata(int[] x)
{
    if (x == null)
    {
        return 0;
    }
    else
    { 
        return x.Max();
    }
}

int malatrabka(int[] x)
{
    if (x == null)
    {
        return 0;
    }
    else
    {
        return x.Min();
    }
}