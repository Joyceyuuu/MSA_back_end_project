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

        /// <summary>
        /// If input number = 0, the result will be 'bad request'
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Test1()
        {
            int inputNumber = 0;
           
            Testcontrollers testcontrollers = new Testcontrollers();
            testcontrollers.GetResult(inputNumber);
            string result = testcontrollers.GetResult(inputNumber).ToString();
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.BadRequestObjectResult", result);
        }


        /// <summary>
        /// If input number is 1, get OK status as respone.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Test2()
        {
            int inputNumber = 1;

            Testcontrollers testcontrollers = new Testcontrollers();
            testcontrollers.GetResult(inputNumber);
            string result = testcontrollers.GetResult(inputNumber).ToString();
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.OkObjectResult", result);
        }
    }
}