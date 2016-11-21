﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent.Core;
using Microsoft.Azure.Management.Resource.Fluent.Core.ResourceActions;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.Network.Fluent
{
    public abstract class NetworkGroupableParentResourceImpl<IFluentResourceT,
        InnerResourceT,
        FluentResourceT,
        InnerCollectionT,
        IDefinitionAfterRegion,
        IDefinitionAfterResourceGroup,
        DefTypeWithTags,
        UTypeWithTags> :
        GroupableParentResource<IFluentResourceT,
            InnerResourceT,
            FluentResourceT,
            INetworkManager,
            IDefinitionAfterRegion,
            IDefinitionAfterResourceGroup,
            DefTypeWithTags,
            UTypeWithTags>
        where FluentResourceT : NetworkGroupableParentResourceImpl<IFluentResourceT,
            InnerResourceT,
            FluentResourceT,
            InnerCollectionT,
            IDefinitionAfterRegion,
            IDefinitionAfterResourceGroup,
            DefTypeWithTags,
            UTypeWithTags>, IFluentResourceT
        where IFluentResourceT : class, IResource
        where InnerResourceT : Microsoft.Azure.Management.Resource.Fluent.Resource
        where IDefinitionAfterRegion : class
        where IDefinitionAfterResourceGroup : class
        where DefTypeWithTags : class
        where UTypeWithTags : class
    {
        protected const string DEFAULT = "default";
        protected IDictionary<string, string> creatablePIPKeys = new Dictionary<string, string>();
        protected InnerCollectionT innerCollection;

        protected NetworkGroupableParentResourceImpl(
            string name,
            InnerResourceT innerModel,
            InnerCollectionT innerCollection,
            NetworkManager networkManager) : base(name, innerModel, networkManager)
        {
            this.innerCollection = innerCollection;
        }

        internal abstract FluentResourceT WithExistingPublicIpAddress(string resourceId, string childName);

        protected override void BeforeCreating()
        {
            // Account for the newly created public IPs
            foreach(var pipFrontendAssociation in this.creatablePIPKeys)
            {
                IPublicIpAddress pip = (IPublicIpAddress)this.CreatedResource(pipFrontendAssociation.Key);
                if (pip != null)
                {
                    WithExistingPublicIpAddress(pip.Id, pipFrontendAssociation.Value);
                }
            }
            this.creatablePIPKeys.Clear();
        }

        internal FluentResourceT WithNewPublicIpAddress(ICreatable<IPublicIpAddress> creatablePIP)
        {
            creatablePIPKeys.Add(creatablePIP.Key, DEFAULT);
            AddCreatableDependency(creatablePIP as IResourceCreator<IResource>);
            return this as FluentResourceT;
        }

        internal FluentResourceT WithExistingPublicIpAddress(IPublicIpAddress publicIpAddress)
        {
            return WithExistingPublicIpAddress(publicIpAddress.Id, DEFAULT);
        }

        private FluentResourceT WithExistingPublicIpAddress(string resourceId)
        {
            return WithExistingPublicIpAddress(resourceId, DEFAULT);
        }

        internal FluentResourceT WithNewPublicIpAddress()
        {
            // Autogenerated DNS leaf label for the PIP
            string dnsLeafLabel = this.Name.ToLower().Replace("\\s", "");
            return WithNewPublicIpAddress(dnsLeafLabel);
        }

        internal FluentResourceT WithNewPublicIpAddress(string dnsLeafLabel)
        {
            var precreatablePIP = Manager.PublicIpAddresses.Define(dnsLeafLabel)
                .WithRegion(Region);
            ICreatable<IPublicIpAddress> creatablePip;
            if (newGroup == null)
            {
                creatablePip = precreatablePIP.WithExistingResourceGroup(ResourceGroupName);
            }
            else
            {
                creatablePip = precreatablePIP.WithNewResourceGroup(newGroup);
            }

            return WithNewPublicIpAddress(creatablePip);
        }
    }
}