﻿/* 
 *  Copyright 2015 Alex Makeev
 * 
 *  This file is part of ZXMAK2 (ZX Spectrum virtual machine).
 *
 *  ZXMAK2 is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  ZXMAK2 is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with ZXMAK2.  If not, see <http://www.gnu.org/licenses/>.
 *  
 * 
 */
using System;
using System.ComponentModel;


namespace ZXMAK2.Mvvm.BindingTools
{
    public interface IBindingAdapter : IDisposable
    {
        event EventHandler<TargetPropertyChangedEventArgs> PropertyChanged;
        BindingTrigger GetDefaultPropertyTrigger(string name);
        Type GetTargetPropertyType(string name);
        object GetTargetPropertyValue(string name);
        void SetTargetPropertyValue(string name, object value);
    }
}
