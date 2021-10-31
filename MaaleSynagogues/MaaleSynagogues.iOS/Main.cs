using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using MaaleSynagogues.Models;

namespace MaaleSynagogues.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            

            UIApplication.Main(args, null, "AppDelegate");



            Gabay gabay = new Gabay("Shimon","25554466");

            Pray shaharit = new Pray("shaharit", "6:30");

            

            Console.WriteLine(gabay.Name);
            gabay.Name = "Daivd";
            Console.WriteLine(gabay.Name);
            



        }
    }
}
