namespace App.Base.Shared.Models.ConfigurationSettings
{
    using System;
    using App.Base.Shared.Attributes;
    using App.Modules.Core.Substrate.Models.Contracts;

    /// <summary>
    /// An immutable host configuration object 
    /// describing the Distributor of the application
    /// (distinct from the Creator) in many commercial cases.
    /// </summary>
    /// <seealso cref="Modules.Core.Substrate.Models.Contracts.IHasName" />
    /// <seealso cref="Modules.Core.Substrate.Models.Contracts.IHasDescription" />
    public class ApplicationDistributorInformationConfigurationSettings : IHostSettingsBasedConfigurationObject, IHasName , IHasDescription
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationDistributorInformationConfigurationSettings()
        {
            this.Id = new Guid();
        }

        /// <summary>
        /// The Id.
        /// <para>
        /// To render directly without a DTO, OData always needs an Id. It can be another field, but too much bother
        /// to configure it...
        /// </para>
        /// </summary>
        public Guid Id { get; set; }
        /// <inheritdoc/>


        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreApplicationProviderName)]
        public string Name
        {
            get; set;
        } = string.Empty;

        /// <inheritdoc/>

        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreApplicationProviderDescription)]
        public string Description
        {
            get; set;
        } = string.Empty;

        /// <summary>
        /// The Url of the Site describing the Creator/Distributor
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreApplicationProviderSiteUrl)]
        public string? SiteUrl { get; set; } = string.Empty;


        /// <summary>
        /// The Url of the Contact page describing the Creator/Distributor
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(Constants.ConfigurationKeys.AppCoreApplicationProviderContactUrl)]
        public string? ContactUrl { get; set; } = string.Empty;
    }
}