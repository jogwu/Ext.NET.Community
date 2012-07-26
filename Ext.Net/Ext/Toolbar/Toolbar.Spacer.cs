/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-07-24
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// A simple element that adds extra horizontal space between items in a toolbar. By default a 2px wide space is added via CSS specification:
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [Description("A simple element that adds extra horizontal space between items in a toolbar. By default a 2px wide space is added via CSS specification:")]
    public partial class ToolbarSpacer : ToolbarItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer(Unit width)
        {
            this.Width = width;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ToolbarSpacer(int width)
        {
            this.Width = Unit.Pixel(width);
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "tbspacer";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.toolbar.Spacer";
            }
        }
    }
}