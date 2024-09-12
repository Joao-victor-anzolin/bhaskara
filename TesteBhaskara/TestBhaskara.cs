namespace TesteBhaskara
{
    public class TestBhaskara
    {
        [Fact]
        public void Test1()
        {
            double a = 8;
            double b = 10;
            double c = 3;

            var raizes = Bhaskara.CalculadoraBhaskara.CalcularRaiz(a, b, c);

            Assert.Equal(raizes, Bhaskara.CalculadoraBhaskara.CalcularRaiz(a, b, c));
        }
    }
}