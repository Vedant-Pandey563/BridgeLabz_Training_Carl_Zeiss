using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {

        //arrange
        private Calculator _calculator;
        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        //cleanup 
        [TestCleanup]
        public void Cleanup()
        {
            _calculator = null;
        }


        //addition
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnCorrectSum()
        {
            //add
            int result = _calculator.Add(10, 5);
            //asert
            Assert.AreEqual(15, result);
        }

        //multiple add tests
        [TestMethod]
        [DataRow(10, 5, 15)]
        [DataRow(-5, -5, -10)]
        [DataRow(0, 0, 0)]
        [DataRow(-3, 3, 0)]
        [DataRow(int.MaxValue, 0, int.MaxValue)]
        public void Add_ValidInputs_ReturnsCorrectSum(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        //overflow add test 
        [TestMethod]
        [TestCategory("Overflow")]
        public void Add_WhenOverflowOccurs_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() =>
                _calculator.Add(int.MaxValue, 1));
        }

        //long addition 
        [TestMethod]
        [TestCategory("Long")]
        public void Add_LongValues_ReturnsCorrectResult()
        {
            long result = _calculator.Add(5000000000L, 9000000000L);
            Assert.AreEqual(14000000000L, result);
        }


        //subtraction

        [TestMethod]
        public void Subtract_ValidInputs_ReturnsCorrectDifference()
        {
            int result = _calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_WhenALessThanB_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Subtract(2, 5));
        }

        //multiple sub tests
        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(100, 0, 100)]
        [DataRow(7, 7, 0)]
        public void Subtract_ValidInputs_ReturnsCorrectDifference(int a, int b, int expected)
        {
            int result = _calculator.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }


        //multiply 


        //nultiple multiply methods 
        [TestMethod]
        [DataRow(3, 5, 15)]
        [DataRow(-3, 5, -15)]
        [DataRow(-4, -5, 20)]
        [DataRow(0, 100, 0)]
        public void Multiply_ValidInputs_ReturnsCorrectProduct(int a, int b, int expected)
        {
            int result = _calculator.Multiply(a, b);
            Assert.AreEqual(expected, result);
        }

        //multilply overflow test 
        [TestMethod]
        [TestCategory("Overflow")]
        public void Multiply_WhenOverflowOccurs_ThrowsOverflowException()
        {
            Assert.Throws<OverflowException>(() =>
                _calculator.Multiply(int.MaxValue, 2));
        }



        //division 


        [TestMethod]
        public void Divide_ByZero_ThrowsDividebyZeroException()
        {
            var ex = Assert.Throws<DivideByZeroException>(() =>
                _calculator.Divide(10, 0));

            Assert.AreEqual("Denominator cant be 0", ex.Message);
        }


        [TestMethod] //happy path
        public void Divide_ValidInputs_ReturnCorrectQuotient()
        {
            int result = _calculator.Divide(10, 2);

            Assert.AreEqual(5, result);
        }
        

        //multiple divides
        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(9, 3, 3)]
        [DataRow(0, 5, 0)]
        public void Divide_ValidInputs_ReturnsCorrectQuotient(int a, int b, int expected)
        {
            int result = _calculator.Divide(a, b);
            Assert.AreEqual(expected, result);
        }

        //data row tests

        [TestMethod]
        [DataRow(4,true)]
        [DataRow(5,false)]
        [DataRow(0,true)]
        [DataRow(-2,true)]
        [DataRow(-3,false)]

        public void IsEven_VariousNumbers_ReturnExpectedResult(int number, bool expected)
        {
            bool result = _calculator.IsEven(number);
            Assert.AreEqual(expected, result);
        }

        //test context , logging and delogging
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void SomeTest()
        {
            TestContext.WriteLine($"Running: {TestContext.TestName}");
            TestContext.WriteLine($"Test Dir: {TestContext.TestResultsDirectory}");
        }

    }
 }

