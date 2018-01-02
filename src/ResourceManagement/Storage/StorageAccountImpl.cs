// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using Microsoft.Azure.Management.Storage.Fluent.StorageAccount.Definition;
    using Microsoft.Azure.Management.Storage.Fluent.StorageAccount.Update;
    using System.Collections.Generic;
    using System;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// Implementation for IStorageAccount.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnN0b3JhZ2UuaW1wbGVtZW50YXRpb24uU3RvcmFnZUFjY291bnRJbXBs
    internal partial class StorageAccountImpl  :
            GroupableResource<
            IStorageAccount,
            StorageAccountInner,
            StorageAccountImpl,
            IStorageManager,
            IWithGroup,
            IWithCreate,
            IWithCreate,
            IUpdate>,
        IStorageAccount,
        IDefinition,
        IUpdate
    {
        private StorageAccountCreateParametersInner createParameters;
        private StorageAccountUpdateParametersInner updateParameters;

        ///GENMHASH:9EC86FDAF9C3238B45EB0EE4355F4919:01A8E19E4477D51C1F8BB7C63F151C69
        internal StorageAccountImpl(string name, StorageAccountInner innerModel, IStorageManager storageManager) : base(name, innerModel, storageManager)
        {
            createParameters = new StorageAccountCreateParametersInner();
        }

        ///GENMHASH:314904A5E85B219428D83117662B69FD:F7D362F18E06781D864DECF6CC7D3C61
        public AccountStatuses AccountStatuses()
        {
            return new AccountStatuses(Inner.StatusOfPrimary, Inner.StatusOfSecondary);
        }

        public Sku Sku()
        {
            return Inner.Sku;
        }

        ///GENMHASH:C4C0D4751CA4E1904C31CE6DF0B02AC3:B5986EB96489F714DC052E1136F06A45
        public Kind Kind()
        {
            // TODO: In the next major version upgrade of SDK change return type to nullable
            //       returning the default enum value when server returns null is not expected
            return Inner.Kind.HasValue ? Inner.Kind.Value : default(Kind);
        }

        ///GENMHASH:BCE4AA46C905DCE36E6D5BDD93BA93B0:1B56C35879CE652985BD4F328B841261
        public DateTime CreationTime()
        {
            return Inner.CreationTime.HasValue ? Inner.CreationTime.Value : default(DateTime);
        }

        ///GENMHASH:13C190C95339C5E47A33E6FC4C200B03:5E23174652AE3CE52750F1DC01FB1134
        public CustomDomain CustomDomain()
        {
            return Inner.CustomDomain;
        }

        ///GENMHASH:D0AE63FDB5966BAADB801257491052D1:E5706C7734A0BD35091288A8B0D51407
        public DateTime LastGeoFailoverTime()
        {
            return Inner.LastGeoFailoverTime.HasValue ? Inner.LastGeoFailoverTime.Value : default(DateTime);
        }

        ///GENMHASH:99D5BF64EA8AA0E287C9B6F77AAD6FC4:220D4662AAC7DF3BEFAF2B253278E85C
        public ProvisioningState ProvisioningState()
        {
            // TODO: In the next major version upgrade of SDK change return type to nullable
            //       returning the default enum value when server returns null is not expected
            return Inner.ProvisioningState.HasValue ? Inner.ProvisioningState.Value : default(ProvisioningState);
        }

        ///GENMHASH:55B42F94DE82BCEA956E2090896DCEA5:93EB9B10265EA252D67B32BBB824A1F6
        public PublicEndpoints EndPoints()
        {
            return new PublicEndpoints(Inner.PrimaryEndpoints, Inner.SecondaryEndpoints);
        }

        ///GENMHASH:C7B3D3963622074C2FD00EB9A2E0FE72:11DD8AD22561ECD1652BDB11C9699DD1
        public Encryption Encryption()
        {
            return Inner.Encryption;
        }

        ///GENMHASH:E3CB6E557BDC02538C5A6963772F3FEF:15D05D69CDC082DB89A322578DD08FE1
        public StorageAccountEncryptionKeySource EncryptionKeySource()
        {
            return StorageEncryptionHelper.EncryptionKeySource(this.Inner);
        }

        ///GENMHASH:26FB96D5CAED2DAC6A25B7684BA6EA62:299BE7E5A8CF6BA9E16D49D77E08F875
        public IReadOnlyDictionary<StorageService, IStorageAccountEncryptionStatus> EncryptionStatuses()
        {
            return StorageEncryptionHelper.EncryptionStatuses(this.Inner);
        }

        ///GENMHASH:F740873A801629829EA1C3C98F4FDDC4:ACAFFE3955CCFBD0C2BC6D268AECA2BA
        public AccessTier AccessTier()
        {
            // TODO: In the next major version upgrade of SDK change return type to nullable
            //       returning the default enum value when server returns null is not expected
            return Inner.AccessTier.HasValue ? Inner.AccessTier.Value : default(AccessTier);
        }

        ///GENMHASH:E4DFA7EA15F8324FB60C810D0C96D2FF:1BCD5CF569F11AB6F798D4F3A5BFC786
        public IReadOnlyList<Models.StorageAccountKey> GetKeys()
        {
            return Extensions.Synchronize(() => GetKeysAsync());
        }

        ///GENMHASH:2751D8683222AD34691166D915065302:626481EC1E21C06AD0B6BDD35321AA29
        public async Task<System.Collections.Generic.IReadOnlyList<Models.StorageAccountKey>> GetKeysAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var keysResultInner = await this.Manager.Inner.StorageAccounts.ListKeysAsync(this.ResourceGroupName, this.Name, cancellationToken);
            var keys = new List<StorageAccountKey>();
            keys.AddRange(keysResultInner.Keys);
            return keys;
        }

        ///GENMHASH:FE5C90217FF36474FA8DE7E91403E40F:8A9D1B7CB45D0ABAC76D65E99FADA580
        public IReadOnlyList<Models.StorageAccountKey> RegenerateKey(string keyName)
        {
            return Extensions.Synchronize(() => RegenerateKeyAsync(keyName));
        }

        ///GENMHASH:AC9981EE195A3F3ECFFF4F080A6FEAAD:0AE932BB7FDBF07328B9F81662B43B8C
        public async Task<System.Collections.Generic.IReadOnlyList<Models.StorageAccountKey>> RegenerateKeyAsync(string keyName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var regeneratedKeysResultInner = await Manager.Inner.StorageAccounts.RegenerateKeyAsync(this.ResourceGroupName, this.Name, keyName, cancellationToken);
            var regeneratedKeys = new List<StorageAccountKey>();
            regeneratedKeys.AddRange(regeneratedKeysResultInner.Keys);
            return regeneratedKeys;
        }

        ///GENMHASH:5A2D79502EDA81E37A36694062AEDC65:F43E8F467DCA84E8666ED727725A26A8
        public async override Task<Microsoft.Azure.Management.Storage.Fluent.IStorageAccount> RefreshAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var inner = await GetInnerAsync(cancellationToken);
            this.SetInner(inner);
            return this;
        }

        ///GENMHASH:5AD91481A0966B059A478CD4E9DD9466:59D34F73D07BE052EC4D175FC76C75FF
        protected override Task<Models.StorageAccountInner> GetInnerAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // Note: Using GetPropertiesAsync instead of GetAsync to get extended information about the storage account.
            //
            return this.Manager.Inner.StorageAccounts.GetPropertiesAsync(this.ResourceGroupName, this.Name, cancellationToken);
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ public StorageAccountImpl withSku(SkuName skuName) {
            //$ return withSku(StorageAccountSkuType.FromSkuName(skuName));

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        ///GENMHASH:B5E3D903BDA1F2A62441339A3042D8F4:39725B0498CCC3701985F13AE17C0DB9
        public StorageAccountImpl WithSku(SkuName skuName)
        {
            if (IsInCreateMode)
            {
                createParameters.Sku = new Sku
                {
                    Name = skuName
                };
            }
            else
            {
                updateParameters.Sku = new Sku
                {
                    Name = skuName
                };
            }
            return this;
        }

        ///GENMHASH:04DD7C0A29E2A433420E3CC1BCC83642:AE8E0FE7D34A8D01F4AED46E07861F2F
        public StorageAccountImpl WithBlobStorageAccountKind()
        {
            createParameters.Kind = Models.Kind.BlobStorage;
            // It is required to set AccessTier for BlobStorage kind, default it to Hot (as portal does)
            createParameters.AccessTier = Models.AccessTier.Hot;
            return this;
        }

        ///GENMHASH:A3DE4AE524C4F886153A43EE5DD7157A:ECF5D7B6B3EF47B86D11FDF931EFFD89
        public StorageAccountImpl WithGeneralPurposeAccountKind()
        {
            createParameters.Kind = Models.Kind.Storage;
            return this;
        }


//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ public StorageAccountImpl withEncryption() {
            //$ return withBlobEncryption();

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        ///GENMHASH:56847EFF91F827802715E0B549682639:A52F88293839228BBEBEEC9EB4D0DB68
        public StorageAccountImpl WithEncryption()
        {
            Encryption encryption;
            if (this.Inner.Encryption != null)
            {
                encryption = this.Inner.Encryption;
            }
            else
            {
                encryption = new Encryption();
            }
            if (encryption.Services == null)
            {
                encryption.Services = new EncryptionServices();
            }
            //if (Encryption.KeySource == null) // Unlike Java this is static in the generated code with value set to "Microsoft.Storage"
            //{
            //    encryption.KeySource = "Microsoft.Storage";
            //}

            // Enable encryption for blob service
            //
            if (encryption.Services.Blob == null)
            {
                encryption.Services.Blob = new EncryptionService();
            }
            encryption.Services.Blob.Enabled = true;
            // Code for enabling encryption for other service will be added as storage start supporting them.
            //
            if (IsInCreateMode)
            {
                createParameters.Encryption = encryption;
            }
            else
            {
                updateParameters.Encryption = encryption;
            }
            return this;
        }


//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ public StorageAccountImpl withoutEncryption() {
            //$ return withoutBlobEncryption();

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        ///GENMHASH:7A1BAFE758BD50E4AF6B50ADFDAD2EF5:F90635EB7EEC5820E29B2722F77122F8
        public StorageAccountImpl WithoutEncryption()
        {
            if (this.Inner.Encryption == null
                || this.Inner.Encryption.Services == null)
            {
                return this;
            }
            Encryption encryption = this.Inner.Encryption;
            // Disable encryption for blob service
            //
            if (encryption.Services.Blob == null)
            {
                return this;
            }
            encryption.Services.Blob.Enabled = false;
            // Code for disabling encryption for other service will be added as storage start supporting them.
           //
           updateParameters.Encryption = encryption;
            return this;
        }

        ///GENMHASH:6BCE517E09457FF033728269C8936E64:789C9582170BCB5E4150FE4603AF40D4
        public override IUpdate Update()
        {
//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ createParameters = null;
            //$ updateParameters = new StorageAccountUpdateParametersInner();
            //$ this.networkRulesHelper = new StorageNetworkRulesHelper(this.updateParameters, this.Inner);
            //$ this.encryptionHelper = new StorageEncryptionHelper(this.updateParameters, this.Inner);
            //$ return super.Update();

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            updateParameters = new StorageAccountUpdateParametersInner();
            return this;
        }

        ///GENMHASH:C6CC40946571810DF92A3D04D369CBCD:391ADF63D3B3B254E14435035F093D3D
        public StorageAccountImpl WithCustomDomain(CustomDomain customDomain)
        {
            if (IsInCreateMode)
            {
                createParameters.CustomDomain = customDomain;
            }
            else
            {
                updateParameters.CustomDomain = customDomain;
            }
            return this;
        }


        ///GENMHASH:870B1F6CF318C295B15B16948090E5A0:8CB56B0910716CE2C6BEC9D228235089
        public StorageAccountImpl WithCustomDomain(string name)
        {
            return WithCustomDomain(new CustomDomain() { Name = name });
        }

        ///GENMHASH:FFCBE36D39C79DC1A7BAEB75300E5C0B:7D6B565DFE17585F8E3B4BB3D13BDD7A
        public StorageAccountImpl WithCustomDomain(string name, bool useSubDomain)
        {
            return WithCustomDomain(new CustomDomain() { Name = name, UseSubDomain = useSubDomain });
        }

        ///GENMHASH:F3C7D5F595E480B52B33BC7ACD704928:6B5BD9106155829D3669430155DCDD3B
        public StorageAccountImpl WithAccessTier(AccessTier accessTier)
        {
            if (IsInCreateMode)
            {
                createParameters.AccessTier = accessTier;
            }
            else
            {
                if (this.Inner.Kind != Models.Kind.BlobStorage)
                {
                    throw new NotSupportedException($"Access tier can changed only for blob storage account type 'BlobStorage', the account type of this account is '{this.Inner.Kind}'");
                }
                updateParameters.AccessTier = accessTier;
            }
            return this;
        }

        ///GENMHASH:507A92D4DCD93CE9595A78198DEBDFCF:F8796591A930D091E7B7BB504EDF104C
        private async Task<Microsoft.Azure.Management.Storage.Fluent.IStorageAccount> UpdateResourceAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ this.networkRulesHelper.SetDefaultActionIfRequired();
            //$ updateParameters.WithTags(this.Inner.GetTags());
            //$ return this.Manager().Inner.StorageAccounts().UpdateAsync(
            //$ resourceGroupName(), name(), updateParameters)
            //$ .Map(innerToFluentMap(this))
            //$ .DoOnNext(new Action1<StorageAccount>() {
            //$ @Override
            //$ public void call(StorageAccount storageAccount) {
            //$ clearWrapperProperties();
            //$ }
            //$ });

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            updateParameters.Tags = this.Inner.Tags;
            var response = await Manager.Inner.StorageAccounts.UpdateAsync(this.ResourceGroupName, this.Name, updateParameters, cancellationToken);
            SetInner(response);
            return this;
        }

        ///GENMHASH:0202A00A1DCF248D2647DBDBEF2CA865:396945BF91DBD726EDD39E5061E66D9B
        public async override Task<Microsoft.Azure.Management.Storage.Fluent.IStorageAccount> CreateResourceAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
//<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGED>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //$ this.networkRulesHelper.SetDefaultActionIfRequired();
            //$ createParameters.WithLocation(this.RegionName());
            //$ createParameters.WithTags(this.Inner.GetTags());
            //$ StorageAccountsInner client = this.Manager().Inner.StorageAccounts();
            //$ return this.Manager().Inner.StorageAccounts().CreateAsync(
            //$ this.ResourceGroupName(), this.Name(), createParameters)
            //$ .FlatMap(new Func1<StorageAccountInner, Observable<StorageAccountInner>>() {
            //$ @Override
            //$ public Observable<StorageAccountInner> call(StorageAccountInner storageAccountInner) {
            //$ return client.GetByResourceGroupAsync(resourceGroupName(), name());
            //$ }
            //$ })
            //$ .Map(innerToFluentMap(this))
            //$ .DoOnNext(new Action1<StorageAccount>() {
            //$ @Override
            //$ public void call(StorageAccount storageAccount) {
            //$ clearWrapperProperties();
            //$ }
            //$ });

//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            if (IsInCreateMode)
            {
                createParameters.Location = this.RegionName;
                createParameters.Tags = Inner.Tags;
                await Manager.Inner.StorageAccounts.CreateAsync(ResourceGroupName, this.Name, createParameters, cancellationToken);
            }
             else
            {
                await UpdateResourceAsync(cancellationToken);
            }
            // Note: Using GetPropertiesAsync instead of GetAsync to get extended information about the storage account.
            //
            var response = await Manager.Inner.StorageAccounts.GetPropertiesAsync(this.ResourceGroupName, this.Name, cancellationToken);
            SetInner(response);
            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:C2F133AE0FC89EEF547B4FFB5C0D4A9A:D697721F4651F53E38F6D4FCD3641956
        public IReadOnlyList<string> IPAddressesWithAccess()
        {
            //$ return StorageNetworkRulesHelper.IpAddressesWithAccess(this.Inner);

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:F75CDC99E2E9A344C379CC08F9D4ACBA:1B57F0CF078BDC2FBB69009DCAA738BF
        public StorageAccountImpl WithoutIpAddressAccess(string ipAddress)
        {
            //$ this.networkRulesHelper.WithoutIpAddressAccess(ipAddress);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:847E4E638739C7FA6EB5C3D39F01D033:439CF90D7EC28B697ACF448240AB7FEE
        public StorageAccountImpl WithoutIpAddressRangeAccess(string ipAddressCidr)
        {
            //$ this.networkRulesHelper.WithoutIpAddressRangeAccess(ipAddressCidr);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:47814D91B7A8A8F74570591144A25ED7:537F70D4211A4C0BAA4DA9384F300CE7
        public StorageAccountImpl WithoutFileEncryption()
        {
            //$ this.encryptionHelper.WithoutFileEncryption();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:67CB6A707CF4CE9C04EDC62F0AB0957B:EC6C10E7AC6EAA96BE30D799405C561D
        public IUpdate WithoutReadAccessToLoggingFromAnyNetwork()
        {
            //$ this.networkRulesHelper.WithoutReadAccessToLoggingFromAnyNetwork();
            //$ return this;

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:9EF4A08D221595621FDCAFD7FD09AFE2:A9B0A04022BFC4614AF74D0C3B8D24B3
        public StorageAccountSkuType SkuType()
        {
            //$ // We deprecated the sku() getter. When we remove it we wanted to rename this
            //$ // 'beta' getter skuType() to sku().
            //$ //
            //$ return StorageAccountSkuType.FromSkuName(this.Inner.Sku().Name());

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:18BC5BF9B6EE1BC9B55B8D4EBCB3B56D:071B91D6CC3A043AF5B0A52BEB68A01C
        public StorageAccountImpl WithReadAccessToMetricsFromAnyNetwork()
        {
            //$ this.networkRulesHelper.WithReadAccessToMetricsFromAnyNetwork();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:8F0CB7D0D160167569B264A540A0BB4A:E9F85A46428F9258D9FA551AC383C59E
        public StorageAccountImpl WithFileEncryption()
        {
            //$ this.encryptionHelper.WithFileEncryption();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:675D6BA74B1BD5A9B8A67B69014F3D7F:77135B4BAB586DE5D2DF55334DB979F4
        public IUpdate WithoutReadAccessToMetricsFromAnyNetwork()
        {
            //$ this.networkRulesHelper.WithoutReadAccessToMetricsFromAnyNetwork();
            //$ return this;

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:1DE818A27E19C3570203A965AF1E4473:9CF481E89FC6E9693DDA32E2E66E4780
        public StorageAccountImpl WithReadAccessToLogEntriesFromAnyNetwork()
        {
            //$ this.networkRulesHelper.WithReadAccessToLoggingFromAnyNetwork();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:0FB19BD71D35E8BAC2D116947E61A25B:F39C5F9C924B9F87BEBDD6863846F295
        public IUpdate WithoutAccessFromAzureServices()
        {
            //$ this.networkRulesHelper.WithoutAccessFromAzureServices();
            //$ return this;

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:0A1DFCA64C9498252BE32BC3BFBE9F4A:4A8B2CAAD11BAA8DA32A64FBF8D1F05C
        public StorageAccountImpl WithAccessFromIpAddressRange(string ipAddressCidr)
        {
            //$ this.networkRulesHelper.WithAccessFromIpAddressRange(ipAddressCidr);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:7DB2D011B5CDF195415C6720ACC92AE5:482E38947F67648FBA023601C94F4B47
        public StorageAccountImpl WithAccessFromIpAddress(string ipAddress)
        {
            //$ this.networkRulesHelper.WithAccessFromIpAddress(ipAddress);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:55BB1382A3EA3FEBBDF95215151F8990:EC2A3550C3FC9D5A9AA0BCF7A70A3716
        public StorageAccountImpl WithOnlyHttpsTraffic()
        {
            //$ if (isInCreateMode()) {
            //$ createParameters.WithEnableHttpsTrafficOnly(true);
            //$ } else {
            //$ updateParameters.WithEnableHttpsTrafficOnly(true);
            //$ }
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:B9EE029C143C1C09C5669B4A3FBECE62:2C9D16335ED25FB93661206B20DBFA41
        public StorageAccountImpl WithAccessFromAllNetworks()
        {
            //$ this.networkRulesHelper.WithAccessFromAllNetworks();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:28F05A97A27982A7F92482B99325EBF3:AE1D120BA1CBBD85816F0BBF8499E8E2
        public string SystemAssignedManagedServiceIdentityTenantId()
        {
            //$ if (this.Inner.Identity() == null) {
            //$ return null;
            //$ } else {
            //$ return this.Inner.Identity().TenantId();
            //$ }

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:7F723CF72B72C34A91B63032AF06AECB:4ABE8556FCA26F394CBB1062DEF08544
        public StorageAccountImpl WithSystemAssignedManagedServiceIdentity()
        {
            //$ if (this.Inner.Identity() == null) {
            //$ if (isInCreateMode()) {
            //$ createParameters.WithIdentity(new Identity().WithType("SystemAssigned"));
            //$ } else {
            //$ updateParameters.WithIdentity(new Identity().WithType("SystemAssigned"));
            //$ }
            //$ }
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:39F9317665E14B578822CE3749ACE22A:CFEA11B8E97856C5DD3E4913EBE449A4
        public bool CanReadLogEntriesFromAnyNetwork()
        {
            //$ return StorageNetworkRulesHelper.CanReadLogEntriesFromAnyNetwork(this.Inner);

            return false;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:EDC6F988FEE2B3931AAAFB28D1C233D0:22984BE7239A6ED410C1A3096E7F5921
        public StorageAccountImpl WithHttpAndHttpsTraffic()
        {
            //$ updateParameters.WithEnableHttpsTrafficOnly(false);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:66DAA29A825C045119A8F4AFEB963F9C:770F37FD74925A1180EE8B6AC2112150
        public StorageAccountImpl WithSku(StorageAccountSkuType sku)
        {
            //$ if (isInCreateMode()) {
            //$ createParameters.WithSku(new SkuInner().WithName(sku.Name()));
            //$ } else {
            //$ updateParameters.WithSku(new SkuInner().WithName(sku.Name()));
            //$ }
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:87673CC4832F4C7743B7F31A22932B78:006EEBF5C60FFF48087E596AA5009028
        public string SystemAssignedManagedServiceIdentityPrincipalId()
        {
            //$ if (this.Inner.Identity() == null) {
            //$ return null;
            //$ } else {
            //$ return this.Inner.Identity().PrincipalId();
            //$ }

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:C14D790B4D1B66AF7349EAFCBBEA1C91:022FBB38D6CF761960BA9A37C304D284
        public StorageAccountImpl WithAccessFromAzureServices()
        {
            //$ this.networkRulesHelper.WithAccessAllowedFromAzureServices();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:0F1094C94F6F0E279562A3D1A380FE42:4CA0CE1947BBD9EDA4A2FDAC76E23057
        public bool IsAccessAllowedFromAllNetworks()
        {
            //$ return StorageNetworkRulesHelper.IsAccessAllowedFromAllNetworks(this.Inner);

            return false;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:2E99EAA1E93628587B3D73AC7F3EEBC0:153D5C9B12BD32B7BD50116F7562C137
        public StorageAccountImpl WithoutNetworkSubnetAccess(string subnetId)
        {
            //$ this.networkRulesHelper.WithoutNetworkSubnetAccess(subnetId);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:4C85CA9C782D47082FD338D5941F42D7:7FA15A669B08B4C8C6C0B8AB021CA488
        public IReadOnlyList<string> IPAddressRangesWithAccess()
        {
            //$ return StorageNetworkRulesHelper.IpAddressRangesWithAccess(this.Inner);

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:49CBC3AEB9561B9FB0DC7A1948E99A1E:00E82B7EFF5F157EE219904861FE2344
        public StorageAccountImpl WithEncryptionKeyFromKeyVault(string keyVaultUri, string keyName, string keyVersion)
        {
            //$ this.encryptionHelper.WithEncryptionKeyFromKeyVault(keyVaultUri, keyName, keyVersion);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:5D8E21CABBF7FA1B05E1DE0F97141AE5:F784E29F8F04582462AB57328371214C
        public IReadOnlyList<string> NetworkSubnetsWithAccess()
        {
            //$ return StorageNetworkRulesHelper.NetworkSubnetsWithAccess(this.Inner);

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:F792F6C8C594AA68FA7A0FCA92F55B55:5961A2D0C2007F645841A48147A553E6
        public Sku Sku()
        {
            //$ public Sku sku() {
            //$ return new Sku().WithName(this.Inner.Sku().Name());

            return null;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:030DDE9E1AA399E4B7C25223B1F99C60:A0B4F30C967C27CD76D06C595A744C61
        public bool CanReadMetricsFromAnyNetwork()
        {
            //$ return StorageNetworkRulesHelper.CanReadMetricsFromAnyNetwork(this.Inner);

            return false;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:3872F883CE34060251486AD613265A9D:7B252648094C237C0CA4453C8160BA08
        public bool CanAccessFromAzureServices()
        {
            //$ return StorageNetworkRulesHelper.CanAccessFromAzureServices(this.Inner);

            return false;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:A27EB73264D76B7A45B1F3A10FBC3C71:0AE67E88364675BC0080FB2F1D73B90B
        public StorageAccountImpl WithAccessFromNetworkSubnet(string subnetId)
        {
            //$ this.networkRulesHelper.WithAccessFromNetworkSubnet(subnetId);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:01ACF44C50C59F86A43DC2A9B3977F04:322E944F4F0257EED0811C662A4BB65E
        public StorageAccountImpl WithBlobEncryption()
        {
            //$ this.encryptionHelper.WithBlobEncryption();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:E91671491194D4DE7AC3C8A56BE01F87:6D6C0D46C27765D3AFDB60319534D072
        public StorageAccountImpl WithAccessFromSelectedNetworks()
        {
            //$ this.networkRulesHelper.WithAccessFromSelectedNetworks();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:A4FFE5B248CECEBCF1538195316501A2:CCC3BA394841F19A499657C5B54F4608
        public StorageAccountImpl WithoutBlobEncryption()
        {
            //$ this.encryptionHelper.WithoutBlobEncryption();
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:0782D0F11E3B424FF95354F9773F8768:4EB94A70A7472288B3D1E6FA290874EE
        public StorageAccountImpl WithGeneralPurposeAccountKindV2()
        {
            //$ createParameters.WithKind(Kind.STORAGE_V2);
            //$ return this;

            return this;
        }

//<<<<<<<<<<<<<<<<<<<<<<<<<<<NEW>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ///GENMHASH:CDB3E13DA37D921A3A180E0C12DBD1A0:3111BF65AF09AE677B63EBC80DF81917
        private void ClearWrapperProperties()
        {
            //$ accountStatuses = null;
            //$ publicEndpoints = null;
            //$ }

        }

    }
}
