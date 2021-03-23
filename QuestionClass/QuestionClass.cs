using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuestionClass
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<String>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void QuestionA()
        {
            using (var Names = NamesList.GetEnumerator())
            {
                while (Names.MoveNext())
                {
                    Console.WriteLine(Names.Current);
                }
            }
        }
    }

    


}
