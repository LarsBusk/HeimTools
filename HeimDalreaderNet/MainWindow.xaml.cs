using System.Diagnostics;
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

namespace HeimDalreaderNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private JsonHelper helper;
        private string samplesFolder =
            "C:\\Users\\lab\\Projects\\GitHub\\HeimTools\\Full diagnostics - 2024-12-20 09.11.47.147\\Storage\\Json\\SampleRepository";
        public MainWindow()
        {
            
            InitializeComponent();
            helper = new JsonHelper();
            this.DataContext = helper;
        }

        private void ReadFiles(object sender, RoutedEventArgs e)
        {
            var ur = new Stopwatch();
            helper.Log("Start reading files");
            ur.Start();
            helper.GetSamples(samplesFolder);
            ur.Stop();
            helper.Log($"{helper.x} files are read. it lasted {ur.ElapsedMilliseconds} ms.");
        }
    }
}