﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public class Utils
    {
        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            // Get the image current width
            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        public static Image FixImageOrientation(Image image)
        {
            const int exifOrientationId = 0x112;
            if (!image.PropertyIdList.Contains(exifOrientationId))
                return image;
            //Gets the specified property item from the image
            var property = image.GetPropertyItem(exifOrientationId);
            var orient = BitConverter.ToInt16(property.Value, 0);
            //Get the rotated or flipped image 
            image = Utils.RotateImageSrc(orient, image);
            return image;
        }

        private static Image RotateImageSrc(int orient, Image image)
        {
            switch (orient)
            {
                case 1:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    return image;
                case 2:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    return image;
                case 3:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return image;
                case 4:
                    image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    return image;
                case 5:
                    image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    return image;
                case 6:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return image;
                case 7:
                    image.RotateFlip(RotateFlipType.Rotate270FlipX);
                    return image;
                case 8:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return image;
                default:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    return image;
            }
        }
    }
}
