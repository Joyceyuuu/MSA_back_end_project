using Joyce_back_end_project_MSA.Controllers;


using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AnimalCrossingTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            int inputNumber = 0;
           
            Testcontrollers testcontrollers = new Testcontrollers();


            testcontrollers.GetResult(inputNumber);


            string result = testcontrollers.GetResult(inputNumber).ToString();
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.BadRequestObjectResult", result);
            //arrage
            //AnimalCrossingController s = new AnimalCrossingController();

            // act
             //s.GetInputInfor(inputNumber);

            //assert
            // int checkInputNumber = 0;
            // Assert.AreEqual(outputNumber, checkInputNumber);



        }
    }
}