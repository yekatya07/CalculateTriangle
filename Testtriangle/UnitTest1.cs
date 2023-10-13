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
        public void Test1() //���� �� �� �����������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "0", "5");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test2() //���� �� ������ ��������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("", "", "");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test3() //���� �� �������� ������� ��������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("0", "0", "0");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test4() //���� �� ������������� ��������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("-1", "-1", "-1");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test5() //���� �� ��������� ��������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("�", "�", "�");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test6() //���� �� ���������� ��������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("@", "@", "@");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test7() //���� �� �������� ��������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("1", "2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test8() //���� �� �������� ������� ��������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("13,2", "2,4", "13,2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test9() //���� �� �������� ������� �������� � ������
        {
            var expect = "";
            var actual = Triangle.GoTriangle("13.2", "2.4", "13.2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test10() //���� �� ����������� �� ������������
        {
            var expect = "�� �����������";
            var actual = Triangle.GoTriangle("1", "8", "15");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test11() //���� �� ����������� ��������������� ������������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("1", "2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test12() //���� �� ����������� ��������������� ������������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("3", "2", "2");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test13() //���� �� ����������� ��������������� ������������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("3", "3", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test14() //�� ������� ���� �������� �� ����
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test15() //���� ������������� �������� �� ����
        {
            var expect = "";
            var actual = Triangle.GoTriangle("3", "-2", "3");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test16() //������� �������� ��������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("1000000", "1000000", "1000000");
            Assert.That(actual.Item1, Is.EqualTo(expect)); ;
        }

        [Test]
        public void Test17() // ����� �������� ��������
        {
            var expect = "��������������";
            var actual = Triangle.GoTriangle("0,06", "0,06", "0,1");
            Assert.That(actual.Item1, Is.EqualTo(expect));
        }

        [Test]
        public void Test18() //���� �� ��������� ��������� �� ������� ���������
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("0,9", "7839043,7", "0,4");
            if(res.Item2[0] >= 0 && res.Item2[1] >= 0 && res.Item3[0] >= 0 && res.Item3[1] >= 0 && res.Item1[0] >= 0 && res.Item1[1] >= 0 ) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void Test19() //���� �� ��������� ��������� �� ����� ���������
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("1", "1", "1");
            if (res.Item2[0] >= 0 && res.Item2[1] >= 0 && res.Item3[0] >= 0 && res.Item3[1] >= 0 && res.Item1[0] >= 0 && res.Item1[1] >= 0) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }

        [Test]
        public void Test20() //���� �� ����������������
        {
            bool expect = true;
            bool actual = false;
            var res = Triangle.GoTriangle("1000", "1000", "1000");
            if (res.Item2[0] <= 100 && res.Item2[1] <= 100 && res.Item3[0] <= 100 && res.Item3[1] <= 100 && res.Item1[0] <= 100 && res.Item1[1] <= 100) actual = true;
            Assert.That(actual, Is.EqualTo(expect));
        }
       
    }
}