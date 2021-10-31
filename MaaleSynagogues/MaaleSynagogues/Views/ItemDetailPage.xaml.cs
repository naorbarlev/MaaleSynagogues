using MaaleSynagogues.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MaaleSynagogues.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}