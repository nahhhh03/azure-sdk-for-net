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
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The Get Details OS Images operation response.
    /// </summary>
    public partial class VirtualMachineOSImageGetDetailsResponse : VirtualMachineOSImageGetResponse
    {
        private bool? _isCorrupted;
        
        /// <summary>
        /// Optional. The indicator of whether the image is corrupted or not.
        /// </summary>
        public bool? IsCorrupted
        {
            get { return this._isCorrupted; }
            set { this._isCorrupted = value; }
        }
        
        private IList<VirtualMachineOSImageGetDetailsResponse.ReplicationProgressElement> _replicationProgress;
        
        /// <summary>
        /// Optional. The replication progress information of VM images.
        /// </summary>
        public IList<VirtualMachineOSImageGetDetailsResponse.ReplicationProgressElement> ReplicationProgress
        {
            get { return this._replicationProgress; }
            set { this._replicationProgress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineOSImageGetDetailsResponse class.
        /// </summary>
        public VirtualMachineOSImageGetDetailsResponse()
        {
            this.ReplicationProgress = new LazyList<VirtualMachineOSImageGetDetailsResponse.ReplicationProgressElement>();
        }
        
        /// <summary>
        /// The replication progress information of VM images.
        /// </summary>
        public partial class ReplicationProgressElement
        {
            private string _location;
            
            /// <summary>
            /// Optional. The location of the replication of VM image.
            /// </summary>
            public string Location
            {
                get { return this._location; }
                set { this._location = value; }
            }
            
            private string _progress;
            
            /// <summary>
            /// Optional. The progress of the replication of VM image.
            /// </summary>
            public string Progress
            {
                get { return this._progress; }
                set { this._progress = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ReplicationProgressElement
            /// class.
            /// </summary>
            public ReplicationProgressElement()
            {
            }
        }
    }
}
