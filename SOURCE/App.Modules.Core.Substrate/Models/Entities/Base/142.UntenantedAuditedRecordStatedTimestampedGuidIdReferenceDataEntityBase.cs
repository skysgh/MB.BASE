﻿namespace App.Modules.Core.Substrate.tmp.Models.Entities.Base
{
    using System;
    using App.Modules.Core.Substrate.Models.Contracts;

    /// <summary>
    /// <para>
    /// Note that this Base runs parrallel to
    /// <see cref="UntenantedAuditedRecordStatedTimestampedCustomIdReferenceDataEntityBase{TId}"/>
    /// (inheritence line is based on Id Type).
    /// </para>
    /// 
    /// <para>
    /// Does Not Implements:
    /// <list type="bullet">
    /// <item><see cref="IHasTenantFK"/></item>,
    /// </list>
    /// </para>
    /// 
    /// <para>
    /// Does Implement:
    /// <list type="bullet">
    /// <item><see cref="IHasGuidId"/></item>,
    /// <item><see cref="IHasTimestampRecordStateInRecordAuditability"/></item>,
    /// <item><see cref="IHasReferenceDataOfGenericIdEnabledTitleDescImgUrlDisplayHints{TId}"/></item>,
    /// </list>
    /// </para>    
    /// 
    /// </summary>
    public abstract class UntenantedAuditedRecordStatedTimestampedGuidIdReferenceDataEntityBase :
        UntenantedAuditedRecordStatedTimestampedCustomIdReferenceDataEntityBase<Guid>,
        IHasGuidId
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected UntenantedAuditedRecordStatedTimestampedGuidIdReferenceDataEntityBase() : base()
        {
        }

    }


}
