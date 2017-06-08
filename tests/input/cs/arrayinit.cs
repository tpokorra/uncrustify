class Test
{
    /// constructor1
    public Test(short AId, int A2)
                 : this(AId, A2)
    {
    }

    /// constructor2
    public Test(short AId)
                 : this(AId, new int[] {})
    {
        Console.WriteLine(AId.ToString());

        foo(new int[] {});
    }
}
