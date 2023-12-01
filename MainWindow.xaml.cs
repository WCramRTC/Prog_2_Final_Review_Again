using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_2_Final_Review_Again
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> names;
        List<Gift> _santasBag;

        public MainWindow()
        {
            InitializeComponent();

            names = new List<string>
            {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Eva",
                "Frank",
                "Grace",
                "Helen",
                "Ivan",
                "Jack",
                "Katie",
                "Liam",
                "Mia",
                "Noah",
                "Olivia", // Removed the extra comma here
                "Nora",
                "Lucas"
            };





            // attach your list to the .ItemsSource
            lbDisplay.ItemsSource = names;
            cbDisplay.ItemsSource = names;
            //--------------------------------------------------------

            _santasBag = new List<Gift>();
            Gift puppy = new Gift("Puppy", "Cat", "Yes", "Corgi");
            _santasBag.Add(puppy);
            _santasBag.Add(new Gift("Bottle", "Apples", "No", "Mochi"));

            listViewDisplay.ItemsSource = _santasBag;


        }
    }
}