using System;
using System.Collections.Generic;
using EntityFrameworkTryOut.DataModels;

namespace EntityFrameworkTryOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Students.Add(new Student()
            {
                StudentName = "Sergei Severin",
                StudentClasses = new List<Class>()
                {
                    new Class() {

                        ClassName = "GoodClass",
                        ClassLanguage = Enums.Language.Russian,
                        MaxClassSize = 11
                    },
                    new Class() {
                        ClassName = "BadClass",
                        ClassLanguage = Enums.Language.Spaninsh,
                        MaxClassSize = 2
                    }
                }
            });
            context.SaveChanges();
        }
    }
}
