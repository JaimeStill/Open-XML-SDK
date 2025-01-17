﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Drawing.Command
{
    /// <summary>
    /// <para>Defines the ShapeMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:spMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeMoniker class.
        /// </summary>
        public ShapeMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:spMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ShapeMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:grpSpMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeMoniker class.
        /// </summary>
        public GroupShapeMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:grpSpMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<GroupShapeMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicFrameMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicFrameMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:graphicFrameMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicFrameMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrameMoniker class.
        /// </summary>
        public GraphicFrameMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:graphicFrameMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<GraphicFrameMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectorMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cxnSpMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cxnSpMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ConnectorMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMoniker class.
        /// </summary>
        public ConnectorMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cxnSpMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ConnectorMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectorMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the PictureMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:picMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:picMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PictureMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureMoniker class.
        /// </summary>
        public PictureMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:picMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PictureMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the InkMoniker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:inkMk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:inkMk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InkMoniker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the InkMoniker class.
        /// </summary>
        public InkMoniker() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>creationId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: creationId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("creationId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CreationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:inkMk");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<InkMoniker>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("creationId", a => a.CreationId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkMoniker>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dgMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:dgMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class.
        /// </summary>
        public DrawingMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DrawingMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:dgMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform2D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipV")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:xfrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("flipH", a => a.HorizontalFlip)
.AddAttribute("flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:grpSpMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class.
        /// </summary>
        public GroupShapeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:grpSpMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingElementPackage Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dePkg.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:dePkg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingElementPackage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingElementPackage class.
        /// </summary>
        public DrawingElementPackage() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:dePkg");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingElementPackage>(deep);
    }

    /// <summary>
    /// <para>Defines the DeMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:deMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:deMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeMasterMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deMasterMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:deMasterMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeMasterMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeMasterMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMasterMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeMasterMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeMasterMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeMasterMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:deMasterMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeMasterMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeSrcMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deSrcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:deSrcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeSrcMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeSrcMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeSrcMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeSrcMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeSrcMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeSrcMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:deSrcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeSrcMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DeTgtMkLstDrawingElementMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:deTgtMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:deTgtMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DeTgtMkLstDrawingElementMonikerList : OpenXmlDrawingElementMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class.
        /// </summary>
        public DeTgtMkLstDrawingElementMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeTgtMkLstDrawingElementMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DeTgtMkLstDrawingElementMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DeTgtMkLstDrawingElementMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DeTgtMkLstDrawingElementMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:deTgtMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DeTgtMkLstDrawingElementMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlDrawingElementMonikerListElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlDrawingElementMonikerListElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class.
        /// </summary>
        protected OpenXmlDrawingElementMonikerListElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlDrawingElementMonikerListElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlDrawingElementMonikerListElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlDrawingElementMonikerListElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlDrawingElementMonikerListElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the ImgDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:imgData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImgDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the ImgDataImgData class.
        /// </summary>
        public ImgDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImgDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ImgDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:imgData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImgDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the OrigImgDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:origImgData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:origImgData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OrigImgDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the OrigImgDataImgData class.
        /// </summary>
        public OrigImgDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrigImgDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OrigImgDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:origImgData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrigImgDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the SndDataImgData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:sndData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:sndData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SndDataImgData : OpenXmlImgDataElement
    {
        /// <summary>
        /// Initializes a new instance of the SndDataImgData class.
        /// </summary>
        public SndDataImgData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SndDataImgData class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SndDataImgData(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:sndData");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SndDataImgData>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlImgDataElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlImgDataElement : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlImgDataElement class.
        /// </summary>
        protected OpenXmlImgDataElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlImgDataElement class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        protected OpenXmlImgDataElement(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Base64BinaryValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the ResourceUrl Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgUrl.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:imgUrl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResourceUrl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUrl class.
        /// </summary>
        public ResourceUrl() : base()
        {
        }

        /// <summary>
        /// <para>src, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Src
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>linkage, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: linkage</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("linkage")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.Command.ResourceLinkage>? Linkage
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.Command.ResourceLinkage>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:imgUrl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ResourceUrl>()
.AddAttribute("src", a => a.Src, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute("linkage", a => a.Linkage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResourceUrl>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyPackage Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txBodyPkg.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:txBodyPkg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyPackage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyPackage class.
        /// </summary>
        public TextBodyPackage() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:txBodyPkg");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyPackage>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupCommand Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpCmd.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeProperties" /> <c>&lt;oac:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualDrawingProps" /> <c>&lt;oac:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualGroupDrawingShapeProps" /> <c>&lt;oac:cNvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.ConnectorMoniker" /> <c>&lt;oac:cxnSpMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList" /> <c>&lt;oac:dgMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.GraphicFrameMoniker" /> <c>&lt;oac:graphicFrameMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeMoniker" /> <c>&lt;oac:grpSpMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.InkMoniker" /> <c>&lt;oac:inkMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.PictureMoniker" /> <c>&lt;oac:picMk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.ShapeMoniker" /> <c>&lt;oac:spMk></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:grpCmd")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupCommand : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupCommand class.
        /// </summary>
        public GroupCommand() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCommand(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCommand(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCommand class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupCommand(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>verId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: verId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("verId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? VerId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preventRegroup, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: preventRegroup</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("preventRegroup")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? PreventRegroup
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grpId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("grpId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? GrpId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:grpCmd");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualDrawingProps>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualGroupDrawingShapeProps>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.ConnectorMoniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.GraphicFrameMoniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeMoniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.InkMoniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.PictureMoniker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.ShapeMoniker>();
            builder.AddElement<GroupCommand>()
.AddAttribute("verId", a => a.VerId)
.AddAttribute("preventRegroup", a => a.PreventRegroup)
.AddAttribute("grpId", a => a.GrpId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0, version: FileFormatVersions.Office2016)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ShapeMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GraphicFrameMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ConnectorMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.PictureMoniker), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.InkMoniker), 1, 1, version: FileFormatVersions.Office2016)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GroupShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualDrawingProps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NonVisualGroupDrawingShapeProps), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>DrawingMonikerList.</para>
        /// <para>Represents the following element tag in the schema: oac:dgMkLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList? DrawingMonikerList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.DrawingMonikerList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the ImgLink Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:imgLink.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:imgLink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImgLink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImgLink class.
        /// </summary>
        public ImgLink() : base()
        {
        }

        /// <summary>
        /// <para>tgt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tgt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("tgt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Tgt
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:imgLink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ImgLink>()
.AddAttribute("tgt", a => a.Tgt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImgLink>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentContextMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:dcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DocumentContextMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class.
        /// </summary>
        public DocumentContextMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentContextMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentContextMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentContextMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentContextMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:dcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentContextMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicParentMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicParentMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:graphicParentMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicParentMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class.
        /// </summary>
        public GraphicParentMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicParentMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicParentMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicParentMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicParentMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:graphicParentMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicParentMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:spMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class.
        /// </summary>
        public ShapeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:spMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicFrameMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:graphicFrameMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:graphicFrameMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GraphicFrameMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class.
        /// </summary>
        public GraphicFrameMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrameMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:graphicFrameMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectorMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cxnSpMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cxnSpMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ConnectorMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class.
        /// </summary>
        public ConnectorMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectorMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectorMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectorMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cxnSpMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectorMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the PictureMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:picMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:picMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PictureMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class.
        /// </summary>
        public PictureMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PictureMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:picMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the InkMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:inkMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:inkMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InkMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InkMonikerList class.
        /// </summary>
        public InkMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InkMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:inkMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txBodyMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:txBodyMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class.
        /// </summary>
        public TextBodyMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:txBodyMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharRangeMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:txMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:txMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextCharRangeMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class.
        /// </summary>
        public TextCharRangeMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharRangeMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharRangeMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharRangeMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextCharRangeMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:txMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharRangeMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the HyperlinkMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlinkMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HyperlinkMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class.
        /// </summary>
        public HyperlinkMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HyperlinkMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlinkMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:model3DMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:model3DMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Model3DMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class.
        /// </summary>
        public Model3DMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:model3DMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ViewSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:viewSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:viewSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ViewSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class.
        /// </summary>
        public ViewSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ViewSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:viewSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ViewSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the EditorSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:editorSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:editorSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EditorSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class.
        /// </summary>
        public EditorSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EditorSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EditorSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditorSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EditorSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:editorSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditorSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the DrawingSelectionStgList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:drSelLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:drSelLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DrawingSelectionStgList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class.
        /// </summary>
        public DrawingSelectionStgList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingSelectionStgList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DrawingSelectionStgList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DrawingSelectionStgList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DrawingSelectionStgList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:drSelLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DrawingSelectionStgList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:tblMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:tblMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableMonikerList class.
        /// </summary>
        public TableMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:tblMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableCellMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:tcMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:tcMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableCellMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class.
        /// </summary>
        public TableCellMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableCellMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableCellMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableCellMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableCellMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:tcMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableCellMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableRowMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:trMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:trMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableRowMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class.
        /// </summary>
        public TableRowMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableRowMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableRowMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableRowMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableRowMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:trMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableRowMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the TableColumnMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:gridColMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:gridColMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TableColumnMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class.
        /// </summary>
        public TableColumnMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableColumnMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableColumnMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableColumnMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:gridColMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableColumnMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualDrawingProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualDrawingProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualDrawingProps class.
        /// </summary>
        public ModifyNonVisualDrawingProps() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descr, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("descr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Descr
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decor, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: decor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("decor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Decor
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scriptLink, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: scriptLink</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("scriptLink")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ScriptLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualDrawingProps>()
.AddAttribute("name", a => a.Name)
.AddAttribute("descr", a => a.Descr)
.AddAttribute("hidden", a => a.Hidden)
.AddAttribute("title", a => a.Title)
.AddAttribute("decor", a => a.Decor)
.AddAttribute("scriptLink", a => a.ScriptLink);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualDrawingProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyTransformProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyTransformProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyTransformProps class.
        /// </summary>
        public ModifyTransformProps() : base()
        {
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cy, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rot
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>flipH, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FlipH
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>flipV, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipV")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FlipV
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:xfrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyTransformProps>()
.AddAttribute("x", a => a.X, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("y", a => a.Y, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("cx", a => a.Cx, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("cy", a => a.Cy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("rot", a => a.Rot)
.AddAttribute("flipH", a => a.FlipH)
.AddAttribute("flipV", a => a.FlipV);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyTransformProps>(deep);
    }

    /// <summary>
    /// <para>Defines the Point2DType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:off.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:off")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Point2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Point2DType class.
        /// </summary>
        public Point2DType() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:off");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Point2DType>()
.AddAttribute("x", a => a.X, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("y", a => a.Y, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Point2DType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextParagraphPropertiesType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:pPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletColor" /> <c>&lt;a:buClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AutoNumberedBullet" /> <c>&lt;a:buAutoNum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PictureBullet" /> <c>&lt;a:buBlip></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletColorText" /> <c>&lt;a:buClrTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletSizeText" /> <c>&lt;a:buSzTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletSizePercentage" /> <c>&lt;a:buSzPct></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletSizePoints" /> <c>&lt;a:buSzPts></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletFontText" /> <c>&lt;a:buFontTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.DefaultRunProperties" /> <c>&lt;a:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CharacterBullet" /> <c>&lt;a:buChar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BulletFont" /> <c>&lt;a:buFont></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoBullet" /> <c>&lt;a:buNone></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineSpacing" /> <c>&lt;a:lnSpc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SpaceBefore" /> <c>&lt;a:spcBef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SpaceAfter" /> <c>&lt;a:spcAft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TabStopList" /> <c>&lt;a:tabLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:pPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextParagraphPropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class.
        /// </summary>
        public TextParagraphPropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextParagraphPropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextParagraphPropertiesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextParagraphPropertiesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextParagraphPropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Left Margin</para>
        /// <para>Represents the following attribute in the schema: marL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("marL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? LeftMargin
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Margin</para>
        /// <para>Represents the following attribute in the schema: marR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("marR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? RightMargin
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Level</para>
        /// <para>Represents the following attribute in the schema: lvl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lvl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Level
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Indent</para>
        /// <para>Represents the following attribute in the schema: indent</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("indent")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Indent
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("algn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues>? Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Tab Size</para>
        /// <para>Represents the following attribute in the schema: defTabSz</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("defTabSz")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? DefaultTabSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right To Left</para>
        /// <para>Represents the following attribute in the schema: rtl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rtl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RightToLeft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>East Asian Line Break</para>
        /// <para>Represents the following attribute in the schema: eaLnBrk</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("eaLnBrk")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? EastAsianLineBreak
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Font Alignment</para>
        /// <para>Represents the following attribute in the schema: fontAlgn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fontAlgn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues>? FontAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Latin Line Break</para>
        /// <para>Represents the following attribute in the schema: latinLnBrk</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("latinLnBrk")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? LatinLineBreak
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hanging Punctuation</para>
        /// <para>Represents the following attribute in the schema: hangingPunct</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hangingPunct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Height
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:pPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletColorText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizeText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizePercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletSizePoints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletFontText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DefaultRunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BulletFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TabStopList>();
            builder.AddElement<TextParagraphPropertiesType>()
.AddAttribute("marL", a => a.LeftMargin, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (51206400L) });
})
.AddAttribute("marR", a => a.RightMargin, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (51206400L) });
})
.AddAttribute("lvl", a => a.Level, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (8L) });
})
.AddAttribute("indent", a => a.Indent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-51206400L), MaxInclusive = (51206400L) });
})
.AddAttribute("algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("defTabSz", a => a.DefaultTabSize)
.AddAttribute("rtl", a => a.RightToLeft)
.AddAttribute("eaLnBrk", a => a.EastAsianLineBreak)
.AddAttribute("fontAlgn", a => a.FontAlignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("latinLnBrk", a => a.LatinLineBreak)
.AddAttribute("hangingPunct", a => a.Height);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SpaceBefore), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SpaceAfter), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletColorText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletColor), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizeText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizePercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletSizePoints), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletFontText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BulletFont), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CharacterBullet), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureBullet), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TabStopList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultRunProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Line Spacing.</para>
        /// <para>Represents the following element tag in the schema: a:lnSpc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineSpacing? LineSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Space Before.</para>
        /// <para>Represents the following element tag in the schema: a:spcBef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SpaceBefore? SpaceBefore
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SpaceBefore>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Space After.</para>
        /// <para>Represents the following element tag in the schema: a:spcAft.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SpaceAfter? SpaceAfter
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SpaceAfter>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextParagraphPropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bodyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FlatText" /> <c>&lt;a:flatTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetTextWrap" /> <c>&lt;a:prstTxWarp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoAutoFit" /> <c>&lt;a:noAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NormalAutoFit" /> <c>&lt;a:normAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeAutoFit" /> <c>&lt;a:spAutoFit></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:bodyPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBodyProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class.
        /// </summary>
        public TextBodyProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Paragraph Spacing</para>
        /// <para>Represents the following attribute in the schema: spcFirstLastPara</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("spcFirstLastPara")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UseParagraphSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Vertical Overflow</para>
        /// <para>Represents the following attribute in the schema: vertOverflow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("vertOverflow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>? VerticalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Horizontal Overflow</para>
        /// <para>Represents the following attribute in the schema: horzOverflow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("horzOverflow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>? HorizontalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Text</para>
        /// <para>Represents the following attribute in the schema: vert</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("vert")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>? Vertical
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Wrapping Type</para>
        /// <para>Represents the following attribute in the schema: wrap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>? Wrap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Left Inset</para>
        /// <para>Represents the following attribute in the schema: lIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? LeftInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top Inset</para>
        /// <para>Represents the following attribute in the schema: tIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("tIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? TopInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Inset</para>
        /// <para>Represents the following attribute in the schema: rIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? RightInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Inset</para>
        /// <para>Represents the following attribute in the schema: bIns</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bIns")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BottomInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Number of Columns</para>
        /// <para>Represents the following attribute in the schema: numCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("numCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ColumnCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Space Between Columns</para>
        /// <para>Represents the following attribute in the schema: spcCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("spcCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ColumnSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Columns Right-To-Left</para>
        /// <para>Represents the following attribute in the schema: rtlCol</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rtlCol")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RightToLeftColumns
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>From WordArt</para>
        /// <para>Represents the following attribute in the schema: fromWordArt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fromWordArt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? FromWordArt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor</para>
        /// <para>Represents the following attribute in the schema: anchor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("anchor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>? Anchor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor Center</para>
        /// <para>Represents the following attribute in the schema: anchorCtr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("anchorCtr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? AnchorCenter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Anti-Alias</para>
        /// <para>Represents the following attribute in the schema: forceAA</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("forceAA")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? ForceAntiAlias
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Upright</para>
        /// <para>Represents the following attribute in the schema: upright</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("upright")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UpRight
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compatible Line Spacing</para>
        /// <para>Represents the following attribute in the schema: compatLnSpc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("compatLnSpc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? CompatibleLineSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:bodyPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
            builder.AddElement<TextBodyProperties>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("spcFirstLastPara", a => a.UseParagraphSpacing)
.AddAttribute("vertOverflow", a => a.VerticalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("horzOverflow", a => a.HorizontalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("vert", a => a.Vertical, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("wrap", a => a.Wrap, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("lIns", a => a.LeftInset)
.AddAttribute("tIns", a => a.TopInset)
.AddAttribute("rIns", a => a.RightInset)
.AddAttribute("bIns", a => a.BottomInset)
.AddAttribute("numCol", a => a.ColumnCount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (16L) });
})
.AddAttribute("spcCol", a => a.ColumnSpacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
})
.AddAttribute("rtlCol", a => a.RightToLeftColumns)
.AddAttribute("fromWordArt", a => a.FromWordArt)
.AddAttribute("anchor", a => a.Anchor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("anchorCtr", a => a.AnchorCenter)
.AddAttribute("forceAA", a => a.ForceAntiAlias)
.AddAttribute("upright", a => a.UpRight)
.AddAttribute("compatLnSpc", a => a.CompatibleLineSpacing);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Preset Text Shape.</para>
        /// <para>Represents the following element tag in the schema: a:prstTxWarp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetTextWrap? PresetTextWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvSpPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualDrawingShapeProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualDrawingShapeProps class.
        /// </summary>
        public ModifyNonVisualDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noTextEdit, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noTextEdit</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noTextEdit")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoTextEdit
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>txBox, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("txBox")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? TxBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualDrawingShapeProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noRot", a => a.NoRot)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize)
.AddAttribute("noEditPoints", a => a.NoEditPoints)
.AddAttribute("noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute("noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute("noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute("noTextEdit", a => a.NoTextEdit)
.AddAttribute("txBox", a => a.TxBox);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapePropsMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:spMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapePropsMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class.
        /// </summary>
        public ShapePropsMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapePropsMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapePropsMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapePropsMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapePropsMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:spMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapePropsMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the XfrmEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:xfrm.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class XfrmEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the XfrmEmpty class.
        /// </summary>
        public XfrmEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:xfrm");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XfrmEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the GeomEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:geom.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:geom")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GeomEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the GeomEmpty class.
        /// </summary>
        public GeomEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:geom");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GeomEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the FillEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fill.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:fill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the FillEmpty class.
        /// </summary>
        public FillEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:fill");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:ln.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:ln")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LnEmpty class.
        /// </summary>
        public LnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:ln");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:effect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:effect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the EffectEmpty class.
        /// </summary>
        public EffectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:effect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the Scene3dEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:scene3d.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:scene3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Scene3dEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the Scene3dEmpty class.
        /// </summary>
        public Scene3dEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:scene3d");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3dEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the Sp3dEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:sp3d.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:sp3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Sp3dEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the Sp3dEmpty class.
        /// </summary>
        public Sp3dEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:sp3d");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sp3dEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtLstEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:extLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExtLstEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtLstEmpty class.
        /// </summary>
        public ExtLstEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:extLst");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtLstEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the BwModeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bwMode.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BwModeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the BwModeEmpty class.
        /// </summary>
        public BwModeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:bwMode");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BwModeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the SrcRectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:srcRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:srcRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SrcRectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the SrcRectEmpty class.
        /// </summary>
        public SrcRectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:srcRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SrcRectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the FillModeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillMode.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:fillMode")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillModeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the FillModeEmpty class.
        /// </summary>
        public FillModeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:fillMode");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillModeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the DpiEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:dpi.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:dpi")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DpiEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the DpiEmpty class.
        /// </summary>
        public DpiEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:dpi");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DpiEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the RotWithShapeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:rotWithShape.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:rotWithShape")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RotWithShapeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the RotWithShapeEmpty class.
        /// </summary>
        public RotWithShapeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:rotWithShape");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotWithShapeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the StCxnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:stCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:stCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StCxnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the StCxnEmpty class.
        /// </summary>
        public StCxnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:stCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StCxnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EndCxnEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:endCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:endCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EndCxnEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the EndCxnEmpty class.
        /// </summary>
        public EndCxnEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:endCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndCxnEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoGrpEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noGrp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoGrpEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoGrpEmpty class.
        /// </summary>
        public NoGrpEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noGrp");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoGrpEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoSelectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noSelect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoSelectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoSelectEmpty class.
        /// </summary>
        public NoSelectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noSelect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoSelectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoRotEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noRot.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noRot")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoRotEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoRotEmpty class.
        /// </summary>
        public NoRotEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noRot");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoRotEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeAspectEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeAspect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeAspectEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeAspectEmpty class.
        /// </summary>
        public NoChangeAspectEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noChangeAspect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeAspectEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoMoveEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noMove.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noMove")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoMoveEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoMoveEmpty class.
        /// </summary>
        public NoMoveEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noMove");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoMoveEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoResizeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noResize.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noResize")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoResizeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoResizeEmpty class.
        /// </summary>
        public NoResizeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noResize");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoResizeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoEditPointsEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noEditPoints.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoEditPointsEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoEditPointsEmpty class.
        /// </summary>
        public NoEditPointsEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noEditPoints");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoEditPointsEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoAdjustHandlesEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noAdjustHandles.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoAdjustHandlesEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoAdjustHandlesEmpty class.
        /// </summary>
        public NoAdjustHandlesEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noAdjustHandles");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoAdjustHandlesEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeArrowheadsEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeArrowheads.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeArrowheadsEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeArrowheadsEmpty class.
        /// </summary>
        public NoChangeArrowheadsEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noChangeArrowheads");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeArrowheadsEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the NoChangeShapeTypeEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:noChangeShapeType.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoChangeShapeTypeEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the NoChangeShapeTypeEmpty class.
        /// </summary>
        public NoChangeShapeTypeEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:noChangeShapeType");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoChangeShapeTypeEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the LfPrEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lfPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:lfPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LfPrEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the LfPrEmpty class.
        /// </summary>
        public LfPrEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:lfPr");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LfPrEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkClickEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkClick.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlinkClick")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkClickEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkClickEmpty class.
        /// </summary>
        public HlinkClickEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlinkClick");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkClickEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkHoverEmpty Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkHover.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlinkHover")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkHoverEmpty : OpenXmlEmptyElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkHoverEmpty class.
        /// </summary>
        public HlinkHoverEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlinkHover");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkHoverEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlEmptyElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlEmptyElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlEmptyElement class.
        /// </summary>
        protected OpenXmlEmptyElement() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the ResetShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty" /> <c>&lt;oac:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty" /> <c>&lt;oac:geom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty" /> <c>&lt;oac:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty" /> <c>&lt;oac:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty" /> <c>&lt;oac:effect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty" /> <c>&lt;oac:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty" /> <c>&lt;oac:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty" /> <c>&lt;oac:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty" /> <c>&lt;oac:bwMode></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class.
        /// </summary>
        public ResetShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>XfrmEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty? XfrmEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GeomEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:geom.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty? GeomEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.GeomEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty? FillEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty? LnEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.LnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:effect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty? EffectEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scene3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty? Scene3dEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sp3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty? Sp3dEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.Sp3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtLstEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty? ExtLstEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BwModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:bwMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty? BwModeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LnRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lnRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:lnRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LnRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class.
        /// </summary>
        public LnRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LnRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LnRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LnRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LnRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:lnRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LnRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FillRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:fillRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class.
        /// </summary>
        public FillRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FillRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:fillRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectRefStyleMatrixReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:effectRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:effectRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectRefStyleMatrixReference : StyleMatrixReferenceType
    {
        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class.
        /// </summary>
        public EffectRefStyleMatrixReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectRefStyleMatrixReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectRefStyleMatrixReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectRefStyleMatrixReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EffectRefStyleMatrixReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:effectRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectRefStyleMatrixReference>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleMatrixReferenceType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StyleMatrixReferenceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class.
        /// </summary>
        protected StyleMatrixReferenceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleMatrixReferenceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleMatrixReferenceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleMatrixReferenceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StyleMatrixReferenceType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Style Matrix Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddElement<StyleMatrixReferenceType>()
.AddAttribute("idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the FontReference Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fontRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:fontRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FontReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FontReference class.
        /// </summary>
        public FontReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FontReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Identifier</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>? Index
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:fontRef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddElement<FontReference>()
.AddAttribute("idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FontReference>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyShapeStyleProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference" /> <c>&lt;oac:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference" /> <c>&lt;oac:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference" /> <c>&lt;oac:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference" /> <c>&lt;oac:effectRef></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:style")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyShapeStyleProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class.
        /// </summary>
        public ModifyShapeStyleProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyShapeStyleProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyShapeStyleProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyShapeStyleProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyShapeStyleProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:style");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>LnRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference? LnRefStyleMatrixReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.LnRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference? FillRefStyleMatrixReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectRefStyleMatrixReference.</para>
        /// <para>Represents the following element tag in the schema: oac:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference? EffectRefStyleMatrixReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectRefStyleMatrixReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FontReference.</para>
        /// <para>Represents the following element tag in the schema: oac:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyShapeStyleProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetXsdboolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:reset.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:reset")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetXsdboolean : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetXsdboolean class.
        /// </summary>
        public ResetXsdboolean() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetXsdboolean class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ResetXsdboolean(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("oac:reset");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetXsdboolean>(deep);
    }

    /// <summary>
    /// <para>Defines the UseBoundsXsdboolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:useBounds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:useBounds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UseBoundsXsdboolean : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the UseBoundsXsdboolean class.
        /// </summary>
        public UseBoundsXsdboolean() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UseBoundsXsdboolean class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public UseBoundsXsdboolean(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("oac:useBounds");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseBoundsXsdboolean>(deep);
    }

    /// <summary>
    /// <para>Defines the BlipFillProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blip" /> <c>&lt;a:blip></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SourceRectangle" /> <c>&lt;a:srcRect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Stretch" /> <c>&lt;a:stretch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Tile" /> <c>&lt;a:tile></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:blipFill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BlipFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class.
        /// </summary>
        public BlipFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFillProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFillProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFillProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DPI Setting</para>
        /// <para>Represents the following attribute in the schema: dpi</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("dpi")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Dpi
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rotWithShape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:blipFill");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddElement<BlipFillProperties>()
.AddAttribute("dpi", a => a.Dpi)
.AddAttribute("rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip? Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle? SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the FillRectRelativeRectProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:fillRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:fillRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillRectRelativeRectProps : OpenXmlRelativeRectPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the FillRectRelativeRectProps class.
        /// </summary>
        public FillRectRelativeRectProps() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:fillRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillRectRelativeRectProps>(deep);
    }

    /// <summary>
    /// <para>Defines the SrcRectRelativeRectProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:srcRect.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:srcRect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SrcRectRelativeRectProps : OpenXmlRelativeRectPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the SrcRectRelativeRectProps class.
        /// </summary>
        public SrcRectRelativeRectProps() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:srcRect");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SrcRectRelativeRectProps>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlRelativeRectPropsElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlRelativeRectPropsElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlRelativeRectPropsElement class.
        /// </summary>
        protected OpenXmlRelativeRectPropsElement() : base()
        {
        }

        /// <summary>
        /// <para>l, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? L
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? T
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? R
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? B
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlRelativeRectPropsElement>()
                           .AddAttribute("l", a => a.L)
                           .AddAttribute("t", a => a.T)
                           .AddAttribute("r", a => a.R)
                           .AddAttribute("b", a => a.B);
        }
    }

    /// <summary>
    /// <para>Defines the ResetBlipFillProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty" /> <c>&lt;oac:srcRect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty" /> <c>&lt;oac:fillMode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty" /> <c>&lt;oac:dpi></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty" /> <c>&lt;oac:rotWithShape></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:blipFill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetBlipFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class.
        /// </summary>
        public ResetBlipFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetBlipFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetBlipFillProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetBlipFillProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetBlipFillProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:blipFill");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>SrcRectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty? SrcRectEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.SrcRectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fillMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty? FillModeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillModeEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DpiEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:dpi.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty? DpiEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.DpiEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RotWithShapeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:rotWithShape.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty? RotWithShapeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.RotWithShapeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetBlipFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualGroupDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGrpSpPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvGrpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualGroupDrawingShapeProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualGroupDrawingShapeProps class.
        /// </summary>
        public ModifyNonVisualGroupDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noUngrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noUngrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noUngrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoUngrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualGroupDrawingShapeProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noUngrp", a => a.NoUngrp)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noRot", a => a.NoRot)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualGroupDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TransformGroup" /> <c>&lt;a:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:grpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:grpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<GroupShapeProperties>()
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup? TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetGroupShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty" /> <c>&lt;oac:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty" /> <c>&lt;oac:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty" /> <c>&lt;oac:effect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty" /> <c>&lt;oac:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty" /> <c>&lt;oac:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty" /> <c>&lt;oac:bwMode></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:grpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class.
        /// </summary>
        public ResetGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:grpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>XfrmEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty? XfrmEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.XfrmEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty? FillEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.FillEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:effect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty? EffectEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.EffectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scene3dEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty? Scene3dEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.Scene3dEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtLstEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty? ExtLstEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.ExtLstEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BwModeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:bwMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty? BwModeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.BwModeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NonVisualDrawingProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class.
        /// </summary>
        public NonVisualDrawingProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProps(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("descr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProps>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("descr", a => a.Description)
.AddAttribute("hidden", a => a.Hidden)
.AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProps>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupDrawingShapeProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupShapeLocks" /> <c>&lt;a:grpSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvGrpSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NonVisualGroupDrawingShapeProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class.
        /// </summary>
        public NonVisualGroupDrawingShapeProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupDrawingShapeProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupDrawingShapeProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualGraphicFrameProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvGraphicFramePr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvGraphicFramePr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualGraphicFrameProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualGraphicFrameProps class.
        /// </summary>
        public ModifyNonVisualGraphicFrameProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noDrilldown, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noDrilldown</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noDrilldown")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoDrilldown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvGraphicFramePr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualGraphicFrameProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noDrilldown", a => a.NoDrilldown)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualGraphicFrameProps>(deep);
    }

    /// <summary>
    /// <para>Defines the StCxnConnection Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:stCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:stCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StCxnConnection : ConnectionType
    {
        /// <summary>
        /// Initializes a new instance of the StCxnConnection class.
        /// </summary>
        public StCxnConnection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:stCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StCxnConnection>(deep);
    }

    /// <summary>
    /// <para>Defines the EndCxnConnection Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:endCxn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:endCxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EndCxnConnection : ConnectionType
    {
        /// <summary>
        /// Initializes a new instance of the EndCxnConnection class.
        /// </summary>
        public EndCxnConnection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:endCxn");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndCxnConnection>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectionType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class ConnectionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionType class.
        /// </summary>
        protected ConnectionType() : base()
        {
        }

        /// <summary>
        /// <para>Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ConnectionType>()
                           .AddAttribute("id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           })
                           .AddAttribute("idx", a => a.Index, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualConnectorProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection" /> <c>&lt;oac:stCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection" /> <c>&lt;oac:endCxn></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvCxnSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualConnectorProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class.
        /// </summary>
        public ModifyNonVisualConnectorProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyNonVisualConnectorProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyNonVisualConnectorProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualConnectorProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyNonVisualConnectorProps(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvCxnSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection>();
            builder.AddElement<ModifyNonVisualConnectorProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noRot", a => a.NoRot)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize)
.AddAttribute("noEditPoints", a => a.NoEditPoints)
.AddAttribute("noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute("noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute("noChangeShapeType", a => a.NoChangeShapeType);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StCxnConnection.</para>
        /// <para>Represents the following element tag in the schema: oac:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection? StCxnConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndCxnConnection.</para>
        /// <para>Represents the following element tag in the schema: oac:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection? EndCxnConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnConnection>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualConnectorProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetNonVisualConnectorProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty" /> <c>&lt;oac:stCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty" /> <c>&lt;oac:endCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty" /> <c>&lt;oac:noGrp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty" /> <c>&lt;oac:noSelect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty" /> <c>&lt;oac:noRot></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty" /> <c>&lt;oac:noChangeAspect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty" /> <c>&lt;oac:noMove></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty" /> <c>&lt;oac:noResize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty" /> <c>&lt;oac:noEditPoints></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty" /> <c>&lt;oac:noAdjustHandles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty" /> <c>&lt;oac:noChangeArrowheads></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty" /> <c>&lt;oac:noChangeShapeType></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvCxnSpPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetNonVisualConnectorProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class.
        /// </summary>
        public ResetNonVisualConnectorProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualConnectorProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualConnectorProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualConnectorProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetNonVisualConnectorProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvCxnSpPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StCxnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty? StCxnEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.StCxnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndCxnEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty? EndCxnEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.EndCxnEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoGrpEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noGrp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty? NoGrpEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoGrpEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoSelectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noSelect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty? NoSelectEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoSelectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoRotEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noRot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty? NoRotEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoRotEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeAspectEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeAspect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty? NoChangeAspectEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeAspectEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoMoveEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noMove.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty? NoMoveEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoMoveEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoResizeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noResize.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty? NoResizeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoResizeEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoEditPointsEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noEditPoints.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty? NoEditPointsEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoEditPointsEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoAdjustHandlesEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noAdjustHandles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty? NoAdjustHandlesEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoAdjustHandlesEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeArrowheadsEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeArrowheads.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty? NoChangeArrowheadsEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeArrowheadsEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NoChangeShapeTypeEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:noChangeShapeType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty? NoChangeShapeTypeEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.NoChangeShapeTypeEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetNonVisualConnectorProps>(deep);
    }

    /// <summary>
    /// <para>Defines the CompressPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:compressPicPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:compressPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CompressPictureProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CompressPictureProps class.
        /// </summary>
        public CompressPictureProps() : base()
        {
        }

        /// <summary>
        /// <para>removeCrop, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: removeCrop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("removeCrop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? RemoveCrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useLocalDpi, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: useLocalDpi</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("useLocalDpi")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UseLocalDpi
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cstate, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cstate</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cstate")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>? Cstate
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:compressPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CompressPictureProps>()
.AddAttribute("removeCrop", a => a.RemoveCrop)
.AddAttribute("useLocalDpi", a => a.UseLocalDpi)
.AddAttribute("cstate", a => a.Cstate, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompressPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPicPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualPictureProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualPictureProps class.
        /// </summary>
        public ModifyNonVisualPictureProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noCrop, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noCrop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noCrop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoCrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preferRelativeResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("preferRelativeResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualPictureProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noRot", a => a.NoRot)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize)
.AddAttribute("noEditPoints", a => a.NoEditPoints)
.AddAttribute("noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute("noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute("noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute("noCrop", a => a.NoCrop)
.AddAttribute("preferRelativeResize", a => a.PreferRelativeResize);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetNonVisualPictureProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty" /> <c>&lt;oac:lfPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvPicPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetNonVisualPictureProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class.
        /// </summary>
        public ResetNonVisualPictureProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualPictureProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetNonVisualPictureProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetNonVisualPictureProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetNonVisualPictureProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvPicPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>LfPrEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:lfPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty? LfPrEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.LfPrEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetNonVisualPictureProps>(deep);
    }

    /// <summary>
    /// <para>Defines the BoundRect Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:bounds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:bounds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BoundRect : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BoundRect class.
        /// </summary>
        public BoundRect() : base()
        {
        }

        /// <summary>
        /// <para>l</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? L
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? T
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? R
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? B
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:bounds");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<BoundRect>()
.AddAttribute("l", a => a.L, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("t", a => a.T, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("b", a => a.B, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoundRect>(deep);
    }

    /// <summary>
    /// <para>Defines the SVGBlipMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:svgBlipMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:svgBlipMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SVGBlipMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class.
        /// </summary>
        public SVGBlipMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SVGBlipMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SVGBlipMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SVGBlipMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SVGBlipMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:svgBlipMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SVGBlipMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the LinePropertiesType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:lineProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomDash" /> <c>&lt;a:custDash></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HeadEnd" /> <c>&lt;a:headEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TailEnd" /> <c>&lt;a:tailEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineJoinBevel" /> <c>&lt;a:bevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Miter" /> <c>&lt;a:miter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Round" /> <c>&lt;a:round></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetDash" /> <c>&lt;a:prstDash></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:lineProps")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LinePropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class.
        /// </summary>
        public LinePropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinePropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinePropertiesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinePropertiesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LinePropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>line width</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("w")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Width
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>line cap</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>? CapType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compound line type</para>
        /// <para>Represents the following attribute in the schema: cmpd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cmpd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>? CompoundLineType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pen alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("algn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>? Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:lineProps");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Miter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Round>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<LinePropertiesType>()
.AddAttribute("w", a => a.Width, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (20116800L) });
})
.AddAttribute("cap", a => a.CapType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("cmpd", a => a.CompoundLineType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetDash), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomDash), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Round), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineJoinBevel), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Miter), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HeadEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TailEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinePropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the ModifyNonVisualInkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:cNvInkPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:cNvInkPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyNonVisualInkProps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyNonVisualInkProps class.
        /// </summary>
        public ModifyNonVisualInkProps() : base()
        {
        }

        /// <summary>
        /// <para>noGrp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrp
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noSelect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noRot, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeAspect, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noMove, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noResize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noEditPoints, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noAdjustHandles, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeArrowheads, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noChangeShapeType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isComment, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("isComment")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:cNvInkPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ModifyNonVisualInkProps>()
.AddAttribute("noGrp", a => a.NoGrp)
.AddAttribute("noSelect", a => a.NoSelect)
.AddAttribute("noRot", a => a.NoRot)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize)
.AddAttribute("noEditPoints", a => a.NoEditPoints)
.AddAttribute("noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute("noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute("noChangeShapeType", a => a.NoChangeShapeType)
.AddAttribute("isComment", a => a.IsComment);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyNonVisualInkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkClickHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkClick.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData" /> <c>&lt;oac:sndData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlinkClick")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkClickHyperlinkProps : OpenXmlHyperlinkPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class.
        /// </summary>
        public HlinkClickHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkClickHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkClickHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkClickHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HlinkClickHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlinkClick");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkClickHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the HlinkHoverHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlinkHover.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData" /> <c>&lt;oac:sndData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlinkHover")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HlinkHoverHyperlinkProps : OpenXmlHyperlinkPropsElement
    {
        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class.
        /// </summary>
        public HlinkHoverHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkHoverHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HlinkHoverHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HlinkHoverHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HlinkHoverHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlinkHover");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HlinkHoverHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlHyperlinkPropsElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData" /> <c>&lt;oac:sndData></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlHyperlinkPropsElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class.
        /// </summary>
        protected OpenXmlHyperlinkPropsElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlHyperlinkPropsElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlHyperlinkPropsElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlHyperlinkPropsElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlHyperlinkPropsElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>source, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: source</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("source")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>action, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("action")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Action
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tgtFrame, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tgtFrame</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("tgtFrame")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TgtFrame
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tooltip, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tooltip</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("tooltip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Tooltip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>highlightClick, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: highlightClick</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("highlightClick")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HighlightClick
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endSnd, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: endSnd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endSnd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? EndSnd
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sndName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sndName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("sndName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? SndName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData>();
            builder.AddElement<OpenXmlHyperlinkPropsElement>()
.AddAttribute("source", a => a.Source)
.AddAttribute("action", a => a.Action)
.AddAttribute("tgtFrame", a => a.TgtFrame)
.AddAttribute("tooltip", a => a.Tooltip)
.AddAttribute("highlightClick", a => a.HighlightClick)
.AddAttribute("endSnd", a => a.EndSnd)
.AddAttribute("sndName", a => a.SndName);
        }

        /// <summary>
        /// <para>SndDataImgData.</para>
        /// <para>Represents the following element tag in the schema: oac:sndData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData? SndDataImgData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.SndDataImgData>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the ModifyHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps" /> <c>&lt;oac:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps" /> <c>&lt;oac:hlinkHover></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModifyHyperlinkProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class.
        /// </summary>
        public ModifyHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModifyHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModifyHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModifyHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>HlinkClickHyperlinkProps.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps? HlinkClickHyperlinkProps
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickHyperlinkProps>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HlinkHoverHyperlinkProps.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps? HlinkHoverHyperlinkProps
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverHyperlinkProps>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModifyHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the ResetHyperlinkProps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:hlink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty" /> <c>&lt;oac:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty" /> <c>&lt;oac:hlinkHover></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:hlink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResetHyperlinkProps : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class.
        /// </summary>
        public ResetHyperlinkProps() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetHyperlinkProps(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ResetHyperlinkProps(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResetHyperlinkProps class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ResetHyperlinkProps(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:hlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>HlinkClickEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty? HlinkClickEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkClickEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HlinkHoverEmpty.</para>
        /// <para>Represents the following element tag in the schema: oac:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:oac = http://schemas.microsoft.com/office/drawing/2013/main/command
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty? HlinkHoverEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.Command.HlinkHoverEmpty>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResetHyperlinkProps>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharRangeContext Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is oac:context.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("oac:context")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextCharRangeContext : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharRangeContext class.
        /// </summary>
        public TextCharRangeContext() : base()
        {
        }

        /// <summary>
        /// <para>len, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: len</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("len")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Len
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hash, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hash</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Hash
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("oac:context");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<TextCharRangeContext>()
.AddAttribute("len", a => a.Len)
.AddAttribute("hash", a => a.Hash, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharRangeContext>(deep);
    }

    /// <summary>
    /// Defines the ResourceLinkage enumeration.
    /// </summary>
    public enum ResourceLinkage
    {
        /// <summary>
        /// embed.
        /// <para>When the item is serialized out as xml, its value is "embed".</para>
        /// </summary>
        [EnumString("embed")]
        Embed,
        /// <summary>
        /// link.
        /// <para>When the item is serialized out as xml, its value is "link".</para>
        /// </summary>
        [EnumString("link")]
        Link,
        /// <summary>
        /// linkAndEmbed.
        /// <para>When the item is serialized out as xml, its value is "linkAndEmbed".</para>
        /// </summary>
        [EnumString("linkAndEmbed")]
        LinkAndEmbed
    }

    /// <summary>
    /// Defines the DetachConnection enumeration.
    /// </summary>
    public enum DetachConnection
    {
        /// <summary>
        /// start.
        /// <para>When the item is serialized out as xml, its value is "start".</para>
        /// </summary>
        [EnumString("start")]
        Start,
        /// <summary>
        /// end.
        /// <para>When the item is serialized out as xml, its value is "end".</para>
        /// </summary>
        [EnumString("end")]
        End,
        /// <summary>
        /// both.
        /// <para>When the item is serialized out as xml, its value is "both".</para>
        /// </summary>
        [EnumString("both")]
        Both
    }
}