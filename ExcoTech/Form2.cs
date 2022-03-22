using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcoTech
{
    public partial class Form2 : Form
    {
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);
        Bitmap CloseImage;

        public Form2()
        {
            InitializeComponent();

            TabPage tabPage3 = new TabPage();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.Padding = new Point(25, 5);
            CloseImage = ExcoTech.Properties.Resources.close.ToBitmap();
           // tabControl1.Padding = new Point(10, 3);

            tabControl1.Controls.Add(tabPage3);
            tabPage3.Text = "novo";
            //this.tabPage1.Location = new System.Drawing.Point(4, 22);
            //this.tabPage1.Name = "tabPage";
            //this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage1.Size = new System.Drawing.Size(792, 329);
            //this.tabPage1.TabIndex = 3;
            //this.tabPage1.Text = "tabPage1";


            tabPage3.UseVisualStyleBackColor = true;
            
            tabControl1.SelectedTab = tabPage2;

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("X", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 5);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();

            //    try
            //    {
            //        Image img = new Bitmap(CloseImage);
            //        Rectangle r = e.Bounds;
            //        r = this.tabControl1.GetTabRect(e.Index);
            //        r.Offset(2, 2);
            //        Brush TitleBrush = new SolidBrush(Color.Black);
            //        Font f = this.Font;
            //        string title = this.tabControl1.TabPages[e.Index].Text;

            //        e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

            //        if (tabControl1.SelectedIndex >= 1)
            //        {
            //            e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
            //        }
            //    }
            //    catch (Exception) { }


            //}

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = tabControl1.GetTabRect(this.tabControl1.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
            }

        }
    }
}
