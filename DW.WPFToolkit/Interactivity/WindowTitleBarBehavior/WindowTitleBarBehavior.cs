﻿using System;
using System.Windows;

namespace DW.WPFToolkit.Interactivity
{
    /// <summary>
    /// Brings the feature to the <see cref="System.Windows.Window" /> to disable or hide elements in the title bar.
    /// </summary>
    public class WindowTitleBarBehavior : FrameworkElement
    {
#if TRIAL
        static WindowTitleBarBehavior()
        {
            License1.License.Display();
        }
#endif

        /// <summary>
        /// Gets a value the indicates if the window has to show title bar items or not.
        /// </summary>
        /// <param name="obj">The element from which the property value is read.</param>
        /// <returns>The DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.RemoveTitleItems property value for the element.</returns>
        public static bool GetRemoveTitleItems(DependencyObject obj)
        {
            return (bool)obj.GetValue(RemoveTitleItemsProperty);
        }

        /// <summary>
        /// Attaches a value the indicates if the window has to show title bar items or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <param name="value">The needed DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.RemoveTitleItems value.</param>
        public static void SetRemoveTitleItems(DependencyObject obj, bool value)
        {
            obj.SetValue(RemoveTitleItemsProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.GetRemoveTitleItems(DependencyObject)" />  <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.SetRemoveTitleItems(DependencyObject, bool)" /> attached property.
        /// </summary>
        public static readonly DependencyProperty RemoveTitleItemsProperty =
            DependencyProperty.RegisterAttached("RemoveTitleItems", typeof(bool), typeof(WindowTitleBarBehavior), new UIPropertyMetadata(false, OnRemoveTitleItemsChanged));

        /// <summary>
        /// Gets a value the indicates if the window has an enabled minimize button or not.
        /// </summary>
        /// <param name="obj">The element from which the property value is read.</param>
        /// <returns>The DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableMinimizeButton property value for the element.</returns>
        public static bool GetDisableMinimizeButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisableMinimizeButtonProperty);
        }

        /// <summary>
        /// Attaches a value the indicates if the window has an enabled minimize button or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <param name="value">The needed DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableMinimizeButton value.</param>
        public static void SetDisableMinimizeButton(DependencyObject obj, bool value)
        {
            obj.SetValue(DisableMinimizeButtonProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.GetDisableMinimizeButton(DependencyObject)" /> <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.SetDisableMinimizeButton(DependencyObject, bool)" /> attached property.
        /// </summary>
        public static readonly DependencyProperty DisableMinimizeButtonProperty =
            DependencyProperty.RegisterAttached("DisableMinimizeButton", typeof(bool), typeof(WindowTitleBarBehavior), new UIPropertyMetadata(false, OnDisableMinimizeButtonChanged));

        /// <summary>
        /// Gets a value the indicates if the window has an enabled maximize button or not.
        /// </summary>
        /// <param name="obj">The element from which the property value is read.</param>
        /// <returns>The DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableMaximizeButton property value for the element.</returns>
        public static bool GetDisableMaximizeButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisableMaximizeButtonProperty);
        }

        /// <summary>
        /// Attaches a value the indicates if the window has an enabled maximize button or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <param name="value">The needed DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableMaximizeButton value.</param>
        public static void SetDisableMaximizeButton(DependencyObject obj, bool value)
        {
            obj.SetValue(DisableMaximizeButtonProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.GetDisableMaximizeButton(DependencyObject)" /> <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.SetDisableMaximizeButton(DependencyObject, bool)" /> attached property.
        /// </summary>
        public static readonly DependencyProperty DisableMaximizeButtonProperty =
            DependencyProperty.RegisterAttached("DisableMaximizeButton", typeof(bool), typeof(WindowTitleBarBehavior), new UIPropertyMetadata(false, OnDisableMaximizeButtonChanged));

        /// <summary>
        /// Gets a value that indicates if the window has an enabled close button or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <returns>The DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableCloseButton property value for the element.</returns>
        public static bool GetDisableCloseButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisableCloseButtonProperty);
        }

        /// <summary>
        /// Attaches a value the indicates if the window has an enabled close button or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <param name="value">The needed DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableCloseButton value.</param>
        public static void SetDisableCloseButton(DependencyObject obj, bool value)
        {
            obj.SetValue(DisableCloseButtonProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.GetDisableCloseButton(DependencyObject)" /> <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.SetDisableCloseButton(DependencyObject, bool)" /> attached property.
        /// </summary>
        public static readonly DependencyProperty DisableCloseButtonProperty =
            DependencyProperty.RegisterAttached("DisableCloseButton", typeof(bool), typeof(WindowTitleBarBehavior), new PropertyMetadata(false, OnDisableCloseButtonChanged));

        /// <summary>
        /// Gets a value that indicates if the window has a system menu or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <returns>The DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableSystemMenu property value for the element.</returns>
        public static bool GetDisableSystemMenu(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisableSystemMenuProperty);
        }

        /// <summary>
        /// Attaches a value the indicates if the window has a system menu or not.
        /// </summary>
        /// <param name="obj">The element to which the attached property is written.</param>
        /// <param name="value">The needed DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.DisableSystemMenu value.</param>
        public static void SetDisableSystemMenu(DependencyObject obj, bool value)
        {
            obj.SetValue(DisableSystemMenuProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.GetDisableSystemMenu(DependencyObject)" /> <see cref="DW.WPFToolkit.Interactivity.WindowTitleBarBehavior.SetDisableSystemMenu(DependencyObject, bool)" /> attached property.
        /// </summary>
        public static readonly DependencyProperty DisableSystemMenuProperty =
            DependencyProperty.RegisterAttached("DisableSystemMenu", typeof(bool), typeof(WindowTitleBarBehavior), new PropertyMetadata(false, OnDisableSystemMenuChanged));

        private static void OnRemoveTitleItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.SourceInitialized += RemoveTitleItems_SourceInitialized;
        }

        private static void OnDisableMinimizeButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.SourceInitialized += DisableMinimizeButton_SourceInitialized;
        }

        private static void OnDisableMaximizeButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.SourceInitialized += DisableMaximizeButton_SourceInitialized;
        }

        private static void OnDisableCloseButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.SourceInitialized += DisableCloseButton_SourceInitialized;
        }

        private static void OnDisableSystemMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = d as Window;
            if (window != null)
                window.SourceInitialized += DisableSystemMenu_SourceInitialized;
        }

        private static void RemoveTitleItems_SourceInitialized(object sender, System.EventArgs e)
        {
            var window = (Window)sender;
            WindowTitleBar.RemoveTitleItems(window);
        }

        private static void DisableMinimizeButton_SourceInitialized(object sender, System.EventArgs e)
        {
            var window = (Window)sender;
            WindowTitleBar.DisableMinimizeButton(window);
        }

        private static void DisableMaximizeButton_SourceInitialized(object sender, System.EventArgs e)
        {
            var window = (Window)sender;
            WindowTitleBar.DisableMaximizeButton(window);
        }

        private static void DisableCloseButton_SourceInitialized(object sender, EventArgs e)
        {
            var window = (Window)sender;
            WindowTitleBar.DisableCloseButton(window);
        }

        private static void DisableSystemMenu_SourceInitialized(object sender, EventArgs e)
        {
            var window = (Window)sender;
            WindowTitleBar.DisableSystemMenu(window);
        }
    }
}
