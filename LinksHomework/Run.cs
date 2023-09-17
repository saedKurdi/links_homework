namespace LinksHomework;

internal class Run
{

    public void runFunc(Program.Func func , string str)
    {
        func.Invoke(ref str);
    }

}
