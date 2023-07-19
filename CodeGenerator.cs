using System.Runtime.CompilerServices;

namespace InterceptorsPreviewFirstTry
{
    public static class CodeGenerator
    {
        [InterceptsLocation("""C:\Users\Ali\source\repos\InterceptorsPreviewFirstTry\Program.cs""", line: 7, character: 16)]
        public static void EnrollInterceptor(this Student StudentExample, string StudentName)
        {
            Console.WriteLine($"This is a new way of Student {StudentName} registration");
        }
    }

}
