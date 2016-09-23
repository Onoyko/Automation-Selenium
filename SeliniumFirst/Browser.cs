using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeliniumFirst {


    public static class Browser {

        private static string startUrl = "http://www.acumenci.com/";
        private static IWebDriver driver = new ChromeDriver();

        public static void Initialize () {
            GoToUrl("");
        }

        public static void CleanUp() {

            driver.Close();
        }
        public static void GoToUrl (string page) {

            driver.Url = startUrl + page;
        }

        public static void ContactPage() {

            GoToUrl("contact/");
        }

        public static void ClickButton(string elementType, string elementName) {
            if(elementType == "id") {

                    driver.FindElement(By.Id(elementName)).Click(); }

            else if(elementType == "name") {
                      
                    driver.FindElement(By.Name(elementName)).Click(); }

            else if(elementType == "class") {

                    driver.FindElement(By.ClassName(elementName)).Click(); }

            else {
                    Console.WriteLine("error"); }
            }
       

        public static void EnterText(string elementName, string value) {

            driver.FindElement(By.Name(elementName)).SendKeys(value);

            
        }

        public static bool VerifyElement(string value) {


            if (driver.PageSource.Contains(value)) {

                Console.WriteLine("Element " + value + "found");
                return true;
            }else
                Console.WriteLine("Element " + value + "was not Found");
            return false;
        }

        public static void Submit (string BUTTON_XPATH) {
            driver.FindElement(By.XPath(BUTTON_XPATH)).Click();
        }

        public static void Alerts (string error) {

            Thread.Sleep(5000);
            var error_message = driver.FindElement(By.Id(error)).Text;
            Console.WriteLine(error_message);


        }



            }


    }