﻿namespace App.Modules.Core.Substrate.tmp.Models.Messages._TOREVIEW.Entities.TenancySpecific
{
    using System;
    using App.Modules.Core.Substrate.Models.Contracts;
    using App.Modules.Core.Substrate.tmp.Models.Entities.Base;

    /// <summary>
    /// A Property on the Property of a Principal
    /// </summary>
    public class PrincipalProfileProperty
        : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase,
        IHasOwnerFK
    {
        /// <summary>
        /// The unique Key of the value
        /// </summary>
        public virtual string Key { get; set; } = string.Empty;
        /// <summary>
        /// The string Value
        /// <para>
        /// TODO: Should be Typeable/Serializable (ints, etc.)
        /// </para>
        /// </summary>
        public virtual string Value { get; set; } = string.Empty;

        /// <summary>
        /// Get the FK of the parent <see cref="PrincipalProfile"/>
        /// <para>
        /// A matching object navigation property is not provided.
        /// </para>
        /// </summary>
        public virtual Guid PrincipalProfileFK { get; set; }

        /// <summary>
        /// Get the FK of the parent <see cref="PrincipalProfile"/>
        /// </summary>
        /// <returns></returns>
        public Guid GetOwnerFk()
        {
            return PrincipalProfileFK;
        }
    }
}