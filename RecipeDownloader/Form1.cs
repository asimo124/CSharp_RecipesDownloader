using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeDownloader
{
    public partial class Form1 : Form
    {
        private Int16 counter = 1;
        private bool didSetUrl = false;
        private bool pageDidLoad = true;
       



        private String[] links = {
            "https://www.homechef.com/meals/sirloin-and-mushroom-demi-glace-standard",
"https://www.homechef.com/meals/broccoli-cheddar-crusted-chicken-0827916d-f393-468b-9ea1-a64b33b274c6",
"https://www.homechef.com/meals/chicken-and-black-bean-soup-cae55010-9640-4497-9c5d-65c5ac6927c0",
"https://www.homechef.com/meals/maui-pork-tostadas-standard",
"https://www.homechef.com/meals/mahi-mahi-and-tuscan-herb-sauce-3a38f823-0549-4278-97c1-8fc6ebc94842",
"https://www.homechef.com/meals/chicken-breast-and-caramelized-shallot-demi-standard",
"https://www.homechef.com/meals/mushroom-steak-flautas",
"https://www.homechef.com/meals/new-orleans-shrimp-roll-85990286-cbc7-473f-829b-c48834da44f1"
        };

        public Form1()
        {
            InitializeComponent();
            this.wbBrowser1.ScriptErrorsSuppressed = true;
        }

        private void continueDownload()
        {
            if (this.pageDidLoad)
            {
                this.pageDidLoad = false;

                System.Threading.Thread.Sleep(5000);

                String html = this.wbBrowser1.DocumentText;

                //*/
                string path = @"C:\Temp\RecipesDownloaderApp\recipe" + counter.ToString() + ".html";
                if (!System.IO.File.Exists(path))
                {
                    // Create a file to write to.
                    using (System.IO.StreamWriter sw = System.IO.File.CreateText(path))
                    {
                        sw.WriteLine(html);
                    }
                }
                counter++;

                Console.WriteLine("links.length: " + this.links.Length);
                this.links = this.links.Skip(1).ToArray();
                Console.WriteLine("links.length after: " + this.links.Length);

                
                //*/
                if (this.links.Length > 0)
                {
                    this.downloadRecipes();
                }
                else
                {
                    Console.WriteLine("Script Completed.");
                }
            }
        }


        private void wbBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("e: " + e.ToString());

            //Check if page is fully loaded or not
            if (this.wbBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                return;
            }
            else
            {
                Console.WriteLine("didSetUrL: " + this.didSetUrl);
                if (this.didSetUrl)
                {
                    this.didSetUrl = false;
                    this.pageDidLoad = true;

                   
                    this.continueDownload();
                }
            }
        
        }



        private void downloadRecipes()
        {
            String link = this.links[0];

            this.didSetUrl = true;
            this.wbBrowser1.Url = new Uri(link);

            wbBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wbBrowser1_DocumentCompleted);



        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            this.downloadRecipes();
        }
    }
}
