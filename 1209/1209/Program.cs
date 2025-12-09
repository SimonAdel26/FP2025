// BIN PACKING




using System.Collections.Immutable;

int C = 10;
int[] v = { 3, 6, 2, 1, 5, 7, 2, 4, 1, 9 };
// 3, 6, 
// 2, 1, 5, 
// 7, 2
// 4, 1
// 9
Console.WriteLine($"NextFit: {NextFit(C, v)}");


// 3, 6, 1
// 2, 5, 2, 1
// 7
// 4
// 9
Console.WriteLine($"FirstFit: {FirstFit(C, v)}");



// 3, 6, 2, 1, 5, 7, 2, 4, 1, 9
// 3, 6, 1
// 2, 5, 2, 1
// 7
// 4
// 9
Console.WriteLine($"BestFit: {BestFit(C, v)}");


// 3, 6, 2, 1, 5, 7, 2, 4, 1, 9
// 3, 6
// 2, 1, 5
// 7, 2
// 4, 1
// 9
Console.WriteLine($"WorstFit: {WorstFit(C, v)}");


Array.Sort(v, (x, y) => y - x);

Console.WriteLine($"NextFit Decreasing: {NextFit(C, v)}");
Console.WriteLine($"FirstFit  Decreasing: {FirstFit(C, v)}");
Console.WriteLine($"BestFit  Decreasing: {BestFit(C, v)}");
Console.WriteLine($"WorstFit  Decreasing: {WorstFit(C, v)}");


Console.WriteLine();
int WorstFit(int c, int[] v)
{
    List<int> bins = new List<int>();
    bins.Add(0);
    for (int i = 0; i < v.Length; i++)
    {
        bool gasit = false;
        int k = 0;
        int minim = c;
        for (int j = 0; j < bins.Count; j++)
        {
            if (bins[j] + v[i] <= c)
            {
                gasit = true;
                if (bins[j] < minim)
                {
                    minim = bins[j];
                    k = j;
                }
            }
        }

        if (!gasit)
            bins.Add(v[i]);
        else
            bins[k] += v[i];
    }
    return bins.Count;
}

int BestFit(int c, int[] v)
{
    List<int> bins = new List<int>();
    bins.Add(0);
    for (int i = 0; i < v.Length; i++)
    {
        bool gasit = false;
        int k = 0;
        int maxim = 0;
        for (int j = 0; j < bins.Count; j++)
        {
            if (bins[j] + v[i] <= c)
            {
                gasit = true;
                if (bins[j] > maxim)
                {
                    maxim = bins[j];
                    k = j;
                }
            }
        }

        if (!gasit)
            bins.Add(v[i]);
        else
            bins[k] += v[i];
    }
    return bins.Count;
}

int FirstFit(int c, int[] v)
{
    List<int> bins = new List<int>();
    bins.Add(0);
    for(int i = 0; i < v.Length; i++)
    {
        bool gasit = false;
        for(int j = 0; j < bins.Count; j++)
        {
            if (bins[j] + v[i] <= c)
            {
                gasit = true;
                bins[j] += v[i];
                break;
            }
        }
        if (!gasit)
            bins.Add(v[i]);
    }

    return bins.Count;
}

int NextFit(int c, int[] v)
{
    int bins = 1;
    if (v.Length == 0)
        return 0;
    int currentBin = 0;
    for(int i = 0; i <  v.Length; i++)
    {
        if (v[i] + currentBin <= c)
            currentBin += v[i];
        else
        {
            bins++;
            currentBin = v[i];
        }
    }
    return bins;
}