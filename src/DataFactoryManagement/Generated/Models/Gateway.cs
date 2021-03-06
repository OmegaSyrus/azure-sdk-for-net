// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Data factory gateway resource definition.
    /// </summary>
    public partial class Gateway
    {
        private string _name;
        
        /// <summary>
        /// Required. Name of the data factory gateway.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private GatewayProperties _properties;
        
        /// <summary>
        /// Required. Properties of the data factory gateway. Only the
        /// Description property is applicable in the PUT/PATCH request. Other
        /// properties are only applicable in service response, and they will
        /// be ignored in the PUT/PATCH request.
        /// </summary>
        public GatewayProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Gateway class.
        /// </summary>
        public Gateway()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Gateway class with required
        /// arguments.
        /// </summary>
        public Gateway(string name, GatewayProperties properties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Name = name;
            this.Properties = properties;
        }
    }
}
