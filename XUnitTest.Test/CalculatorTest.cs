using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTest.APP;

namespace XUnitTest.Test
{
   public  class CalculatorTest
    {

        public Calculator calculator  { get; set; }

        public CalculatorTest( )
        {   
            this.calculator=new Calculator();
        }

        [Fact]
        //Test metotlarında birşey dönmüyorum.
         public void AddTest()
        {
            //Arrange ,Act ,Assert

            //Nesne örneği yada değişkenleri initialize edeceğim yer burasıdır.
            //to create object instance or this is the place that initiliaze values
            //Arrange
            int a = 5;
            int b = 20;
  

            //Arrange

            //Test edeceğimiz metotları çalıştıracağımız yerlerdir.
             //This is the place which we are going to test out methods
            //Act 
            var total=calculator.Add(a, b);

            //Act

            //Act evresinden çıkan sonucun benim beklediğim sonuç mu değil mi,doğrulama evresi
            //Checking expecting result and real returning result

            //Assert
            var names = new List<string>() { "Fatih", "Emre", "Hatice" };

            //Assert.Equal<int>(25, total);
            //Assert.Contains("Mustafa", "Mustafa Ulas");
            //Assert.Contains(names, a => a == "Emre");
            //checking  and comparing types
            //Assert.True("Ahmet".GetType() == typeof(string));

            //begins with "car" regex control
            //string value = null;
            //Assert.Null(value);
                
            var regex = "^car";
            Assert.Matches(regex, "car is red");
            //Assert

        }


        [Theory]
        [InlineData(2,5,7)]
        [InlineData(10, 2, 12)]
        public void AddWithParameterTest(int a,int b,int expectedTotal)
        {
    

            var actualData=calculator.Add(a,b);

            Assert.Equal(actualData,expectedTotal);

        }
    }
}
