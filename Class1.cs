using Xunit;

namespace MyFirstUnitTests
{
    public class MyTests
    {
        [Fact]
        public void MyTest()
        {
            Assert.Equal(4, 2 + 2);
        }
    }

    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }

    //public class Calculator
    //{
    //    public int Add(int value1, int value2)
    //    {
    //        return value1 + value2;
    //    }
    //}

    //public class CalculatorTest
    //{
    //    [Fact]
    //    public void CanAdd()
    //    {
    //        var calculator = new Calculator();

    //        int val1 = 1;
    //        int val2 = 2;

    //        var result = calculator.Add(val1, val2);

    //        Assert.Equal(3, result);
    //    }

    //    [Theory]
    //    [InlineData(1, 2, 3)]
    //    [InlineData(-4, -6, -10)]
    //    [InlineData(-2, 2, 0)]
    //    [InlineData(int.MinValue, -1, int.MaxValue)]  // Edge case
    //    //[InlineData(1, 2)]
    //    //[InlineData(1, 2, 3, 12)]
    //    //[InlineData(1, 2, "three")]
    //    public void CanAddTheory(int value1, int value2, int expected)
    //    {
    //        var calculator = new Calculator();

    //        var result = calculator.Add(value1, value2);
    //        Assert.Equal(expected, result);
    //    }

    //    [Theory]
    //    [ClassData(typeof(CalculatorTestData))]
    //    public void CanAddTheoryClassData(int value1, int value2, int expected)
    //    {
    //        var calculator = new Calculator();

    //        var result = calculator.Add(value1, value2);
    //        Assert.Equal(expected, result);
    //    }

    //    public class CalculatorTestData : IEnumerable<object[]>
    //    {
    //        public IEnumerator<object[]> GetEnumerator()
    //        {
    //            yield return new object[] { 1, 2, 3 };
    //            yield return new object[] { -4, -6, -10 };
    //            yield return new object[] { -2, 2, 0 };
    //            yield return new object[] { int.MinValue, -1, int.MaxValue };
    //        }

    //        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    //    }

    //    [Theory]
    //    [MemberData(nameof(Data))]
    //    public void CanAddTheoryMemberDataProperty(int value1, int value2, int expected)
    //    {
    //        var calculator = new Calculator();

    //        var result = calculator.Add(value1, value2);
    //        Assert.Equal(expected, result);
    //    }

    //    public static IEnumerable<object[]> Data =>
    //        new List<object[]>
    //        {
    //            new object[] { 1, 2, 3 },
    //            new object[] { -4, -6, -10 },
    //            new object[] { -2, 2, 0 },
    //            new object[] { int.MinValue, -1, int.MaxValue }
    //        };

    //    [Theory]
    //    [MemberData(nameof(GetData), parameters: 3)]
    //    public void CanAddTheoryMemberDataMethod(int value1, int value2, int expected)
    //    {
    //        var calculator = new Calculator();

    //        var result = calculator.Add(value1, value2);
    //        Assert.Equal(expected, result);
    //    }

    //    public static IEnumerable<object[]> GetData(int numTests)
    //    {
    //        var allData = new List<object[]>
    //        {
    //            new object[] { 1, 2, 3 },
    //            new object[] { -4, -6, -10 },
    //            new object[] { -2, 2, 0 },
    //            new object[] { int.MinValue, -1, int.MaxValue }
    //        };

    //        return allData.Take(numTests);
    //    }

    //    [Theory]
    //    [MemberData(nameof(Data), MemberType = typeof(CalculatorData))]
    //    public void CanAddTheoryMemberDataMethod2(int value1, int value2, int expected)
    //    {
    //        var calculator = new Calculator();

    //        var result = calculator.Add(value1, value2);
    //        Assert.Equal(expected, result);
    //    }

    //    public class CalculatorData
    //    {
    //        public static IEnumerable<object[]> Data =>
    //            new List<object[]>
    //            {
    //                new object[] {1, 2, 3},
    //                new object[] {-4, -6, -10},
    //                new object[] {-2, 2, 0},
    //                new object[] {int.MinValue, -1, int.MaxValue}
    //            };
    //    }
    //}

    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //public class TestDataGenerator //: IEnumerable<object[]>
    //{
    //    //private readonly List<object[]> _data = new List<object[]>()
    //    //{
    //    //    new object[] {5, 1, 3, 9},
    //    //    new object[] {7, 1, 5, 3}
    //    //};

    //    public static IEnumerable<object[]> GetNumbersFromDataGenerator()
    //    {
    //        yield return new object[] { 5, 1, 3, 9 };
    //        yield return new object[] { 7, 1, 5, 3 };
    //    }

    //    public static IEnumerable<object[]> GetPersonFromDataGenerator()
    //    {
    //        yield return new object[]
    //        {
    //            new Person {Name = "ho9", Age = 31},
    //            new Person {Name = "197 Jay L", Age = 30},
    //            new Person {Name = "Joseph C", Age = 32},
    //            new Person {Name = "Ghost", Age = 999},
    //        };

    //        yield return new object[]
    //        {
    //            new Person {Name = "JHSeem", Age = 34},
    //            new Person {Name = "HHLee", Age = 27},
    //            new Person {Name = "WAChoi", Age = 31},
    //            new Person {Name = "SGSong", Age = 31}
    //        };
    //    }

    //    //public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

    //    //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    //}

    //public class ParameterizedTests
    //{
    //    public bool IsOddNumber(int number)
    //    {
    //        return number % 2 != 0;
    //    }

    //    public bool IsThirties(Person person)
    //    {
    //        return person.Age >= 30;
    //    }

    //    public static IEnumerable<object[]> GetNumbers()
    //    {
    //        yield return new object[] { 5, 1, 3, 9 };
    //        yield return new object[] { 7, 1, 5, 3 };
    //    }

    //    [Theory]
    //    [MemberData(nameof(GetNumbers))]
    //    //[ClassData(typeof(TestDataGenerator))]
    //    //[InlineData(5, 1, 3, 9)]
    //    //[InlineData(7, 1, 5, 3)]
    //    public void AllNumbers_AreOdd_WithInlineData(int a, int b, int c, int d)
    //    {
    //        Assert.True(IsOddNumber(a));
    //        Assert.True(IsOddNumber(b));
    //        Assert.True(IsOddNumber(c));
    //        Assert.True(IsOddNumber(d));
    //    }

    //    [Theory]
    //    [MemberData(nameof(TestDataGenerator.GetNumbersFromDataGenerator), MemberType = typeof(TestDataGenerator))]
    //    public void AllNumbers_AreOdd_WithMemberData_FromDataGenerator(int a, int b, int c, int d)
    //    {
    //        Assert.True(IsOddNumber(a));
    //        Assert.True(IsOddNumber(b));
    //        Assert.True(IsOddNumber(c));
    //        Assert.True(IsOddNumber(d));
    //    }

    //    [Theory]
    //    [MemberData(nameof(TestDataGenerator.GetPersonFromDataGenerator), MemberType = typeof(TestDataGenerator))]
    //    public void AllPersons_AreAbove29_WithMemberData_FromDataGenerator(Person a, Person b, Person c, Person d)
    //    {
    //        Assert.True(IsThirties(a));
    //        Assert.True(IsThirties(b));
    //        Assert.True(IsThirties(c));
    //        Assert.True(IsThirties(d));
    //    }
    //}

}
