using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutantexample;
using NUnit.Framework;


namespace testcases1
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            //1 test for addition
            [Test]
            public void GetAddition_Input0and0_Retur0()
            {
                //Arrange 
                double
                number1 = 0;
                double
                number2 = 0;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);





            }

            //2 case for addition 
            [Test]
            public void GetAddition_Input5point5and5point4_Returns10point0()
            {
                //Arrange 
                double
                number1 = 5.5;
                double
                number2 = 4.5;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            //3  test case for addition
            [Test]
            public void GetAddition_Input500and400_Returns900()
            {
                //Arrange 
                double
                number1 = 500;
                double
                number2 = 400;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }

            [Test]
            //1 case for subtraction 
            public void GetSubtraction_Input2and1_Returns1()
            {
                //Arrange 
                double
                number1 = 2;
                double
                number2 = 1;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            //2 case for subtraction
            [Test]
            public void GetSubtraction_Input400and200_Returns200()
            {
                //Arrange 
                double
                number1 = 400;
                double
                number2 = 200;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }

            //3 case for Subtraction
            [Test]
            public void GetSubtraction_Input0and0_Returns0point0()
            {
                //Arrange 
                double
                number1 = 0;
                double
                number2 = 0;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }


            //1 case for multiplication

            [Test]
            public void GetAddition_Input4point4and6point6_Returns29point4()
            {
                //Arrange 
                double
                number1 = 4.4;
                double
                number2 = 6.6;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }




            //2 case for M
            [Test]
            public void GetMultiplication_Input0and12_Returns0point0()
            {
                //Arrange 
                double
                number1 = 12;
                double
                number2 = 0;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
            //3 case for M
            [Test]
            public void GetMultiplication_Input4and5_Returns20()
            {
                //Arrange 
                double
                number1 = 5;
                double
                number2 = 4;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }





            [Test]
            public void GetDivision_Input0and5point6_Returns0()
            {
                //Arrange 
                double
                number1 = 0;
                double
                number2 = 5.6;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }

            [Test]
            public void GetDivision_Inputnegative2and5_Returnsnegative10()
            {
                //Arrange 
                double
                number1 = -2;
                double
                number2 = 5;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);


            }


            [Test]
            public void GetDivision_Input15and5_Returns3()
            {
                //Arrange 
                double
                number1 = 15;
                double
                number2 = 5;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }


            [Test]
            public void GetDivision_Input1and3_Returnszeropoint33()
            {
                //Arrange 
                double
                number1 = 1;
                double
                number2 = 3;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }


            [Test]
            public void GetDivision_Input2and1_Returns2()
            {
                //Arrange 
                double
                number1 = 15;
                double
                number2 = 5;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }

            [Test]
            public void GetDivision_Input9and3_Returns3()
            {
                //Arrange 
                double
                number1 = 9;
                double
                number2 = 3;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);

            }
        }

    }
}