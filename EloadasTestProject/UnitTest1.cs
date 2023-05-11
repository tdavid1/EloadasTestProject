using EloadasTest;

namespace EloadasTestProject
{
    public class Tests
    {
        Eloadas eloadas;
        [SetUp]
        public void Setup()
        {
            eloadas = new Eloadas(3, 4);
        }

        [Test]
        public void Test1()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                eloadas.lefoglal();
            });
        }
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                eloadas.szabadhelyek();
            });
        }
        public void Test3()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                eloadas.Foglalt(-1, 0);
            });
        }
        public void Test4()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                eloadas.Foglalt(5, 1);
            });
        }
        public void Test5()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                eloadas.Foglalt(2, 2);
            });
        }
    }
}