using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xoom.Models;

namespace Xoom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyRecipients : ContentPage
    {
        public ObservableCollection<Recipient> Recipients { get; }
        public MyRecipients()
        {
            InitializeComponent();
            var recipient = new Recipient();
            var recipients = recipient.GetRecipients();
            Recipients = new ObservableCollection<Recipient>(recipients);
            BindingContext = this;
        }
    }
}