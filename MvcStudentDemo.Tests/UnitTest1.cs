namespace MvcStudentDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Student_Age_Should_Be_Set_Correctly()
    {
        var student = new Student { Age = 22 };
        Assert.Equal(22, student.Age);
    }
}