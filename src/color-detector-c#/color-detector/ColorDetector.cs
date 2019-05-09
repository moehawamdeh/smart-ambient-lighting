using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows;
using AForge.Imaging.Filters;


namespace colordetector
{
    public class ColorDetector
    {
        public Int32 color;
        private PresentationMode mode = PresentationMode.photographic;
        internal PresentationMode Mode { get => mode; set => mode = value; }
        public string HEX => RgbToHex(R, G, B);
        public int R => (color >> 16) & 0xFF;
        public int G => (color >> 8) & 0xFF;
        public int B => (color) & 0xFF;
        public void detect()
        {
            Bitmap screenshot = CaptureScreen();
            screenshot = Posterize(screenshot);
            this.color = GetMajorColour(screenshot);
        }
        string ComponentToHex(int c)
        {
            string hex = "";
            if (c / 16 > 9)
            {
                int h = 'A' + (c / 16) - 10;
                hex += (char)h;
            }
            else hex += (c / 16);
            if (c % 16 > 9)
            {
                int h = 'A' + (c % 16) - 10;
                hex += (char)h;
            }
            else hex += (c % 16);
            return hex;
        }
        string RgbToHex(int r, int g, int b)
        {
            return "#" + ComponentToHex(r) + ComponentToHex(g) + ComponentToHex(b);
        }
        private double GetDpi()
        {
            double dpiX;
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
                dpiX = graphics.DpiX;

            switch (dpiX)
            {
                case 96:
                    {
                        dpiX = 1;
                        break;
                    }
                case 120:
                    {
                        dpiX = 1.25;
                        break;
                    }
                case 144:
                    {
                        dpiX = 1.5;
                        break;
                    }
                case 168:
                    {
                        dpiX = 1.75;
                        break;
                    }
                case 192:
                    {
                        dpiX = 2;
                        break;
                    }
            }
            return dpiX;
        }
        private Bitmap CaptureScreen()
        {
            double dpiX = GetDpi();
            double w = SystemParameters.PrimaryScreenWidth * dpiX
               , h = SystemParameters.PrimaryScreenHeight * dpiX;
            Bitmap memoryImage = new Bitmap((int)w, (int)h);
            Graphics graphics = Graphics.FromImage(memoryImage);
            Size s = new Size(memoryImage.Width, memoryImage.Height);
            graphics.CopyFromScreen(0, 0, 0, 0, s);
            
            return memoryImage;
        }
        private Bitmap Posterize(Bitmap image)
        {
            SimplePosterization filter = new SimplePosterization();
            filter.ApplyInPlace(image);
            return image;
        }
        private Int32 GetMajorColour(Bitmap slide)
        {
            List<Int32> colors = new List<Int32>();
            int pixel;
            for (int row = 0; row < slide.Size.Width; row++)
            {
                for (int col = 0; col < slide.Size.Height; col++)
                {
                    pixel = slide.GetPixel(row, col).ToArgb();
                    // to eleminate white 
                    if (mode.Equals(PresentationMode.textOnWhite))
                    {
                        if (pixel != -1) // -1 is white
                            colors.Add(pixel);
                    }
                    else colors.Add(pixel);

                }

            }

            //sort to get most frequint color
            Int32 most = colors.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();
            return most;
        }
    }
    enum PresentationMode
    {
        photographic, textOnWhite
    }
}

