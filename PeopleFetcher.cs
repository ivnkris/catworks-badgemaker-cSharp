using System;
using System.Net;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class PeopleFetcher
    {
        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient())
            {
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                Console.WriteLine(response);
            }

            return employees;
        }
    }
}