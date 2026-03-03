namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_A_String_Containing_Its_Fields_FirstName_LastName_And_Age_When_The_Method_ToString_Is_Called(){
      var person = new Person("mary", "smith", 52);

      Assert.Contains("mary", person.ToString());
      Assert.Contains("smith", person.ToString());
      Assert.Contains("52", person.ToString());
    }
}