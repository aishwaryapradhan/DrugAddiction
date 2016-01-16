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
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DrugAddiction
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

           this.SizeChanged += (a, b) =>
            {
                ApplicationViewState views = ApplicationView.Value;
                VisualStateManager.GoToState(this, views.ToString(), false);

            };
        }


        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(three));
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(one));
        }

        private void Grid_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(two));
        }

        private void Grid_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(three));
        }

        private void Grid_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(four));
        }

        private void Grid_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(five));
        }

        private void Grid_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(six));
        }

        private void Grid_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(seven));
        }

        private void Grid_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(web));
        }

        private void Grid_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(develop));
        }

 
     
    }
}
