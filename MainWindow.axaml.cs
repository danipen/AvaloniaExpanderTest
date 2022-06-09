using Avalonia.Controls;

using System;

namespace AvaloniaExpanderTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mExpander1.PropertyChanged += MExpander1_PropertyChanged;
            mExpander2.PropertyChanged += MExpander1_PropertyChanged;
            mExpander3.PropertyChanged += MExpander1_PropertyChanged;
            mExpander4.PropertyChanged += MExpander1_PropertyChanged;
        }

        private void MExpander1_PropertyChanged(object? sender, Avalonia.AvaloniaPropertyChangedEventArgs e)
        {
            if (e.Property != Expander.IsExpandedProperty)
                return;

            OnExpandedChanged(sender as Expander);
        }

        void OnExpandedChanged(Expander? expander)
        {
            if (expander == mExpander1)
            {
                mGrid.RowDefinitions[0].Height = (mExpander1.IsExpanded) ? GridLength.Star : GridLength.Auto;
            }
            if (expander == mExpander2)
            {
                mGrid.RowDefinitions[1].Height = (mExpander2.IsExpanded) ? GridLength.Star : GridLength.Auto;
            }
            if (expander == mExpander3)
            {
                mGrid.RowDefinitions[2].Height = (mExpander3.IsExpanded) ? GridLength.Star : GridLength.Auto;
            }
            if (expander == mExpander4)
            {
                mGrid.RowDefinitions[3].Height = (mExpander4.IsExpanded) ? GridLength.Star : GridLength.Auto;
            }
        }
    }
}
