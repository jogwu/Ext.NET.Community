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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BaseItem.Builder<ListItem, ListItem.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ListItem()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ListItem.Config config) : base(new ListItem(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ListItem component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// 
			/// </summary>
            public virtual ListItem.Builder Text(string text)
            {
                this.ToComponent().Text = text;
                return this as ListItem.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ListItem.Builder Value(string value)
            {
                this.ToComponent().Value = value;
                return this as ListItem.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual ListItem.Builder Index(int index)
            {
                this.ToComponent().Index = index;
                return this as ListItem.Builder;
            }
             
 			/// <summary>
			/// Wrap in quotes or not
			/// </summary>
            public virtual ListItem.Builder Mode(ParameterMode mode)
            {
                this.ToComponent().Mode = mode;
                return this as ListItem.Builder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ListItem(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem()
        {
            return this.ListItem(new ListItem());
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem component)
        {
            return new ListItem.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ListItem.Builder ListItem(ListItem.Config config)
        {
            return new ListItem.Builder(new ListItem(config));
        }
    }
}