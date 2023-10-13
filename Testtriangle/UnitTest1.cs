using CalculateTriangle;

namespace Testtriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() //Тест на не треугольник
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "0", "5");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test2() //Тест на пустые значения
        {
            var expect = "";
            var actual = Triangle.GoTriangle("", "", "");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test3() //Тест на числовые нулевые значения
        {
            var expect = "";
            var actual = Triangle.GoTriangle("0", "0", "0");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test4() //Тест на отрицательные значения
        {
            var expect = "";
            var actual = Triangle.GoTriangle("-1", "-1", "-1");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test5() //Тест на буквенные значения
        {
            var expect = "";
            var actual = Triangle.GoTriangle("к", "о", "т");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test6() //Тест на символьные значения
        {
            var expect = "";
            var actual = Triangle.GoTriangle("@", "@", "@");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test7() //Тест на числовые значения
        {
            var expect = "Разносторонний";
            var actual = Triangle.GoTriangle("1", "2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test8() //Тест на числовые дробные значения
        {
            var expect = "Равнобедренный";
            var actual = Triangle.GoTriangle("13,2", "2,4", "13,2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test9() //Тест на числовые дробные значения с точкой
        {
            var expect = "";
            var actual = Triangle.GoTriangle("13.2", "2.4", "13.2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test10() //Тест на определение не треугольника
        {
            var expect = "Не треугольник";
            var actual = Triangle.GoTriangle("1", "8", "15");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test11() //Тест на определение расностороннего треугольника
        {
            var expect = "Разносторонний";
            var actual = Triangle.GoTriangle("1", "2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test12() //Тест на определение равнобедренного треугольника
        {
            var expect = "Равнобедренный";
            var actual = Triangle.GoTriangle("3", "2", "2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test13() //Тест на определение равностороннего треугольника
        {
            var expect = "Равносторонний";
            var actual = Triangle.GoTriangle("3", "3", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test14() //Не введено одно значение из всех
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test15() //Одно отрицательное значение из всех
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "-2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test16() //Большие числовые значения
        {
            var expect = "Равносторонний";
            var actual = Triangle.GoTriangle("1000000", "1000000", "1000000");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test17() // Малые числовые значения
        {
            var expect = "Равнобедренный";
            var actual = Triangle.GoTriangle("0,06", "0,06", "0,1");
            Assert.That(actual.Item1, Is.EqualTo(expect));
        }

        [Test]
        public void Test18() //Тест на получение координат на дробных значениях
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("0,9", "7839043,7", "0,4");
            if(res.Item2[0] >= 0 && res.Item2[1] >= 0 && res.Item3[0] >= 0 && res.Item3[1] >= 0 && res.Item1[0] >= 0 && res.Item1[1] >= 0 ) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void Test19() //Тест на получение координат на целых значениях
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("1", "1", "1");
            if (res.Item2[0] >= 0 && res.Item2[1] >= 0 && res.Item3[0] >= 0 && res.Item3[1] >= 0 && res.Item1[0] >= 0 && res.Item1[1] >= 0) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void Test20() //Тест на масштабируемость
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("1000", "1000", "1000");
            if (res.Item2[0] <= 100 && res.Item2[1] <= 100 && res.Item3[0] <= 100 && res.Item3[1] <= 100 && res.Item1[0] <= 100 && res.Item1[1] <= 100) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }
       
    }
}