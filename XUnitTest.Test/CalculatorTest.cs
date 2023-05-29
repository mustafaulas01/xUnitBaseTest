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

        [Fact]
        //Test metotlarında birşey dönmüyorum.
         public void AddTest()
        {
            //Arrange ,Act ,Assert

            //Nesne örneği yada değişkenleri initialize edeceğim yer burasıdır.
            //Arrange
            int a = 5;
            int b = 20;
            var calculator =new Calculator();

            //Arrange

            //Test edeceğimiz metotları çalıştıracağımız yerlerdir.
            //Act 
            var total=calculator.Add(a, b);

            //Act

            //Act evresinden çıkan sonucun benim beklediğim sonuç mu değil mi,doğrulama evresi
            //Assert
            var names = new List<string>() { "Fatih", "Emre", "Hatice" };

            //Assert.Equal<int>(25, total);
            //Assert.Contains("Mustafa", "Mustafa Ulas");
              Assert.Contains(names, a => a == "Emre");
            //Assert

        }
    }
}
