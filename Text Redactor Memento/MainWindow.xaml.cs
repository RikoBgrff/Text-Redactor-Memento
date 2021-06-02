﻿using System;
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
using Text_Redactor_Memento.Models;

namespace Text_Redactor_Memento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Text player = new Text();
                player.Textt = TextTxtBx.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to undo");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Text text = new Text();
            text.Textt = TextTxtBx.Text;
            TextSaver saver = new TextSaver(text);
            saver.Save();
        }
    }
}
