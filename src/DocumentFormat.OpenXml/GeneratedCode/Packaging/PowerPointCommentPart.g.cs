﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the PowerPointCommentPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2021)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class PowerPointCommentPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-powerpoint.comments+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2018/10/relationships/comments";
        private DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentList? _rootElement;

        /// <summary>
        /// Creates an instance of the PowerPointCommentPart OpenXmlType
        /// </summary>
        internal protected PowerPointCommentPart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentList CommentList
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentList>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentList;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => CommentList;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "moderncomment";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "comments";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
    }
}
