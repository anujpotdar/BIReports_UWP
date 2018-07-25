using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BI_Reports
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Reports = new List<Report>
            {
                new Report { reportName = "Report1", unassigned = "unassignedField", url = "https://app.powerbi.com/view?r=eyJrIjoiMWJlM2VkNDMtYmNiYS00ZWJiLWEzNDMtY2M4MWI2Yjg5ZGQ2IiwidCI6ImQ3OGFlZTMyLThmOTEtNGY5ZS05MGVhLWZiNzI5NjVkOWQ3YyIsImMiOjZ9" },
                new Report { reportName = "Report2", unassigned = "unassignedField", url = "https://storage.googleapis.com/avengerbot-87892.appspot.com/Customer%20Profitability%20Sample.xlsx" },
                new Report { reportName = "Report3", unassigned = "unassignedField", url = "https://sheet.zoho.com/sheet/editor.do?doc=cdec2dbf5ffcc0f805039d615db317f1385f3b3b63ddbe8dd26e2ae89e24cb97e6338a3c5f236f1fd10984ddf3cacb56576e45491d14e3743a91312ef819bf96" }
            };
            this.InitializeComponent();

        }

        private ICollection<Report> Reports { get; set; }

        private void WebView1_Loading(FrameworkElement sender, object args)
        {

        }
    }
}
