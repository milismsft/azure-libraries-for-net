// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Collections.Generic;

    /// <summary>
    /// Storage resource types.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnN0b3JhZ2UuU3RvcmFnZVJlc291cmNlVHlwZQ==
    public partial class StorageResourceType  :
        ExpandableStringEnum<Microsoft.Azure.Management.Storage.Fluent.StorageResourceType>
    {
        public StorageResourceType STORAGE_ACCOUNTS;
        ///GENMHASH:558732C9B6D57168427B3BD93C6A69BC:27E486AB74A10242FF421C0798DDC450
        public  StorageResourceType()
        {
            //$ 

        }

        /// <return>Known storage resource types.</return>
        ///GENMHASH:B6EAF7CA43219B097DF06B50881D6E8F:893A97B162875DE755154587EE86109F
        public static IReadOnlyCollection<Microsoft.Azure.Management.Storage.Fluent.StorageResourceType> Values()
        {
            //$ return values(StorageResourceType.Class);
            //$ }

            return null;
        }

        /// <summary>
        /// Finds or creates storage resource type based on the specified string.
        /// </summary>
        /// <param name="str">The storage resource type in string format.</param>
        /// <return>An instance of StorageResourceType.</return>
        ///GENMHASH:9716C5DFA259044737E756C8AC3056E1:6949813F261650C79B4A05BB32646212
        public static StorageResourceType FromString(string str)
        {
            //$ return fromString(str, StorageResourceType.Class);
            //$ }

            return this;
        }
    }
}