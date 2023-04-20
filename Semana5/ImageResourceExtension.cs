﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Semana5
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    internal class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            var imageSource = ImageSource.FromResource(Source,
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }


}