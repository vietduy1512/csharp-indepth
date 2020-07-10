using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    public interface IPen
    {
        string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string text);

    }

    public interface IToy
    {
        string Func { get; set; }
    }

    public class ToyPen : IPen, IToy
    {
        // Implement Multiple Interface
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Func { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Close()
        {
            throw new NotImplementedException();
        }

        public bool Open()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }

    // 1. An interface only contains declarations of method, properties, indexers, and events.
    // 2. An interface can be implement implicitly or explicitly by a class or struct.
    // 3. A class or struct which implements an interface, must use 'public' access modifier.
    // 4. An interface cannot include private, protected, or internal members.All the members are public by default.
    // 5. Do not include 'public' in an interface as all the members are public by default. C# will give compile-time error if used 'public'.
    // 6. Implement interface explicitly using InterfaceName. with all the members.
    // 7. An interface can inherit one or more interfaces.
}
