using Xunit;
using System.Collections.Generic;



namespace Testingp1Storeapplication.tests;

public class UnitTest1
{
     

        [Theory]
    

        public static void MainMenu(int input)
        {

        }

        public static void LoginCheckSuccess()
        {
             //Arrange
            string s1 = "Welcome";
            string s2 = "jcevans";
            Login succcess = new Login();

            //Act
            string result = Program.Login();

            //Assert
            Assert.Equal("Welcome jcevans" , result);  
        }

        public static void RegisterAccount()
        {

        }

        public static void StoreOptions()
        {}

        public static void SelectStore()
        {}

        public static void Checkout()
        {}
}