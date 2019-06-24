using System;
using System.Collections.Generic;
using System.IO;
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

namespace TestDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_selectrtffile_Click(object sender, RoutedEventArgs e)
        {
            var rtf = File.ReadAllText(@"C:\Users\Administrator\Desktop\test.rtf");

            var htmlOutput = @"D:\test12.html";
            var contentUriPrefix = Path.GetFileNameWithoutExtension(htmlOutput);
            var htmlResult = RtfToHtmlConverter.RtfToHtml(rtf, contentUriPrefix);
            htmlResult.WriteToFile(htmlOutput);
        }
    }
}
