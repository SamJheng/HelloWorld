using HelloWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld.Views
{
    /// <summary>
    /// Interaction logic for LineProgressBar.xaml
    /// </summary>
    public partial class LineProgressBar : UserControl
    {
        LineProgressViewModel model;
        public LineProgressBar()
        {
            InitializeComponent();
            model = new LineProgressViewModel();
            DataContext = model;
        }
        public static readonly DependencyProperty ProgressValueProperty =
            DependencyProperty.Register("ProgressValue",
                typeof(double),
                typeof(LineProgressBar),
                new FrameworkPropertyMetadata()
                {
                    PropertyChangedCallback = OnValueChanged
                }
        );
        public double ProgressValue
        {
            get => (double)GetValue(ProgressValueProperty);
            set => SetValue(ProgressValueProperty, value);
        }
        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            LineProgressBar thisobj = (LineProgressBar)obj;
            LineProgressViewModel thisobjContext = ((LineProgressViewModel)thisobj.DataContext);
            thisobjContext.ProgressValue = (double)e.NewValue;
            Console.WriteLine(thisobjContext.ProgressValue);
        }
    }
}
