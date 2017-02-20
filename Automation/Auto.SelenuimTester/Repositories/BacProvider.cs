using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.SelenuimTester.Repositories
{


    class BacProvider
    {
        public static void Set(IWebDriver driver, string element, ItemType type, Actions action, string value = "")
        {
            switch (type)
            {
                case ItemType.ID:
                    driver.FindElement(By.Id(element)).AppendAction(action, value);
                    break;
                case ItemType.Name:
                    driver.FindElement(By.Name(element)).AppendAction(action, value);
                    break;
                case ItemType.Class:
                    driver.FindElement(By.ClassName(element)).AppendAction(action, value);
                    break;               
                default: break;
            }
        }

        public static void SelectDropDown(IWebDriver driver, string element, Actions action, string value = "")
        {

            var selectItem = new SelectElement(driver.FindElement(By.Id(element)));
            selectItem.AppendAction(action, value);
        }

    }

    static class BacExtensions
    {
        public static void AppendAction(this IWebElement element, Actions action, string value = "")
        {
            switch (action)
            {
                case Actions.SendKey:
                    element.SendKeys(value);
                    break;
                case Actions.Click:
                    element.Click();                    
                    break;
                default: break;
            }
        }

        public static void AppendAction(this SelectElement element, Actions action, string value = "")
        {
            switch (action)
            {
                case Actions.SelectByText:
                    element.SelectByText(value);
                    break;
                case Actions.SelectByValue:
                    element.SelectByValue(value);
                    break;
                case Actions.SelectByIndex:
                    element.SelectByIndex(string.IsNullOrEmpty(value) ? 0 : Convert.ToInt32(value));
                    break;
                default: break;
            }
        }

    }

}
