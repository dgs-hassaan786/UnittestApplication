using Auto.SelenuimTester.Repositories;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Auto.SelenuimTester
{
    [TestFixture]
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        public static void Main()
        {

            //Console.Write("Enter Text: ");
            //var text = Console.ReadLine();

            //Console.Write("Enter Key: ");
            //var key = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Encode or decode(0 or 1): ");
            //var code = Convert.ToInt32(Console.ReadLine());

            //char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            //var txtAZ = text.Select(i => (Char)i).ToArray();

            ////var convertedArray = new Char[txtAZ.Length];

            //var strBuilder = new StringBuilder();

            //for(var i =0; i < txtAZ.Length; i++)
            //{
            //    //ykzmyquetmeemmz
            //    //convertedArray[i] = az[(Array.IndexOf(az, txtAZ[i]) % 26)];
            //    strBuilder.Append(az[( (code == 0 ? (Array.IndexOf(az, txtAZ[i]) + key) : (Array.IndexOf(az, txtAZ[i]) - key) < 0 ? (26 - (Array.IndexOf(az, txtAZ[i]) - key)) : (Array.IndexOf(az, txtAZ[i]) - key)) % 26)]);
            //}

            //Console.WriteLine($"Converted text: { strBuilder.ToString() }");
            //Console.ReadLine();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["MainUrl"]);
        }       

        [Test]
        public void BacLoginTestSuccess()
        {
            BacProvider.Set(driver, "Email", ItemType.ID, Actions.SendKey, "noman.nazar@dgsworld.com");
            BacProvider.Set(driver, "Password", ItemType.ID, Actions.SendKey, "test777");
            BacProvider.Set(driver, "signinbtn", ItemType.ID, Actions.Click);
        }

        [Test]
        public void BacLoginTestFailUsername()
        {
            BacProvider.Set(driver, "Email", ItemType.ID, Actions.SendKey, "");
            BacProvider.Set(driver, "Password", ItemType.ID, Actions.SendKey, "test777");
            BacProvider.Set(driver, "signinbtn", ItemType.ID, Actions.Click);
        }

        [Test]
        public void BacLoginTestFailPassword()
        {
            BacProvider.Set(driver, "Email", ItemType.ID, Actions.SendKey, "noman.nazar@dgsworld.com");
            BacProvider.Set(driver, "Password", ItemType.ID, Actions.SendKey, "");
            BacProvider.Set(driver, "signinbtn", ItemType.ID, Actions.Click);
        }

        [Test]
        public void BacLoginTestFailIncorrect()
        {
            BacProvider.Set(driver, "Email", ItemType.ID, Actions.SendKey, "noman.nazar@dgsworld.com");
            BacProvider.Set(driver, "Password", ItemType.ID, Actions.SendKey, "adasd");
            BacProvider.Set(driver, "signinbtn", ItemType.ID, Actions.Click);
        }

        [TearDown]
        public void CleanUp()
        {
            //Close the driver
            //uncomment this code if want to automatically close the drive
            //driver.Close();
            driver.Quit();
            Console.WriteLine("Closed the browser.");
        }
    }
}
