﻿namespace App.Modules.Core.Substrate.tmp.Models.Messages._TOREVIEW.Entities
{
    using App.Modules.Core.Substrate.Models.Contracts;
    using App.Modules.Core.Substrate.tmp.Models.Entities.Base;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    /// <summary>
    /// TODO: Improve documentation
    /// 
    /// </summary>
    public class TenancySecurityProfileAccountRole : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase, IHasTitleAndDescription
    {
        /// <summary>
        /// The Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get/set the permissions
        /// </summary>
        public ICollection<TenancySecurityProfilePermission> Permissions
        {
            get
            {
                return _permissions ??= new Collection<TenancySecurityProfilePermission>();
            }
            set
            {
                _permissions = value;
            }
        }
        /// <summary>
        /// TODO:Public required?
        /// </summary>
        public ICollection<TenancySecurityProfilePermission>? _permissions;


        /// <summary>
        /// Get/set the Permission Assignments
        /// </summary>
        public ICollection<TenancySecurityProfileRoleTenancySecurityProfilePermissionAssignment> PermissionsAssignments
        {
            get
            {
                return _permissionsAssignments ??= new Collection<TenancySecurityProfileRoleTenancySecurityProfilePermissionAssignment>();
            }
            set
            {
                _permissionsAssignments = value;
            }
        }
        /// <summary>
        /// TODO: Public required?
        /// </summary>
        public ICollection<TenancySecurityProfileRoleTenancySecurityProfilePermissionAssignment>? _permissionsAssignments;

    }

}

