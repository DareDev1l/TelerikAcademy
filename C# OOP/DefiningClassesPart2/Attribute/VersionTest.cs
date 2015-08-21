namespace Attribute
{
    using System;

    [Version(2,11)]
    class VersionTest
    {
        static void Main()
        {
            Type type = typeof(VersionTest);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine("The version of this class is {0}.{1}", attribute.Major , attribute.Minor);
            }

        }
    }
}
