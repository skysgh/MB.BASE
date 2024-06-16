﻿namespace App.Modules.Core.Substrate.Models.Contracts
{
    /// <summary>
    /// <para>Prefer to 
    /// <see cref="IHasImageUrl"/>
    /// </para>
    /// </summary>
    public interface IHasImageUrlNullable
    {
        /// <summary>
        /// Nullable Url to an image
        /// </summary>
        string? ImageUrl { get; set; }
    }

}