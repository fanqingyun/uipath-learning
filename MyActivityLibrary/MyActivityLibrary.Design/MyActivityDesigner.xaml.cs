using Microsoft.Win32;
using System;
using System.Activities.Presentation.Metadata;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MyActivityLibrary.Design
{
    // MyActivityDesigner.xaml 的交互逻辑
    public partial class MyActivityDesigner
    {
        #region Constructors and Destructors 

        /// <summary> 
        /// Initializes a new instance of the <see cref="MyActivityDesigner"/> class. 
        /// </summary> 
        public MyActivityDesigner()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Methods 

        /// <summary> 
        /// Registers metadata. 
        /// </summary> 
        /// <param name="builder"> 
        /// The builder. 
        /// </param> 
        public static void RegisterMetadata(AttributeTableBuilder builder)
        {
            builder.AddCustomAttributes(
                typeof(MyActivity),
                new DesignerAttribute(typeof(MyActivityDesigner)),
                new DescriptionAttribute("My sample activity"),
                new ToolboxBitmapAttribute(typeof(MyActivity), "timg.jpg"));
        }

        #endregion

        private void fileBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            //dlg.Filter = "Excel Workbooks(*.xls;*xlsx;*xlsm)|*.xls[xm]?";
            dlg.Filter = "Excel Workbooks(*.xls;*xlsx;*xlsm)|*.xlsx";
            //  dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                filePath.Text = filename;
            }
        }
    }
}
