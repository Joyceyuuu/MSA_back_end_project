# MSA_back_end_project
Section One

    Two configuration files:
                    appsetting.json     
                    appsetting.Development.json
    Difference:
            appsetting.json is used for deault config, appsetting.Development.json is used for development enviroment. appsetting.json load the config setting from appsetting.Development.json.
Section Two
            Dependency injection make me easier to test and programming as I can install different packages. I don'need to write same method, string or function everytime I need use in different program file, simplify code.
Section Three
    Nunit test:
            I have two test case to test my testController
            1. When the input number is 0, HTTP will return BadRequestobjectResult.
            2. When the input number is 1, HTTP will return OkObjectResult.
    middleware libraries: Midleware libraries make code more simple. For unit test I can just test the function I need to test, there is no relate function or method occurs.

 
