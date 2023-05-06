using EasyAutomationFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraper.Classes;

namespace WebScraper.Driver
{
    public class WebScraperBlaze : Web
    {
        public DataTable GetData(string link)
        {
            bool staleElement = true;

            if(driver == null)
                StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\Administrator\\AppData\\Local\\Google\\Chrome\\User Data");

            List<Item> items = new List<Item>();

            Navigate(link);

            WaitForLoad();

            Thread.Sleep(5000);

            while (staleElement)
            {
                try
                {
                    var generalElements = GetValue(TypeElement.Xpath, "//*[@id=\"crash-recent\"]", 10)
                        .element.FindElement(By.ClassName("crash-previous"));

                    var crashElements = generalElements.FindElements(By.ClassName("entries"));
                    foreach (var item in crashElements)
                    {
                        Item itemCrash = new Item();
                        itemCrash.Multiplicador = item.FindElement(By.XPath("//*[@id=\"crash-recent\"]/div[2]/div[2]/span[1]")).Text;
                        //.FindElement(By.XPath("//*[@id=\"crash-recent\"]/div[2]/div[2]/span[1]")).Text);

                        items.Add(itemCrash);

                        staleElement = true;

                        Console.WriteLine(itemCrash.Porcentagem);
                        //Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    staleElement = false;
                    CloseBrowser();
                    throw;
                }                

            }
            
            

            return Base.ConvertTo(items);            
        }
    }
}
