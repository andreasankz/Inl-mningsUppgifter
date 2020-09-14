using System;
using System.Collections.Generic;
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

namespace InlämningsUppgift2_WPF.Controlls
{
    /// <summary>
    /// Interaction logic for ContactsControll.xaml
    /// </summary>
    public partial class ContactsControll : UserControl
    {
        public ContactsControll()
        {
            InitializeComponent();
        }

        public string ContactImage
        {
            get { return contactImage.Text; }
            set { contactImage.Text = value; }
        }

        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail.Text; }
            set { contactEmail.Text = value; }
        }

    }
}
