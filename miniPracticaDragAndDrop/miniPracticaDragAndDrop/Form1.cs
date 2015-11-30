using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPracticaDragAndDrop
{
    public partial class Form1 : Form
    {
        private Object dropTypeAux;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
            {
                DoDragDrop(((TextBox)sender).Text, DragDropEffects.All);
                dropTypeAux = ((TextBox)sender);
            }
            if ( sender is ListBox)
            {
                if (sender != null)
                {
                    DoDragDrop(((ListBox)sender).SelectedItem, DragDropEffects.All);
                    dropTypeAux = ((ListBox)sender);
                }
            }
            if ( sender is ListView)
            {
                if (sender != null)
                {
                    DoDragDrop(((ListView)sender).SelectedItems, DragDropEffects.All);
                    dropTypeAux = ((ListView)sender);
                }
            }
            
        }

        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect=DragDropEffects.All;
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            if ( !(dropTypeAux is ListView) )
            {
                if (sender is TextBox)
                {
                    ((TextBox)sender).Text = (String)e.Data.GetData(DataFormats.Text);
                }
                if (sender is ListBox)
                {
                    ((ListBox)sender).Items.Add( (String)e.Data.GetData(DataFormats.Text) );
                }
                if (sender is ListView)
                {
                    ((ListView)sender).Items.Add( (String)e.Data.GetData(DataFormats.Text) );
                }
            }
            else
            {
                if (sender is TextBox)
                {
                    ((TextBox)sender).Text = ((ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)) )[0].Text;
                }
                if (sender is ListBox)
                {
                    ((ListBox)sender).Items.Add( ((ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)) )[0].Text);
                }
                if (sender is ListView)
                {
                    foreach ( ListViewItem i in (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection)) )
                    {
                        ((ListView)sender).Items.Add(i);
                    }
                }
            }
        }

        private void listView_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }
    }
}
