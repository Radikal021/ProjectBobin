using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    public enum DigitalStyle
    {
        Default,
        CleanWhite,
        Cosmic,
        Smart,
        Progressive,
        Eco,
        Future,
        Classic,
        YellowSubmarine,
        MagicLight
    }

    public class HMIDigital : Control
    {
        public static readonly DependencyProperty ValueProperty =
           DependencyProperty.Register("Value", typeof(double), typeof(HMIDigital), new PropertyMetadata(default(double)));

        public static readonly DependencyProperty DigitalStyleProperty =
            DependencyProperty.Register("DigitalStyle", typeof(DigitalStyle), typeof(HMIDigital), new PropertyMetadata(DigitalStyle.Progressive));

        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(HMIDigital), new PropertyMetadata(6));

        public static readonly DependencyProperty TextColorProperty =
            DependencyProperty.Register("TextColor", typeof(Color), typeof(HMIDigital), new PropertyMetadata(Colors.Red));


        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(HMIDigital), new PropertyMetadata(null));

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Text")]
        [Description("Set/Get the text")]
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Value")]
        [Description("Set/Get the value")]
        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Count")]
        [Description("Set/Get the count")]
        public int Count
        {
            get => (int)GetValue(CountProperty);
            set => SetValue(CountProperty, value);
        }

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Digital Style")]
        [Description("Set/Get the digital style")]
        public DigitalStyle DigitalStyle
        {
            get => (DigitalStyle)GetValue(DigitalStyleProperty);
            set => SetValue(DigitalStyleProperty, value);
        }

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Text Color")]
        [Description("Set/Get the text color")]
        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(HMIDigital), new PropertyMetadata(12.0));

        [Browsable(true)]
        [Category("HMI Professional")]
        [DisplayName("Font Size")]
        [Description("Set/Get the font size")]
        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }




        static HMIDigital()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HMIDigital), new FrameworkPropertyMetadata(typeof(HMIDigital)));
        }
    }
}

