using Semana5.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Semana5.Views
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