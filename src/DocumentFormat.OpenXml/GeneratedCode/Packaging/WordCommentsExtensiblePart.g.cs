﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WordCommentsExtensiblePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2021)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class WordCommentsExtensiblePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.commentsExtensible+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2018/08/relationships/commentsExtensible";
        private DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible? _rootElement;

        /// <summary>
        /// Creates an instance of the WordCommentsExtensiblePart OpenXmlType
        /// </summary>
        internal protected WordCommentsExtensiblePart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible CommentsExtensible
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible>();
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
                _rootElement = value as DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => CommentsExtensible;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "commentsExtensible";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
    }
}
