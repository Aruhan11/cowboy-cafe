﻿/*
 * Author: Aruhan
 * Class: ExtensionMethod.cs
 * Purpose: a static class
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Extensions
{
    public static class ExtensionMethod
    {
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent); 
        }
    }
}
