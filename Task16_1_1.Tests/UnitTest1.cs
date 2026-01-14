namespace Task16_1_1.Tests

{
    using Task16_1_1;
    using Task16_6_1.Classes;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Addicional_MustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Additional(5, 4), Is.EqualTo(9));
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Subtraction(5, 4), Is.EqualTo(1));

        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Miltiplication(6, 7), Is.EqualTo(42));

        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Division(6, 2), Is.EqualTo(3));

        }
        [Test]
        public void Division_MustThrowException()
        {
            Calculator calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(8, 0));

        }
    }
}
