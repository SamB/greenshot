﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2021 Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: https://getgreenshot.org/
 * The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Greenshot.Base.Controls;

namespace Greenshot.Controls
{
    /// <summary>
    /// Description of BindableToolStripButton.
    /// </summary>
    public class BindableToolStripButton : ToolStripButton, INotifyPropertyChanged, IGreenshotLanguageBindable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [Category("Greenshot"), DefaultValue(null), Description("Specifies key of the language file to use when displaying the text.")]
        public string LanguageKey { get; set; }

        public BindableToolStripButton()
        {
            CheckedChanged += BindableToolStripButton_CheckedChanged;
        }

        private void BindableToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Checked"));
        }
    }
}