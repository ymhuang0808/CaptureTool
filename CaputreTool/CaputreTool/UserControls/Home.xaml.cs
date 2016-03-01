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
using CaputreTool.ViewModels;
using CaputreTool.Models;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CaputreTool.UserControls
{
    public sealed partial class Home : UserControl
    {
        private Record _lastSelectedItem;
        private DemoRecordsViewModel demoRecordVM = new DemoRecordsViewModel();

        public Home()
        {
            this.InitializeComponent();
            this.DataContext = demoRecordVM.GetRecordItems(10);
        }

        private void AdaptiveState_CurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {

        }

        private void UpdateForVisualState(VisualState newState, VisualState oldState = null)
        {
            var isNarrow = newState = NarrowState;

           //
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = (Record)e.ClickedItem;
            _lastSelectedItem = clickedItem;
            DetailContentPresenter.Content = _lastSelectedItem;
        }
    }
}
