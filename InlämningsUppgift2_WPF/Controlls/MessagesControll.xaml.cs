using InlämningsUppgift2_WPF.Views;
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
    /// Interaction logic for MessagesControll.xaml
    /// </summary>
    public partial class MessagesControll : UserControl
    {
        public MessagesControll()
        {
            InitializeComponent();
        }

        public string MessagesName
        {
            get { return messagesName.Text; }
            set { messagesName.Text = value; }

        }

        public string MessagesDescription
        {
            get { return messagesDescription.Text; }
            set { messagesDescription.Text = value; }
        }

        public string MessagesDate
        {
            get { return messagesDate.Text; }
            set { messagesDate.Text = value; }
        }

        public string MessagesTime
        {
            get { return messagesTime.Text; }
            set { messagesTime.Text = value; }
        }

        
    }
}
