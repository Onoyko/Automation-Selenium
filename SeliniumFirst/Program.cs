using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeliniumFirst {
    class Program {

        static void Main(string[] args) {



        }

        [Test]
        public void CanFindThePostCode () {

            //initialize the start page
            Browser.Initialize();
            Browser.ClickButton("id", "menu-item-497");
            //find the requested element on the page
            Browser.VerifyElement("TW9 1HY");
            //close browser
            Browser.CleanUp();
        }
        [Test]
        public void CanSeeAlerts (){
            //go to cotnact page
            Browser.ContactPage();
            //enter email
            Browser.EnterText("your-email", "xxx@xx.xx");
            //enter text
            Browser.EnterText("your-message", "some text");
            //press submit
            Browser.Submit("//*[@id='wpcf7-f682-p495-o1']/form/p[8]/input");
            //check for alerts
            Browser.Alerts("wpcf7-f682-p495-o1");
            Browser.CleanUp();
        }
        
    }


}
