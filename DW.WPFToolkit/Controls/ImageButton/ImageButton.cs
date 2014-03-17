﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DW.WPFToolkit.Controls
{
    public class ImageButton : Button
    {
        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public BitmapSource ImageSource
        {
            get { return (BitmapSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(BitmapSource), typeof(ImageButton), new UIPropertyMetadata(null, OnImageSourceChanged));

        private static void OnImageSourceChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var control = (ImageButton)o;
            if (e.NewValue != null &&
                !control._sizeIsSet)
            {
                var bitmapSource = e.NewValue as BitmapSource;
                control.DisabledImageSource = new FormatConvertedBitmap(bitmapSource, PixelFormats.Gray32Float, null, 0);
                control.ImageHeight = bitmapSource.Height;
                control.ImageWidth = bitmapSource.Width;
            }
        }

        public BitmapSource DisabledImageSource
        {
            get { return (BitmapSource)GetValue(DisabledImageSourceProperty); }
            set { SetValue(DisabledImageSourceProperty, value); }
        }

        public static readonly DependencyProperty DisabledImageSourceProperty =
            DependencyProperty.Register("DisabledImageSource", typeof(BitmapSource), typeof(ImageButton), new UIPropertyMetadata(null));

        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(ImageButton), new UIPropertyMetadata(16.0, OnSizeChanged));

        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(ImageButton), new UIPropertyMetadata(16.0, OnSizeChanged));

        private bool _sizeIsSet;

        private static void OnSizeChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var control = (ImageButton)o;
            control._sizeIsSet = true;
        }

        public Thickness ImageMargin
        {
            get { return (Thickness)GetValue(ImageMarginProperty); }
            set { SetValue(ImageMarginProperty, value); }
        }

        public static readonly DependencyProperty ImageMarginProperty =
            DependencyProperty.Register("ImageMargin", typeof(Thickness), typeof(ImageButton), new UIPropertyMetadata(new Thickness(0, 0, 2, 0)));

        public Dock ImagePosition
        {
            get { return (Dock)GetValue(ImagePositionProperty); }
            set { SetValue(ImagePositionProperty, value); }
        }

        public static readonly DependencyProperty ImagePositionProperty =
            DependencyProperty.Register("ImagePosition", typeof(Dock), typeof(ImageButton), new UIPropertyMetadata(Dock.Left));

        public HorizontalAlignment HorizontalImageAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalImageAlignmentProperty); }
            set { SetValue(HorizontalImageAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HorizontalImageAlignmentProperty =
            DependencyProperty.Register("HorizontalImageAlignment", typeof(HorizontalAlignment), typeof(ImageButton), new UIPropertyMetadata(HorizontalAlignment.Center));

        public VerticalAlignment VerticalImageAlignment
        {
            get { return (VerticalAlignment)GetValue(VerticalImageAlignmentProperty); }
            set { SetValue(VerticalImageAlignmentProperty, value); }
        }

        public static readonly DependencyProperty VerticalImageAlignmentProperty =
            DependencyProperty.Register("VerticalImageAlignment", typeof(VerticalAlignment), typeof(ImageButton), new UIPropertyMetadata(VerticalAlignment.Center));
        
        public Stretch ImageStretch
        {
            get { return (Stretch)GetValue(ImageStretchProperty); }
            set { SetValue(ImageStretchProperty, value); }
        }

        public static readonly DependencyProperty ImageStretchProperty =
            DependencyProperty.Register("ImageStretch", typeof(Stretch), typeof(ImageButton), new UIPropertyMetadata(Stretch.Uniform));
    }
}
