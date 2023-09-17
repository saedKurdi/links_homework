using System.Reflection;

namespace LinksHomework;
internal class MyClass
{

    public string Name { get; set; }    

    public MyClass(ref string name)
    {
        Name = name;        
    }

    public void Space(ref string name)
    {
       string copy = "";
       for(int i = 0; i < name.Length; i++)
       {
           if (i == name.Length - 1)
           {
                copy += name[i];break;
           }
           copy += name[i];copy += "_";
           
       }
       name = copy;
       Console.WriteLine(name);
    }

    public void Reverse(ref string name)
    {
      
         name = name.Replace("_", "");
        string copy = "";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            copy += name[i];
        }


        name = copy;
        Console.WriteLine(name);
    }

}
