﻿using System.Windows;

namespace Panuon.WPF.UI.Configurations
{
    public class MessageBoxXSetting : DependencyObject
    {
        #region Ctor
        public MessageBoxXSetting()
        {
            WindowXStyle = (Style)Application.Current.FindResource(MessageBoxX.WindowXStyleKey);
            ContentTemplate = (DataTemplate)Application.Current.FindResource(MessageBoxX.ContentTemplateKey);
            TextBoxStyle = (Style)Application.Current.FindResource(MessageBoxX.TextBoxStyleKey);
            ButtonStyle = (Style)Application.Current.FindResource(MessageBoxX.ButtonStyleKey);
        }
        #endregion

        #region Properties

        #region InteropOwnersMask
        public bool InteropOwnersMask
        {
            get { return (bool)GetValue(InteropOwnersMaskProperty); }
            set { SetValue(InteropOwnersMaskProperty, value); }
        }

        public static readonly DependencyProperty InteropOwnersMaskProperty =
            DependencyProperty.Register("InteropOwnersMask", typeof(bool), typeof(MessageBoxXSetting), new PropertyMetadata(true));
        #endregion

        #region InverseButtonsSequence
        public bool InverseButtonsSequence
        {
            get { return (bool)GetValue(InverseButtonsSequenceProperty); }
            set { SetValue(InverseButtonsSequenceProperty, value); }
        }

        public static readonly DependencyProperty InverseButtonsSequenceProperty =
            DependencyProperty.Register("InverseButtonsSequence", typeof(bool), typeof(MessageBoxXSetting));
        #endregion

        #region ButtonStyle
        public Style ButtonStyle
        {
            get { return (Style)GetValue(ButtonStyleProperty); }
            set { SetValue(ButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.Register("ButtonStyle", typeof(Style), typeof(MessageBoxXSetting));
        #endregion

        #region TextBoxStyle
        public Style TextBoxStyle
        {
            get { return (Style)GetValue(TextBoxStyleProperty); }
            set { SetValue(TextBoxStyleProperty, value); }
        }

        public static readonly DependencyProperty TextBoxStyleProperty =
            DependencyProperty.Register("TextBoxStyle", typeof(Style), typeof(MessageBoxXSetting));
        #endregion

        #region WindowXStyle
        public Style WindowXStyle
        {
            get { return (Style)GetValue(WindowXStyleProperty); }
            set { SetValue(WindowXStyleProperty, value); }
        }

        public static readonly DependencyProperty WindowXStyleProperty =
            DependencyProperty.Register("WindowXStyle", typeof(Style), typeof(MessageBoxXSetting));
        #endregion

        #region ContentTemplate
        public DataTemplate ContentTemplate
        {
            get { return (DataTemplate)GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateProperty =
            DependencyProperty.Register("ContentTemplate", typeof(DataTemplate), typeof(MessageBoxXSetting));
        #endregion

        #region OKButtonContent
        public object OKButtonContent
        {
            get { return (object)GetValue(OKButtonContentProperty); }
            set { SetValue(OKButtonContentProperty, value); }
        }

        public static readonly DependencyProperty OKButtonContentProperty =
            DependencyProperty.Register("OKButtonContent", typeof(object), typeof(MessageBoxXSetting), new PropertyMetadata("OK"));
        #endregion

        #region CancelButtonContent
        public object CancelButtonContent
        {
            get { return (object)GetValue(CancelButtonContentProperty); }
            set { SetValue(CancelButtonContentProperty, value); }
        }

        public static readonly DependencyProperty CancelButtonContentProperty =
            DependencyProperty.Register("CancelButtonContent", typeof(object), typeof(MessageBoxXSetting), new PropertyMetadata("Cancel"));
        #endregion

        #region YesButtonContent
        public object YesButtonContent
        {
            get { return (object)GetValue(YesButtonContentProperty); }
            set { SetValue(YesButtonContentProperty, value); }
        }

        public static readonly DependencyProperty YesButtonContentProperty =
            DependencyProperty.Register("YesButtonContent", typeof(object), typeof(MessageBoxXSetting), new PropertyMetadata("Yes"));
        #endregion

        #region NoButtonContent
        public object NoButtonContent
        {
            get { return (object)GetValue(NoButtonContentProperty); }
            set { SetValue(NoButtonContentProperty, value); }
        }

        public static readonly DependencyProperty NoButtonContentProperty =
            DependencyProperty.Register("NoButtonContent", typeof(object), typeof(MessageBoxXSetting), new PropertyMetadata("No"));
        #endregion

        #endregion

    }
}
