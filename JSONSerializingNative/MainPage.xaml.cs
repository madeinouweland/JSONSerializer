using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using Windows.UI.Xaml;

namespace JSONSerializingNative
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var json = "{\"Employees\":[{\"Age\":35,\"Name\":\"Vera\"},{\"Age\":41,\"Name\":\"Chuck\"},{\"Age\":26,\"Name\":\"Dave\"}],\"Name\":\"Toverstudio\"}";

            var serializer = new JSONSerializer<Company>();
            var company = serializer.Deserialize(json);

            company.Name = "Aliens Bring Change";

            var json2 = serializer.Serialize(company);
            Debug.WriteLine(json2);
        }
    }
}
