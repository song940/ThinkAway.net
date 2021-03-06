#region License
//=============================================================================
// ThinkAway MVC - .NET Web Application Framework 
//
// Copyright (c) 2003-2009 Philippe Leybaert
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//=============================================================================
#endregion

using System;
using System.Collections.Generic;

namespace ThinkAway.Web
{
    [ComponentName("Control.CheckBox")]
    public class CheckBoxComponent : ViewComponent
    {
        public string Run(string name, bool @checked, string className, string onChange, string onClick, string value)
        {
            CheckBoxControl checkBoxControl = new CheckBoxControl(name);

            checkBoxControl.Checked = @checked;

            if (className != null)
                checkBoxControl.CssClass = className;

            if (onChange != null)
                checkBoxControl.OnChange = onChange;

            if (onClick != null)
                checkBoxControl.OnClick = onClick;

            if (value != null)
                checkBoxControl.Value = value;

            return checkBoxControl.Render(RootView);
        }

    }
}