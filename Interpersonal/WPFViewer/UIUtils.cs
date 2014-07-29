﻿

namespace Interpersonal.WPFViewer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Media;

    class UIUtils
    {
        public static T GetFrameworkElementByName<T>(FrameworkElement referenceElement) where T : FrameworkElement
        {

            FrameworkElement child = null;

            for (Int32 i = 0; i < VisualTreeHelper.GetChildrenCount(referenceElement); i++)
            {

                child = VisualTreeHelper.GetChild(referenceElement, i) as FrameworkElement;

                System.Diagnostics.Debug.WriteLine(child);

                if (child != null && child.GetType() == typeof(T))

                { break; }

                else if (child != null)
                {

                    child = GetFrameworkElementByName<T>(child);

                    if (child != null && child.GetType() == typeof(T))
                    {

                        break;

                    }

                }

            }

            return child as T;
        }

    }
}
