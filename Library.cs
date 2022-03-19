using System;

public class lib
{
    public string String(string v1, int v2)
    {
        try
        {
            return string.Join("", System.Linq.Enumerable.Repeat(v1, v2));
        }
        catch
        {
            throw new NotImplementedException();
        }
    }
}