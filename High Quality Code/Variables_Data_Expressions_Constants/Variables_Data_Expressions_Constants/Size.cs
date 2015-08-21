namespace Variables_Data_Expressions_Constants
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleRotation)
        {
            double cosOfAngleRotation = Math.Cos(angleRotation);
            double sinOfAngleRotation = Math.Sin(angleRotation);
            double absoluteSinOfAngleRotation = Math.Abs(Math.Sin(angleRotation) * size.height);
            double absoluteCosOfAngleRotation = Math.Abs(Math.Cos(angleRotation) * size.height);

            double widthOfRotatedSize = (cosOfAngleRotation * size.width) + absoluteSinOfAngleRotation;
            double heightOfRotatedSize = (sinOfAngleRotation * size.width) + absoluteCosOfAngleRotation;

            double absoluteWidthOfRotatedSize = Math.Abs(widthOfRotatedSize);
            double absoluteHeightOfRotatedSize = Math.Abs(heightOfRotatedSize);

            Size rotatedSize = new Size(absoluteWidthOfRotatedSize, absoluteHeightOfRotatedSize);

            return rotatedSize;
        }
    }
}
