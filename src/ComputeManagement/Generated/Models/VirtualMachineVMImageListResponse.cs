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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List VM Images operation response.
    /// </summary>
    public partial class VirtualMachineVMImageListResponse : OperationResponse, IEnumerable<VirtualMachineVMImageListResponse.VirtualMachineVMImage>
    {
        private IList<VirtualMachineVMImageListResponse.VirtualMachineVMImage> _vMImages;
        
        /// <summary>
        /// Optional. The virtual machine images associated with your
        /// subscription.
        /// </summary>
        public IList<VirtualMachineVMImageListResponse.VirtualMachineVMImage> VMImages
        {
            get { return this._vMImages; }
            set { this._vMImages = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineVMImageListResponse
        /// class.
        /// </summary>
        public VirtualMachineVMImageListResponse()
        {
            this.VMImages = new LazyList<VirtualMachineVMImageListResponse.VirtualMachineVMImage>();
        }
        
        /// <summary>
        /// Gets the sequence of VMImages.
        /// </summary>
        public IEnumerator<VirtualMachineVMImageListResponse.VirtualMachineVMImage> GetEnumerator()
        {
            return this.VMImages.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of VMImages.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// The data disk configuration.
        /// </summary>
        public partial class DataDiskConfiguration
        {
            private string _hostCaching;
            
            /// <summary>
            /// Optional. Specifies the platform caching behavior of the data
            /// disk blob for read/write efficiency. The default vault is
            /// ReadOnly.
            /// </summary>
            public string HostCaching
            {
                get { return this._hostCaching; }
                set { this._hostCaching = value; }
            }
            
            private string _iOType;
            
            /// <summary>
            /// Optional. Gets or sets the IO type.
            /// </summary>
            public string IOType
            {
                get { return this._iOType; }
                set { this._iOType = value; }
            }
            
            private int _logicalDiskSizeInGB;
            
            /// <summary>
            /// Optional. Specifies the size, in GB, of an empty VHD to be
            /// attached to the virtual machine. The VHD can be created as
            /// part of disk attach or create virtual machine calls by
            /// specifying the value for this property. Azure creates the
            /// empty VHD based on size preference and attaches the newly
            /// created VHD to the virtual machine.
            /// </summary>
            public int LogicalDiskSizeInGB
            {
                get { return this._logicalDiskSizeInGB; }
                set { this._logicalDiskSizeInGB = value; }
            }
            
            private int? _logicalUnitNumber;
            
            /// <summary>
            /// Optional. Specifies the Logical Unit Number (LUN) for the data
            /// disk. The LUN specifies the slot in which the data drive
            /// appears when mounted for usage by the virtual machine. This
            /// element is only listed when more than one data disk is
            /// attached to a virtual machine.
            /// </summary>
            public int? LogicalUnitNumber
            {
                get { return this._logicalUnitNumber; }
                set { this._logicalUnitNumber = value; }
            }
            
            private Uri _mediaLink;
            
            /// <summary>
            /// Optional. Specifies the location of the disk in Windows Azure
            /// storage.
            /// </summary>
            public Uri MediaLink
            {
                get { return this._mediaLink; }
                set { this._mediaLink = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Specifies the name of the VHD to use to create the
            /// data disk for the virtual machine.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the DataDiskConfiguration class.
            /// </summary>
            public DataDiskConfiguration()
            {
            }
        }
        
        /// <summary>
        /// The OS disk configuration.
        /// </summary>
        public partial class OSDiskConfiguration
        {
            private string _hostCaching;
            
            /// <summary>
            /// Optional. Specifies the platform caching behavior of the
            /// operating system disk blob for read/write efficiency.
            /// </summary>
            public string HostCaching
            {
                get { return this._hostCaching; }
                set { this._hostCaching = value; }
            }
            
            private string _iOType;
            
            /// <summary>
            /// Optional. Gets or sets the IO type.
            /// </summary>
            public string IOType
            {
                get { return this._iOType; }
                set { this._iOType = value; }
            }
            
            private int _logicalDiskSizeInGB;
            
            /// <summary>
            /// Optional. Specifies the size, in GB, of an empty VHD to be
            /// attached to the virtual machine. The VHD can be created as
            /// part of disk attach or create virtual machine calls by
            /// specifying the value for this property. Azure creates the
            /// empty VHD based on size preference and attaches the newly
            /// created VHD to the virtual machine.
            /// </summary>
            public int LogicalDiskSizeInGB
            {
                get { return this._logicalDiskSizeInGB; }
                set { this._logicalDiskSizeInGB = value; }
            }
            
            private Uri _mediaLink;
            
            /// <summary>
            /// Optional. Specifies the location of the disk in Windows Azure
            /// storage.
            /// </summary>
            public Uri MediaLink
            {
                get { return this._mediaLink; }
                set { this._mediaLink = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Specifies the name of an operating system image in
            /// the image repository.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _operatingSystem;
            
            /// <summary>
            /// Optional. The operating system running in the virtual machine.
            /// </summary>
            public string OperatingSystem
            {
                get { return this._operatingSystem; }
                set { this._operatingSystem = value; }
            }
            
            private string _oSState;
            
            /// <summary>
            /// Optional. The operating system state in the virtual machine.
            /// </summary>
            public string OSState
            {
                get { return this._oSState; }
                set { this._oSState = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the OSDiskConfiguration class.
            /// </summary>
            public OSDiskConfiguration()
            {
            }
        }
        
        /// <summary>
        /// A virtual machine image associated with your subscription.
        /// </summary>
        public partial class VirtualMachineVMImage
        {
            private string _affinityGroup;
            
            /// <summary>
            /// Optional. The affinity group name of the virtual machine image.
            /// </summary>
            public string AffinityGroup
            {
                get { return this._affinityGroup; }
                set { this._affinityGroup = value; }
            }
            
            private string _category;
            
            /// <summary>
            /// Optional. The classification of the virtual machine image.
            /// </summary>
            public string Category
            {
                get { return this._category; }
                set { this._category = value; }
            }
            
            private System.DateTime? _createdTime;
            
            /// <summary>
            /// Optional. The date when the virtual machine image was created.
            /// </summary>
            public System.DateTime? CreatedTime
            {
                get { return this._createdTime; }
                set { this._createdTime = value; }
            }
            
            private IList<VirtualMachineVMImageListResponse.DataDiskConfiguration> _dataDiskConfigurations;
            
            /// <summary>
            /// Optional. The data disk configurations.
            /// </summary>
            public IList<VirtualMachineVMImageListResponse.DataDiskConfiguration> DataDiskConfigurations
            {
                get { return this._dataDiskConfigurations; }
                set { this._dataDiskConfigurations = value; }
            }
            
            private string _deploymentName;
            
            /// <summary>
            /// Optional. The deployment name of the virtual machine image.
            /// </summary>
            public string DeploymentName
            {
                get { return this._deploymentName; }
                set { this._deploymentName = value; }
            }
            
            private string _description;
            
            /// <summary>
            /// Optional. The description of the virtual machine image.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _eula;
            
            /// <summary>
            /// Optional. Specifies the End User License Agreement that is
            /// associated with the image. The value for this element is a
            /// string, but it is recommended that the value be a URL that
            /// points to a EULA.
            /// </summary>
            public string Eula
            {
                get { return this._eula; }
                set { this._eula = value; }
            }
            
            private Uri _iconUri;
            
            /// <summary>
            /// Optional. Provides the URI to the icon for this Operating
            /// System Image.
            /// </summary>
            public Uri IconUri
            {
                get { return this._iconUri; }
                set { this._iconUri = value; }
            }
            
            private string _imageFamily;
            
            /// <summary>
            /// Optional. The image family of the virtual machine image.
            /// </summary>
            public string ImageFamily
            {
                get { return this._imageFamily; }
                set { this._imageFamily = value; }
            }
            
            private bool? _isPremium;
            
            /// <summary>
            /// Optional. The indicator of whether the virtual machine image is
            /// premium.
            /// </summary>
            public bool? IsPremium
            {
                get { return this._isPremium; }
                set { this._isPremium = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. An identifier for the virtual machine image.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _language;
            
            /// <summary>
            /// Optional. The language of the virtual machine image.
            /// </summary>
            public string Language
            {
                get { return this._language; }
                set { this._language = value; }
            }
            
            private string _location;
            
            /// <summary>
            /// Optional. The location name of the virtual machine image.
            /// </summary>
            public string Location
            {
                get { return this._location; }
                set { this._location = value; }
            }
            
            private System.DateTime? _modifiedTime;
            
            /// <summary>
            /// Optional. The date when the virtual machine image was created.
            /// </summary>
            public System.DateTime? ModifiedTime
            {
                get { return this._modifiedTime; }
                set { this._modifiedTime = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of the virtual machine image.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private VirtualMachineVMImageListResponse.OSDiskConfiguration _oSDiskConfiguration;
            
            /// <summary>
            /// Optional. The OS disk configuration.
            /// </summary>
            public VirtualMachineVMImageListResponse.OSDiskConfiguration OSDiskConfiguration
            {
                get { return this._oSDiskConfiguration; }
                set { this._oSDiskConfiguration = value; }
            }
            
            private Uri _pricingDetailLink;
            
            /// <summary>
            /// Optional. Specifies the URI that points to the pricing detail.
            /// </summary>
            public Uri PricingDetailLink
            {
                get { return this._pricingDetailLink; }
                set { this._pricingDetailLink = value; }
            }
            
            private Uri _privacyUri;
            
            /// <summary>
            /// Optional. Specifies the URI that points to a document that
            /// contains the privacy policy related to the image.
            /// </summary>
            public Uri PrivacyUri
            {
                get { return this._privacyUri; }
                set { this._privacyUri = value; }
            }
            
            private System.DateTime? _publishedDate;
            
            /// <summary>
            /// Optional. Specifies the date when the image was added to the
            /// image repository.
            /// </summary>
            public System.DateTime? PublishedDate
            {
                get { return this._publishedDate; }
                set { this._publishedDate = value; }
            }
            
            private string _publisherName;
            
            /// <summary>
            /// Optional. The name of the publisher of this VM Image in Azure.
            /// </summary>
            public string PublisherName
            {
                get { return this._publisherName; }
                set { this._publisherName = value; }
            }
            
            private string _recommendedVMSize;
            
            /// <summary>
            /// Optional. The recommended size of the virtual machine image.
            /// </summary>
            public string RecommendedVMSize
            {
                get { return this._recommendedVMSize; }
                set { this._recommendedVMSize = value; }
            }
            
            private string _roleName;
            
            /// <summary>
            /// Optional. The role name of the virtual machine image.
            /// </summary>
            public string RoleName
            {
                get { return this._roleName; }
                set { this._roleName = value; }
            }
            
            private string _serviceName;
            
            /// <summary>
            /// Optional. The service name of the virtual machine image.
            /// </summary>
            public string ServiceName
            {
                get { return this._serviceName; }
                set { this._serviceName = value; }
            }
            
            private bool? _showInGui;
            
            /// <summary>
            /// Optional. Specifies whether to show in Gui.
            /// </summary>
            public bool? ShowInGui
            {
                get { return this._showInGui; }
                set { this._showInGui = value; }
            }
            
            private Uri _smallIconUri;
            
            /// <summary>
            /// Optional. Specifies the URI to the small icon that is displayed
            /// when the image is presented in the Azure Management Portal.
            /// </summary>
            public Uri SmallIconUri
            {
                get { return this._smallIconUri; }
                set { this._smallIconUri = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the VirtualMachineVMImage class.
            /// </summary>
            public VirtualMachineVMImage()
            {
                this.DataDiskConfigurations = new LazyList<VirtualMachineVMImageListResponse.DataDiskConfiguration>();
            }
        }
    }
}
