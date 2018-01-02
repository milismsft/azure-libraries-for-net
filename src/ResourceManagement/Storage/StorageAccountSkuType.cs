// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.Storage.Fluent.Models;

    /// <summary>
    /// Defines sku values for storage account resource.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnN0b3JhZ2UuU3RvcmFnZUFjY291bnRTa3VUeXBl
    public sealed partial class StorageAccountSkuType  :
        object
    {
        public StorageAccountSkuType STANDARD_LRS;
        public StorageAccountSkuType STANDARD_GRS;
        public StorageAccountSkuType STANDARD_RAGRS;
        public StorageAccountSkuType STANDARD_ZRS;
        public StorageAccountSkuType PREMIUM_LRS;
        private SkuName name;
        /// <return>The storage account sku name.</return>
        ///GENMHASH:3E38805ED0E7BA3CAEE31311D032A21C:9DFC3C722BEBD17B99B0AB691D43FC18
        public SkuName Name()
        {
            //$ return this.name;
            //$ }

            return SkuName.STANDARD_LRS;
        }

        /// <summary>
        /// Creates StorageAccountSkuType.
        /// </summary>
        /// <param name="name">The sku name.</param>
        ///GENMHASH:EF53E50AC37DC7066021CE6A9A220A86:E90E057B35B54BD4BB255BF9F90BDCE7
        private  StorageAccountSkuType(SkuName name)
        {
            //$ this.name = name;
            //$ }

        }

        /// <summary>
        /// Creates StorageAccountSkuType from sku name.
        /// </summary>
        /// <param name="name">The sku name.</param>
        /// <return>StorageAccountSkuType corresponds to the given sku name.</return>
        ///GENMHASH:EA0FFCF5494181C865C9BB6C21CA6449:6623E3FCE01FF3FE0D477CDD3512F180
        public static StorageAccountSkuType FromSkuName(SkuName name)
        {
            //$ return new StorageAccountSkuType(name);
            //$ }

            return this;
        }
    }
}