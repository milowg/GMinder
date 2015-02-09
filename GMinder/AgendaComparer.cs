/// Copyright (c) 2009, Greg Todd
/// All rights reserved.
///
/// Redistribution and use in source and binary forms, with or without modification,
/// are permitted provided that the following conditions are met:
/// 
/// * Redistributions of source code must retain the above copyright notice,
///   this list of conditions and the following disclaimer.
///   
/// * Redistributions in binary form must reproduce the above copyright notice,
///   this list of conditions and the following disclaimer in the documentation
///   and/or other materials provided with the distribution.
///   
/// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
/// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
/// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
/// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
/// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
/// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
/// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
/// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
/// OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
/// OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder
{
    public class AgendaComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var xItem = x as ListViewItem;
            var yItem = y as ListViewItem;

            DateTime xTime = default(DateTime);
            if (xItem.Tag is DateTime)
                xTime = (DateTime)xItem.Tag;
            else if (xItem.Tag is Gvent)
                xTime = (xItem.Tag as Gvent).Start;
            else
                throw new Exception("Unexpected item type");

            DateTime yTime = default(DateTime);
            if (yItem.Tag is DateTime)
                yTime = (DateTime)yItem.Tag;
            else if (yItem.Tag is Gvent)
                yTime = (yItem.Tag as Gvent).Start;
            else
                throw new Exception("Unexpected item type");

            if (xTime > yTime)
                return 1;
            else if (xTime < yTime)
                return -1;
            else if (xItem.Tag is DateTime && yItem.Tag is Gvent)
                return -1;
            else if (xItem.Tag is Gvent && yItem.Tag is DateTime)
                return 1;
            else if (xItem.Tag is Gvent && yItem.Tag is Gvent)
                return -(xItem.Tag as Gvent).CompareTo(yItem.Tag as Gvent);
            else
                return 0;
        }
    }
}
