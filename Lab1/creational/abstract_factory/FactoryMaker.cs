using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.creational.abstract_factory
{
    public enum LanguageType
    {
        UA,
        EN
    }

    public class FactoryMaker
    {
        public static IBookFactory MakeFactory(LanguageType type)
        {
            switch (type)
            {
                case LanguageType.UA:
                    return new UAFactory();
                case LanguageType.EN:
                    return new ENFactory();
                default:
                    throw new ArgumentException("Unknown type");
            }
        }
    }
}
