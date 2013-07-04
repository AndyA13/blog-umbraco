﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Home.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The home.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using Vega.USiteBuilder;

    /// <summary>
    /// The home.
    /// </summary>
    [DocumentType(Description = "The home page document type.", IconUrl = "home.png")]
    public class Home : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public Home(int nodeId)
            : base(nodeId)
        {
        }
    }
}