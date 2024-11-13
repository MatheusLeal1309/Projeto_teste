namespace Projeto_testes
{
    public class UnitTest1
    {
        [Fact]
        public void TestArea()
        {
            Projeto_teste.Rectangle rectangle = new Projeto_teste.Rectangle(2, 3);
            double ExpectedArea = 6;
            double ResultArea = rectangle.getArea();
            Assert.Equal(ExpectedArea, ResultArea);

        }

        [Fact]
        public void TestPerimetro()
        {
            Projeto_teste.Quadrado rectangle = new Projeto_teste.Quadrado(1);
            double ExpectedArea = 4;
            double ResultPerimetro = rectangle.getPerimetro();
            Assert.Equal(ExpectedArea, ResultPerimetro);

        }
    }
}