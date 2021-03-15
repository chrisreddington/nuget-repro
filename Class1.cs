using System;

namespace nuget_repro
{
    public class Class1
    {
        public void Log(string text)
        {
            //trigger a change
            Console.WriteLine(text);
        }
    }
}
