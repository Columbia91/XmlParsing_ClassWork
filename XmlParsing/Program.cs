using System;
using System.Xml;

namespace XmlParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("data.xml");

            var rootElement = xmlDocument.DocumentElement;

            City city = new City
            {
                Name = rootElement.GetElementsByTagName("name")[0].InnerText,
                Population = int.Parse(rootElement.GetElementsByTagName("population")[0].InnerText),
                IsCapital = bool.Parse(rootElement.GetElementsByTagName("isCapital")[0].InnerText),
                CountryName = rootElement.GetElementsByTagName("countryName")[0].InnerText
            };*/
            City city = new City
            {
                Name = "Алматы",
                Population = 2000000,
                IsCapital = false,
                CountryName = "Казахстан"
            };
            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("city");

            var nameElement = xmlDocument.CreateElement("name");
            nameElement.InnerText = city.Name;
            rootElement.AppendChild(nameElement);

            var populationElement = xmlDocument.CreateElement("population");
            populationElement.InnerText = city.Population.ToString();
            rootElement.AppendChild(populationElement);
            // и так далее и т.п.

            xmlDocument.AppendChild(rootElement);
            xmlDocument.Save("data2.xml");

            Console.ReadLine();
        }
    }
}
