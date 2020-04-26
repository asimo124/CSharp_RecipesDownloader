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
            "https://www.homechef.com/meals/asiago-crusted-chicken-with-almond-romesco-broccoli-1f307f7e-5db9-4bf3-b4cc-d9451ba5ce57",
            "https://www.homechef.com/meals/balsamic-fig-chicken-with-zucchini-and-grape-tomatoes",
            "https://www.homechef.com/meals/herbes-de-provence-chicken-9d3404a4-09f3-464a-a079-65627227124a",
            "https://www.homechef.com/meals/mushroom-smothered-salisbury-steak-with-cheddar-jack-broccoli-486e872e-8b61-4d80-8f53-601960b02f79",
            "https://www.homechef.com/meals/caesar-chicken-with-parmesan-green-beans",
            "https://www.homechef.com/meals/honey-mustard-glazed-salmon-2e894f60-d0b3-4bc2-a3a5-46666537e9e7",
            "https://www.homechef.com/meals/rockefeller-salmon-f2313b79-bc4d-42d0-a992-6b32cc861043",
            "https://www.homechef.com/meals/tortilla-crusted-pork-chop",
            "https://www.homechef.com/meals/dijon-cider-vinaigrette-chicken-with-feta-asparagus-e6aab7bd-b2e6-4ccf-a6cb-6a8fd3e19350",
            "https://www.homechef.com/meals/chicken-breast-with-cilantro-butter-standard",
            "https://www.homechef.com/meals/chicken-adobo-flautas-fa3e2300-404c-4eec-995b-cb6d2ef13d92",
            "https://www.homechef.com/meals/hot-honey-salmon-4b2532b0-1f2d-430a-83e3-80a8ccb78e26",
            "https://www.homechef.com/meals/shiitake-sirloin-steak-and-lemon-hollandaise-standard",
            "https://www.homechef.com/meals/honey-butter-pork-chop-with-parmesan-broccoli-standard",
            "https://www.homechef.com/meals/jalapeno-popper-sliders-with-potatoes-standard",
            "https://www.homechef.com/meals/ginger-ponzu-salmon-8f18d75b-2355-4ec4-a7d8-6ff45f008ee7",
            "https://www.homechef.com/meals/golden-bbq-pork-meatballs-with-cheddar-jack-potatoes",
            "https://www.homechef.com/meals/caprese-chicken-breast-with-parmesan-green-beans-standard",
            "https://www.homechef.com/meals/honey-balsamic-chicken-breast-with-tomato-parmesan-salad-ffc5a2e7-0167-4797-8197-f6f8bf98693a",
            "https://www.homechef.com/meals/salmon-with-lemon-piccata-butter-standard",
            "https://www.homechef.com/meals/sirloin-and-mushroom-demi-glace",
            "https://www.homechef.com/meals/pork-chop-with-apple-bacon-shallot-jam-standard",
            "https://www.homechef.com/meals/tomato-and-poblano-salad-with-chipotle-ranch-and-crispy-tortillas",
            "https://www.homechef.com/meals/asiago-turkey-meatballs-with-tomato-basil-couscous-standard",
            "https://www.homechef.com/meals/peach-bbq-chicken-breast-standard",
            "https://www.homechef.com/meals/marsala-mushroom-smothered-bone-in-pork-chop-d8b4c5e2-156b-49d6-8e8e-a4a375dfffba",
            "https://www.homechef.com/meals/chicken-thigh-tinga-tacos-04f96016-e898-497a-8665-2108863a2384",
            "https://www.homechef.com/meals/pork-medallions-with-fig-glaze-and-goat-cheese-asparagus-bd99acf0-db99-4b0e-9a86-ff22ec92aaac",
            "https://www.homechef.com/meals/apple-cider-chicken-with-zucchini-corn-4b612b80-4855-425e-b060-c0b29ef2aa58",
            "https://www.homechef.com/meals/pepita-crusted-chicken-with-chipotle-demi-glace-ee957106-d3e7-4abf-abee-e6c519fa2676",
            "https://www.homechef.com/meals/panko-crusted-boom-boom-chicken-with-sesame-broccoli-98291a3e-cf97-44e1-af8e-68044f895562",
            "https://www.homechef.com/meals/buttermilk-ranch-taco-salad",
            "https://www.homechef.com/meals/caprese-burger-standard",
            "https://www.homechef.com/meals/apple-butter-chicken-and-butternut-squash-with-goat-cheese-and-almonds",
            "https://www.homechef.com/meals/tuscan-tomato-bolognese-risotto-with-mushrooms-and-shaved-parmesan-fresh-and-easy",
            "https://www.homechef.com/meals/herbes-de-provence-chicken-44d2402e-6a3c-4862-a0a1-3e3d12653ef4",
            "https://www.homechef.com/meals/creamy-salsa-verde-taco-salad-fresh-and-easy",
            "https://www.homechef.com/meals/apple-butter-pork-chop-with-white-cheddar-green-beans-fresh-and-easy",
            "https://www.homechef.com/meals/acapulco-steak-quesadillas",
            "https://www.homechef.com/meals/buttery-brown-sugar-pork-medallions",
            "https://www.homechef.com/meals/cranberry-glazed-chicken-with-roasted-green-bean-and-wild-rice-casserole",
            "https://www.homechef.com/meals/santa-fe-pork-and-potato-stew",
            "https://www.homechef.com/meals/steak-au-poivre-standard",
            "https://www.homechef.com/meals/chicken-with-beurre-blanc-standard",
            "https://www.homechef.com/meals/salmon-with-dill-crema",
            "https://www.homechef.com/meals/honey-miso-chicken-with-sesame-broccoli",
            "https://www.homechef.com/meals/pineapple-pepper-jelly-pork-chops-with-bok-choy-and-bell-peppers",
            "https://www.homechef.com/meals/chicken-breast-with-cilantro-butter"
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

                System.Threading.Thread.Sleep(1500);

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
