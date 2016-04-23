public class C
{
   public string Name     = "John";
   public string LastName = "Doe";
// Test of new C# 6 'string interpolation' feature, $ sign
   public string FullName => $"Hello {Name} {LastName}";
}
