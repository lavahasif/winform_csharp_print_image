using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load_printer();
        }

        void Load_printer()
        {
            var installedPrinters = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            string[] arrString = new string[installedPrinters.Count];
            installedPrinters.CopyTo(arrString, 0);

            if (arrString.Length > 0)
            {
                cmb_printer.DisplayMember = arrString[0];
                cmb_printer.Text = arrString[0];
                cmb_printer.ValueMember = arrString[0];
            }

            cmb_printer.Items.AddRange(arrString);
        }

        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(400, 720);
            e.Graphics.DrawImage(img, p);
        }

        void PrintImage2(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(900, 2250, 250, 250);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(900, 2250);
            e.Graphics.DrawImage(img, p);
        }

        void DrawImage2FloatRectF(object o, PrintPageEventArgs e)
        {
            // Create image.
            Image newImage = Image.FromFile("c:\\qr_doc.jpg");
            newImage = (Image)(new Bitmap(newImage, new Size(100, 100)));

            // Create coordinates for upper-left corner of image.
            float x = 3.74F;
            float y = 8.85F;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(0, 0, 830, 1130);
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, Convert.ToSingle(txt_left.Text), Convert.ToSingle(txt_top.Text), srcRect,
                units);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            if (cmb_printer.Text.Length > 0)
                pd.PrinterSettings.PrinterName = cmb_printer.Text;
            pd.PrintPage += new PrintPageEventHandler(DrawImage2FloatRectF);
            PaperSize ps = new PaperSize();
            ps.RawKind = (int)PaperKind.A4;

            pd.DefaultPageSettings.PaperSize = ps;

            pd.DefaultPageSettings.Landscape = false;

            pd.Print();
        }
    }
}