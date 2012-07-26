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
    public partial class JsonWriter
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public JsonWriter(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit JsonWriter.Config Conversion to JsonWriter
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonWriter(JsonWriter.Config config)
        {
            return new JsonWriter(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : AbstractWriter.Config 
        { 
			/*  Implicit JsonWriter.Config Conversion to JsonWriter.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator JsonWriter.Builder(JsonWriter.Config config)
			{
				return new JsonWriter.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string root = "";

			/// <summary>
			/// The key under which the records in this Writer will be placed. Defaults to undefined.
			/// </summary>
			[DefaultValue("")]
			public virtual string Root 
			{ 
				get
				{
					return this.root;
				}
				set
				{
					this.root = value;
				}
			}

			private bool encode = false;

			/// <summary>
			/// True to use Ext.encode() on the data before sending. Defaults to false.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Encode 
			{ 
				get
				{
					return this.encode;
				}
				set
				{
					this.encode = value;
				}
			}

			private bool allowSingle = false;

			/// <summary>
			/// False to ensure that records are always wrapped in an array, even if there is only one record being sent. When there is more than one record, they will always be encoded into an array.
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AllowSingle 
			{ 
				get
				{
					return this.allowSingle;
				}
				set
				{
					this.allowSingle = value;
				}
			}

        }
    }
}