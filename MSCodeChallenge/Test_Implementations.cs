namespace MSCodeChallenge;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Calculator()
    {
        var question = new Questions();

        Assert.IsTrue(question.Calculator(2, 2, '+') == 4);

        Assert.IsTrue(question.Calculator(2, 2, '-') == 0);

        Assert.IsTrue(question.Calculator(2, 2, '/') == 1);

        Assert.IsTrue(question.Calculator(2, 3, '*') == 6);
    }

    [TestMethod]
    public void Factorial()
    {
        var challenges = new Questions();

        Assert.IsTrue(challenges.Factorial(3) == 6);

        Assert.IsTrue(challenges.Factorial(5) == 120);

        Assert.IsTrue(challenges.Factorial(7) == 5040);
    }

    [TestMethod]
    public void FindAverage()
    {
        var challenges = new Questions();

        var numbers = new int[] { 1, 2, 3, 4, 5 };

        Assert.IsTrue(challenges.FindAverage(numbers) == 3);
    }

    [TestMethod]
    public void FindFrequence()
    {
        var challenges = new Questions();

        var text = "hello world";
        var chr = 'l';

        Assert.IsTrue(challenges.FindFrequence(text, chr) == 3);
    }

    [TestMethod]
    public void Largest()
    {
        var challenges = new Questions();

        var a = 20;
        var b = 10;

        Assert.IsTrue(challenges.Largest(a, b) == 20);

        Assert.IsTrue(challenges.Largest(b, a) == 20);
    }

    [TestMethod]
    public void Palindrom()
    {
        var challenges = new Questions();


        Assert.IsFalse(challenges.Palindrom("apple"));

        Assert.IsTrue(challenges.Palindrom("abba"));

        Assert.IsTrue(challenges.Palindrom("racecar"));
    }

    [TestMethod]
    public void SecondHighst()
    {
        var challenges = new Questions();


        var numbers = new int[] { 1, 4, 3, 2, 5 };

        Assert.IsTrue(challenges.SecondHighst(numbers) == 4);
    }

    [TestMethod]
    public void SumEven()
    {
        var challenges = new Questions();

        Assert.IsFalse(challenges.SumEven(9) == 30);

        Assert.IsTrue(challenges.SumEven(10) == 30);
    }

    [TestMethod]
    public void SumSquares()
    {
        var challenges = new Questions();

        Assert.IsTrue(challenges.SumSquares(5) == 30);
    }

    [TestMethod]
    public void Volume()
    {
        var challenges = new Questions();

        Assert.IsTrue(challenges.Volume(3, 3, 3) == 27);
    }
}
