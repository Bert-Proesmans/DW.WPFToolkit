﻿using System.Windows;
using System.Windows.Controls;
using DW.WPFToolkit.Helpers;

namespace DW.WPFToolkit.Controls
{
    /// <summary>
    /// Represents a ComboBox which shows a tree view in the drop down.
    /// </summary>
    public class TreeComboBox : TreeView
    {
        static TreeComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeComboBox), new FrameworkPropertyMetadata(typeof(TreeComboBox)));
        }

        public TreeComboBox()
        {
            var box = new ComboBox();
            MaxDropDownHeight = box.MaxDropDownHeight;
            SelectionBoxItemTemplate = box.SelectionBoxItemTemplate;
            SelectionBoxItemStringFormat = box.SelectionBoxItemStringFormat;
            SelectionBoxItem = "";
        }

        public override void OnApplyTemplate()
        {
            new PopupHandler().AutoClose(this, ClosePopup);
            base.OnApplyTemplate();
        }

        public double MaxDropDownHeight
        {
            get { return (double)GetValue(MaxDropDownHeightProperty); }
            set { SetValue(MaxDropDownHeightProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Controls.TreeComboBox.MaxDropDownHeight" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty MaxDropDownHeightProperty =
            DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(TreeComboBox), new UIPropertyMetadata(0.0));

        public DataTemplate SelectionBoxItemTemplate
        {
            get { return (DataTemplate)GetValue(SelectionBoxItemTemplateProperty); }
            set { SetValue(SelectionBoxItemTemplateProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Controls.TreeComboBox.SelectionBoxItemTemplate" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectionBoxItemTemplateProperty =
            DependencyProperty.Register("SelectionBoxItemTemplate", typeof(DataTemplate), typeof(TreeComboBox), new UIPropertyMetadata(null));

        public object SelectionBoxItem
        {
            get { return (object)GetValue(SelectionBoxItemProperty); }
            set { SetValue(SelectionBoxItemProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Controls.TreeComboBox.SelectionBoxItem" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectionBoxItemProperty =
            DependencyProperty.Register("SelectionBoxItem", typeof(object), typeof(TreeComboBox), new UIPropertyMetadata(null));

        public string SelectionBoxItemStringFormat
        {
            get { return (string)GetValue(SelectionBoxItemStringFormatProperty); }
            set { SetValue(SelectionBoxItemStringFormatProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Controls.TreeComboBox.SelectionBoxItemStringFormat" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectionBoxItemStringFormatProperty =
            DependencyProperty.Register("SelectionBoxItemStringFormat", typeof(string), typeof(TreeComboBox), new UIPropertyMetadata(null));

        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }
            set { SetValue(IsDropDownOpenProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="DW.WPFToolkit.Controls.TreeComboBox.IsDropDownOpen" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty IsDropDownOpenProperty =
            DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(TreeComboBox), new UIPropertyMetadata(null));

        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
        {
            var item = e.NewValue as TreeViewItem;
            if (item != null)
                SelectionBoxItem = item.Header;
            else
                SelectionBoxItem = e.NewValue;
            ClosePopup();
            base.OnSelectedItemChanged(e);
        }

        private void ClosePopup()
        {
            if (IsDropDownOpen)
                IsDropDownOpen = false;
        }
    }
}
