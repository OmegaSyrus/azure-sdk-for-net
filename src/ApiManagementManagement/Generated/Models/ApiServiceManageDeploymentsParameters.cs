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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Parameters supplied to the ManageDeployments operation.
    /// </summary>
    public partial class ApiServiceManageDeploymentsParameters
    {
        private IList<AdditionalRegion> _additionalRegions;
        
        /// <summary>
        /// Optional. Gets or sets additional data center locations for the Api
        /// Management service.
        /// </summary>
        public IList<AdditionalRegion> AdditionalRegions
        {
            get { return this._additionalRegions; }
            set { this._additionalRegions = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets location of the Api Management service data
        /// center.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private SkuType _skuType;
        
        /// <summary>
        /// Required. Gets or sets sku type of the Api Management service.
        /// </summary>
        public SkuType SkuType
        {
            get { return this._skuType; }
            set { this._skuType = value; }
        }
        
        private int? _skuUnitCount;
        
        /// <summary>
        /// Optional. Gets or sets sku Unit count of the Api Management service.
        /// </summary>
        public int? SkuUnitCount
        {
            get { return this._skuUnitCount; }
            set { this._skuUnitCount = value; }
        }
        
        private VirtualNetworkConfiguration _virtualNetworkConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets virtual network configuration.
        /// </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration
        {
            get { return this._virtualNetworkConfiguration; }
            set { this._virtualNetworkConfiguration = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceManageDeploymentsParameters class.
        /// </summary>
        public ApiServiceManageDeploymentsParameters()
        {
            this.AdditionalRegions = new LazyList<AdditionalRegion>();
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceManageDeploymentsParameters class with required
        /// arguments.
        /// </summary>
        public ApiServiceManageDeploymentsParameters(string location, SkuType skuType)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
            this.SkuType = skuType;
        }
    }
}
