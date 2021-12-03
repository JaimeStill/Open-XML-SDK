﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Presentation;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml
{
    /// <summary>
    /// <para>Defines the Path Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:path.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:path")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Path : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Path class.
        /// </summary>
        public Path() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Path Definition</para>
        /// <para>Represents the following attribute in the schema: v</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("v")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Limo Stretch Point</para>
        /// <para>Represents the following attribute in the schema: limo</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("limo")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Limo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Bounding Box</para>
        /// <para>Represents the following attribute in the schema: textboxrect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("textboxrect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TextboxRectangle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: fillok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowFill
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: strokeok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowStroke
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Toggle</para>
        /// <para>Represents the following attribute in the schema: shadowok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("shadowok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowShading
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Arrowhead Display Toggle</para>
        /// <para>Represents the following attribute in the schema: arrowok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("arrowok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ShowArrowhead
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Shape Toggle</para>
        /// <para>Represents the following attribute in the schema: gradientshapeok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gradientshapeok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowGradientShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Toggle</para>
        /// <para>Represents the following attribute in the schema: textpathok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("textpathok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowTextPath
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Stroke From Path Flag</para>
        /// <para>Represents the following attribute in the schema: insetpenok</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpenok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Point Type</para>
        /// <para>Represents the following attribute in the schema: o:connecttype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connecttype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>? ConnectionPointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Points</para>
        /// <para>Represents the following attribute in the schema: o:connectlocs</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectlocs")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ConnectionPoints
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Point Connect Angles</para>
        /// <para>Represents the following attribute in the schema: o:connectangles</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectangles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ConnectAngles
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Toggle</para>
        /// <para>Represents the following attribute in the schema: o:extrusionok</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:extrusionok")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowExtrusion
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:path");
            builder.AddElement<Path>()
.AddAttribute("id", a => a.Id)
.AddAttribute("v", a => a.Value)
.AddAttribute("limo", a => a.Limo)
.AddAttribute("textboxrect", a => a.TextboxRectangle)
.AddAttribute("fillok", a => a.AllowFill)
.AddAttribute("strokeok", a => a.AllowStroke)
.AddAttribute("shadowok", a => a.AllowShading)
.AddAttribute("arrowok", a => a.ShowArrowhead)
.AddAttribute("gradientshapeok", a => a.AllowGradientShape)
.AddAttribute("textpathok", a => a.AllowTextPath)
.AddAttribute("insetpenok", a => a.AllowInsetPen)
.AddAttribute("o:connecttype", a => a.ConnectionPointType)
.AddAttribute("o:connectlocs", a => a.ConnectionPoints)
.AddAttribute("o:connectangles", a => a.ConnectAngles)
.AddAttribute("o:extrusionok", a => a.AllowExtrusion);
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Path>(deep);
    }

    /// <summary>
    /// <para>Defines the Formulas Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:formulas.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formula" /> <c>&lt;v:f></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:formulas")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Formulas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Formulas class.
        /// </summary>
        public Formulas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Formulas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Formulas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Formulas(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:formulas");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formula>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formula), 0, 128)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formulas>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeHandles Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:handles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandle" /> <c>&lt;v:h></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:handles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeHandles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeHandles class.
        /// </summary>
        public ShapeHandles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeHandles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeHandles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeHandles(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:handles");
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandle>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandle), 0, 4)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandles>(deep);
    }

    /// <summary>
    /// <para>Defines the Fill Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:fill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties" /> <c>&lt;o:fill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:fill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Fill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Fill class.
        /// </summary>
        public Fill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Fill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Color Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("opacity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Source</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: o:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Image Reference Location</para>
        /// <para>Represents the following attribute in the schema: o:althref</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:althref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? AlternateImageReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("size")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Size
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("origin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Origin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Position</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("position")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Position
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Aspect Ratio</para>
        /// <para>Represents the following attribute in the schema: aspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("aspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>? Aspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Intermediate Colors</para>
        /// <para>Represents the following attribute in the schema: colors</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("colors")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Colors
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Angle</para>
        /// <para>Represents the following attribute in the schema: angle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("angle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DecimalValue? Angle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Align Image With Shape</para>
        /// <para>Represents the following attribute in the schema: alignshape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alignshape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AlignShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Center</para>
        /// <para>Represents the following attribute in the schema: focus</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("focus")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Focus
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radial Gradient Size</para>
        /// <para>Represents the following attribute in the schema: focussize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("focussize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FocusSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radial Gradient Center</para>
        /// <para>Represents the following attribute in the schema: focusposition</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("focusposition")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FocusPosition
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Fill Method</para>
        /// <para>Represents the following attribute in the schema: method</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("method")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>? Method
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Detect Mouse Click</para>
        /// <para>Represents the following attribute in the schema: o:detectmouseclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:detectmouseclick")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DetectMouseClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Color Opacity</para>
        /// <para>Represents the following attribute in the schema: o:opacity2</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:opacity2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Opacity2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Recolor Fill as Picture</para>
        /// <para>Represents the following attribute in the schema: recolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("recolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Recolor
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate Fill with Shape</para>
        /// <para>Represents the following attribute in the schema: rotate</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rotate")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Rotate
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Part</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:fill");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
            builder.AddElement<Fill>()
.AddAttribute("id", a => a.Id)
.AddAttribute("type", a => a.Type)
.AddAttribute("on", a => a.On)
.AddAttribute("color", a => a.Color)
.AddAttribute("opacity", a => a.Opacity)
.AddAttribute("color2", a => a.Color2)
.AddAttribute("src", a => a.Source)
.AddAttribute("o:href", a => a.Href)
.AddAttribute("o:althref", a => a.AlternateImageReference)
.AddAttribute("size", a => a.Size)
.AddAttribute("origin", a => a.Origin)
.AddAttribute("position", a => a.Position)
.AddAttribute("aspect", a => a.Aspect)
.AddAttribute("colors", a => a.Colors)
.AddAttribute("angle", a => a.Angle)
.AddAttribute("alignshape", a => a.AlignShape)
.AddAttribute("focus", a => a.Focus)
.AddAttribute("focussize", a => a.FocusSize)
.AddAttribute("focusposition", a => a.FocusPosition)
.AddAttribute("method", a => a.Method)
.AddAttribute("o:detectmouseclick", a => a.DetectMouseClick)
.AddAttribute("o:title", a => a.Title)
.AddAttribute("o:opacity2", a => a.Opacity2)
.AddAttribute("recolor", a => a.Recolor)
.AddAttribute("rotate", a => a.Rotate)
.AddAttribute("r:id", a => a.RelationshipId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint("r:id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new AttributeValuePatternConstraint("v:focus", @"-?(\d{1,2}|100)%"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(":id", false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:angle", true, -32767, true, 32767, true));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:origin", true, -32767, true, 32767, true));
            builder.AddConstraint(new AttributeValueSetConstraint("v:title", false, new string[] { "slashes", "colons" }));
            builder.AddConstraint(new RelationshipExistConstraint("r:id"));
        }

        /// <summary>
        /// <para>FillExtendedProperties.</para>
        /// <para>Represents the following element tag in the schema: o:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties? FillExtendedProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fill>(deep);
    }

    /// <summary>
    /// <para>Defines the Stroke Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:stroke.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.LeftStroke" /> <c>&lt;o:left></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.TopStroke" /> <c>&lt;o:top></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.RightStroke" /> <c>&lt;o:right></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.BottomStroke" /> <c>&lt;o:bottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ColumnStroke" /> <c>&lt;o:column></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:stroke")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Stroke : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Stroke class.
        /// </summary>
        public Stroke() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Stroke(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Stroke(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Stroke(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: weight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("weight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Weight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("opacity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Line Style</para>
        /// <para>Represents the following attribute in the schema: linestyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("linestyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>? LineStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Miter Joint Limit</para>
        /// <para>Represents the following attribute in the schema: miterlimit</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("miterlimit")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Miterlimit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Join Style</para>
        /// <para>Represents the following attribute in the schema: joinstyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("joinstyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>? JoinStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Cap</para>
        /// <para>Represents the following attribute in the schema: endcap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endcap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>? EndCap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Dash Pattern</para>
        /// <para>Represents the following attribute in the schema: dashstyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("dashstyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DashStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Style</para>
        /// <para>Represents the following attribute in the schema: filltype</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filltype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>? FillType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Location</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Aspect Ratio</para>
        /// <para>Represents the following attribute in the schema: imageaspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("imageaspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>? ImageAspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Size</para>
        /// <para>Represents the following attribute in the schema: imagesize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("imagesize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ImageSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stoke Image Alignment</para>
        /// <para>Represents the following attribute in the schema: imagealignshape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("imagealignshape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ImageAlignShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Alternate Pattern Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead</para>
        /// <para>Represents the following attribute in the schema: startarrow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("startarrow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>? StartArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: startarrowwidth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("startarrowwidth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>? StartArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: startarrowlength</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("startarrowlength")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>? StartArrowLength
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead</para>
        /// <para>Represents the following attribute in the schema: endarrow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endarrow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>? EndArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: endarrowwidth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endarrowwidth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>? EndArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: endarrowlength</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endarrowlength")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>? EndArrowLength
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Original Image Reference</para>
        /// <para>Represents the following attribute in the schema: o:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Image Reference</para>
        /// <para>Represents the following attribute in the schema: o:althref</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:althref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? AlternateImageReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Insetpen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:stroke");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
            builder.AddElement<Stroke>()
.AddAttribute("id", a => a.Id)
.AddAttribute("on", a => a.On)
.AddAttribute("weight", a => a.Weight)
.AddAttribute("color", a => a.Color)
.AddAttribute("opacity", a => a.Opacity)
.AddAttribute("linestyle", a => a.LineStyle)
.AddAttribute("miterlimit", a => a.Miterlimit)
.AddAttribute("joinstyle", a => a.JoinStyle)
.AddAttribute("endcap", a => a.EndCap)
.AddAttribute("dashstyle", a => a.DashStyle)
.AddAttribute("filltype", a => a.FillType)
.AddAttribute("src", a => a.Source)
.AddAttribute("imageaspect", a => a.ImageAspect)
.AddAttribute("imagesize", a => a.ImageSize)
.AddAttribute("imagealignshape", a => a.ImageAlignShape)
.AddAttribute("color2", a => a.Color2)
.AddAttribute("startarrow", a => a.StartArrow)
.AddAttribute("startarrowwidth", a => a.StartArrowWidth)
.AddAttribute("startarrowlength", a => a.StartArrowLength)
.AddAttribute("endarrow", a => a.EndArrow)
.AddAttribute("endarrowwidth", a => a.EndArrowWidth)
.AddAttribute("endarrowlength", a => a.EndArrowLength)
.AddAttribute("o:href", a => a.Href)
.AddAttribute("o:althref", a => a.AlternateImageReference)
.AddAttribute("o:title", a => a.Title)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("r:id", a => a.RelationshipId)
.AddAttribute("insetpen", a => a.Insetpen);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.LeftStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.TopStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.RightStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.BottomStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ColumnStroke), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint("r:id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(":id", false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:miterlimit", true, double.NegativeInfinity, true, 32767, true));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:weight", true, 0, true, 20116800, true));
            builder.AddConstraint(new RelationshipExistConstraint("r:id"));
        }

        /// <summary>
        /// <para>LeftStroke.</para>
        /// <para>Represents the following element tag in the schema: o:left.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.LeftStroke? LeftStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TopStroke.</para>
        /// <para>Represents the following element tag in the schema: o:top.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.TopStroke? TopStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RightStroke.</para>
        /// <para>Represents the following element tag in the schema: o:right.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.RightStroke? RightStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BottomStroke.</para>
        /// <para>Represents the following element tag in the schema: o:bottom.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.BottomStroke? BottomStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnStroke.</para>
        /// <para>Represents the following element tag in the schema: o:column.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.ColumnStroke? ColumnStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Stroke>(deep);
    }

    /// <summary>
    /// <para>Defines the Shadow Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shadow.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:shadow")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shadow : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Shadow class.
        /// </summary>
        public Shadow() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Transparency</para>
        /// <para>Represents the following attribute in the schema: obscured</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("obscured")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Obscured
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Primary Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("opacity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Primary Offset</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("offset")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Secondary Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("color2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Secondary Offset</para>
        /// <para>Represents the following attribute in the schema: offset2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("offset2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Offset2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("origin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Origin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Perspective Matrix</para>
        /// <para>Represents the following attribute in the schema: matrix</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("matrix")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Matrix
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:shadow");
            builder.AddElement<Shadow>()
.AddAttribute("id", a => a.Id)
.AddAttribute("on", a => a.On)
.AddAttribute("type", a => a.Type)
.AddAttribute("obscured", a => a.Obscured)
.AddAttribute("color", a => a.Color)
.AddAttribute("opacity", a => a.Opacity)
.AddAttribute("offset", a => a.Offset)
.AddAttribute("color2", a => a.Color2)
.AddAttribute("offset2", a => a.Offset2)
.AddAttribute("origin", a => a.Origin)
.AddAttribute("matrix", a => a.Matrix);
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBox Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:textbox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.TextBoxContent" /> <c>&lt;w:txbxContent></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:textbox")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBox class.
        /// </summary>
        public TextBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Inset</para>
        /// <para>Represents the following attribute in the schema: inset</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("inset")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Inset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Single-Click Selection Toggle</para>
        /// <para>Represents the following attribute in the schema: o:singleclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:singleclick")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? SingleClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:textbox");
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
            builder.AddElement<TextBox>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("inset", a => a.Inset)
.AddAttribute("o:singleclick", a => a.SingleClick);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent), 0, 1),
                new AnyParticle(XsdAny.Local, 1, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBox>(deep);
    }

    /// <summary>
    /// <para>Defines the TextPath Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:textpath.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:textpath")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextPath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextPath class.
        /// </summary>
        public TextPath() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fit Toggle</para>
        /// <para>Represents the following attribute in the schema: fitshape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fitshape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? FitShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Path Fit Toggle</para>
        /// <para>Represents the following attribute in the schema: fitpath</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fitpath")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? FitPath
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Trim Toggle</para>
        /// <para>Represents the following attribute in the schema: trim</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trim")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Trim
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text X-Scaling</para>
        /// <para>Represents the following attribute in the schema: xscale</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("xscale")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? XScale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Text</para>
        /// <para>Represents the following attribute in the schema: string</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("string")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? String
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:textpath");
            builder.AddElement<TextPath>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("on", a => a.On)
.AddAttribute("fitshape", a => a.FitShape)
.AddAttribute("fitpath", a => a.FitPath)
.AddAttribute("trim", a => a.Trim)
.AddAttribute("xscale", a => a.XScale)
.AddAttribute("string", a => a.String);
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextPath>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:imagedata.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:imagedata")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImageData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageData class.
        /// </summary>
        public ImageData() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Transparency Color</para>
        /// <para>Represents the following attribute in the schema: chromakey</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("chromakey")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ChromAKey
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Left Crop</para>
        /// <para>Represents the following attribute in the schema: cropleft</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropleft")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropLeft
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Top Crop</para>
        /// <para>Represents the following attribute in the schema: croptop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("croptop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropTop
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Right Crop</para>
        /// <para>Represents the following attribute in the schema: cropright</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropright")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropRight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bottom Crop</para>
        /// <para>Represents the following attribute in the schema: cropbottom</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropbottom")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropBottom
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Intensity</para>
        /// <para>Represents the following attribute in the schema: gain</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gain")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Gain
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Brightness</para>
        /// <para>Represents the following attribute in the schema: blacklevel</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("blacklevel")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BlackLevel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Gamma Correction</para>
        /// <para>Represents the following attribute in the schema: gamma</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gamma")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Gamma
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Grayscale Toggle</para>
        /// <para>Represents the following attribute in the schema: grayscale</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("grayscale")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Grayscale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bilevel Toggle</para>
        /// <para>Represents the following attribute in the schema: bilevel</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bilevel")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? BiLevel
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embossed Color</para>
        /// <para>Represents the following attribute in the schema: embosscolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("embosscolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? EmbossColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black Recoloring Color</para>
        /// <para>Represents the following attribute in the schema: recolortarget</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("recolortarget")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RecolorTarget
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Data Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Detect Mouse Click</para>
        /// <para>Represents the following attribute in the schema: o:detectmouseclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:detectmouseclick")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DetectMouseClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Part</para>
        /// <para>Represents the following attribute in the schema: o:relid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:relid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Image Data</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Alternate Image Data</para>
        /// <para>Represents the following attribute in the schema: r:pict</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:pict")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Picture
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: r:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelHref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:imagedata");
            builder.AddElement<ImageData>()
.AddAttribute("id", a => a.Id)
.AddAttribute("chromakey", a => a.ChromAKey)
.AddAttribute("cropleft", a => a.CropLeft)
.AddAttribute("croptop", a => a.CropTop)
.AddAttribute("cropright", a => a.CropRight)
.AddAttribute("cropbottom", a => a.CropBottom)
.AddAttribute("gain", a => a.Gain)
.AddAttribute("blacklevel", a => a.BlackLevel)
.AddAttribute("gamma", a => a.Gamma)
.AddAttribute("grayscale", a => a.Grayscale)
.AddAttribute("bilevel", a => a.BiLevel)
.AddAttribute("embosscolor", a => a.EmbossColor)
.AddAttribute("recolortarget", a => a.RecolorTarget)
.AddAttribute("o:title", a => a.Title)
.AddAttribute("o:detectmouseclick", a => a.DetectMouseClick)
.AddAttribute("o:relid", a => a.RelId)
.AddAttribute("r:id", a => a.RelationshipId)
.AddAttribute("r:pict", a => a.Picture)
.AddAttribute("r:href", a => a.RelHref);
            builder.AddConstraint(new RelationshipTypeConstraint("v:href", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint("r:id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint("v:pict", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint("v:relid", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(":id", false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:blacklevel", true, -0.5, true, 0.5, true));
            builder.AddConstraint(new RelationshipExistConstraint("r:id"));
            builder.AddConstraint(new RelationshipExistConstraint("r:href"));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageData>(deep);
    }

    /// <summary>
    /// <para>Shape Definition.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shape.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Ink" /> <c>&lt;o:ink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag" /> <c>&lt;pvml:iscomment></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:shape")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Type Reference</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Adjustment Parameters</para>
        /// <para>Represents the following attribute in the schema: adj</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("adj")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Adjustment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Edge Path</para>
        /// <para>Represents the following attribute in the schema: path</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("path")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? EdgePath
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? EncodedPackage
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Storage for Alternate Math Content</para>
        /// <para>Represents the following attribute in the schema: equationxml</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("equationxml")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? EquationXml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:shape");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Ink>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Shape>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("type", a => a.Type)
.AddAttribute("adj", a => a.Adjustment)
.AddAttribute("path", a => a.EdgePath)
.AddAttribute("o:gfxdata", a => a.EncodedPackage)
.AddAttribute("equationxml", a => a.EquationXml);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Ink), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag), 1, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Shape Template.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shapetype.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Complex" /> <c>&lt;o:complex></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:shapetype")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shapetype : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shapetype class.
        /// </summary>
        public Shapetype() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shapetype(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shapetype(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shapetype(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Adjustment Parameters</para>
        /// <para>Represents the following attribute in the schema: adj</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("adj")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Adjustment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Edge Path</para>
        /// <para>Represents the following attribute in the schema: path</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("path")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? EdgePath
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Master Element Toggle</para>
        /// <para>Represents the following attribute in the schema: o:master</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:master")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Master
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:shapetype");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Complex>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Shapetype>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("adj", a => a.Adjustment)
.AddAttribute("path", a => a.EdgePath)
.AddAttribute("o:master", a => a.Master);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Complex), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shapetype>(deep);
    }

    /// <summary>
    /// <para>Shape Group.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Diagram" /> <c>&lt;o:diagram></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Arc" /> <c>&lt;v:arc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Curve" /> <c>&lt;v:curve></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Group" /> <c>&lt;v:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageFile" /> <c>&lt;v:image></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Line" /> <c>&lt;v:line></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Oval" /> <c>&lt;v:oval></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.PolyLine" /> <c>&lt;v:polyline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Rectangle" /> <c>&lt;v:rect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.RoundRectangle" /> <c>&lt;v:roundrect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shape" /> <c>&lt;v:shape></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shapetype" /> <c>&lt;v:shapetype></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:group")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Group : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Group(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spid</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>oned</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>regroupid</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>doubleclicknotify</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>button</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userhidden</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hr</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrstd</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrnoshade</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrpct</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hralign</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowincell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowoverlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userdrawn</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmlayout</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmnodekind</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmlayoutmru</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insetmode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Group Diagram Type</para>
        /// <para>Represents the following attribute in the schema: editas</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("editas")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>? EditAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Table Properties</para>
        /// <para>Represents the following attribute in the schema: o:tableproperties</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:tableproperties")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TableProperties
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Table Row Height Limits</para>
        /// <para>Represents the following attribute in the schema: o:tablelimits</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:tablelimits")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TableLimits
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:group");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Arc>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Curve>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Group>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageFile>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Line>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Oval>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.PolyLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Rectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shapetype>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Group>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("editas", a => a.EditAs)
.AddAttribute("o:tableproperties", a => a.TableProperties)
.AddAttribute("o:tablelimits", a => a.TableLimits);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Group), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shapetype), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Arc), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Curve), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageFile), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Line), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Oval), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.PolyLine), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Rectangle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.RoundRectangle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Diagram), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:tableproperties", true, new string[] { "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Document Background.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:background.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:background")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Background : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Background class.
        /// </summary>
        public Background() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Background(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: fill</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fill")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Fillcolor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Target Screen Size</para>
        /// <para>Represents the following attribute in the schema: o:targetscreensize</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:targetscreensize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>? TargetScreenSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:background");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddElement<Background>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MaxLength = (255L) });
})
.AddAttribute("fill", a => a.Filled)
.AddAttribute("fillcolor", a => a.Fillcolor)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:targetscreensize", a => a.TargetScreenSize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <summary>
        /// <para>Fill.</para>
        /// <para>Represents the following element tag in the schema: v:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Fill? Fill
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Fill>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);
    }

    /// <summary>
    /// <para>Arc Segment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:arc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:arc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Arc : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Arc class.
        /// </summary>
        public Arc() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Arc(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Wrapcoords
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Starting Angle</para>
        /// <para>Represents the following attribute in the schema: startangle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("startangle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DecimalValue? StartAngle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Ending Angle</para>
        /// <para>Represents the following attribute in the schema: endangle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endangle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DecimalValue? EndAngle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:arc");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Arc>()
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MaxLength = (255L) });
})
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.Wrapcoords)
.AddAttribute("print", a => a.Print)
.AddAttribute("startangle", a => a.StartAngle)
.AddAttribute("endangle", a => a.EndAngle);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueRangeConstraint("v:hrpct", true, 0, true, 1000, true));
            builder.AddConstraint(new AttributeValueRangeConstraint("ovml:dgmnodekind", true, 0, true, 6, true));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "19" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);
    }

    /// <summary>
    /// <para>Bezier Curve.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:curve.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:curve")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Curve : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Curve class.
        /// </summary>
        public Curve() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Curve(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Curve(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Curve(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Curve Starting Point</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("from")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>First Curve Control Point</para>
        /// <para>Represents the following attribute in the schema: control1</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("control1")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Control1
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Second Curve Control Point</para>
        /// <para>Represents the following attribute in the schema: control2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("control2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Control2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Curve Ending Point</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("to")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? To
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:curve");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Curve>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("from", a => a.From)
.AddAttribute("control1", a => a.Control1)
.AddAttribute("control2", a => a.Control2)
.AddAttribute("to", a => a.To);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "0" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Curve>(deep);
    }

    /// <summary>
    /// <para>Image File.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:image.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:image")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ImageFile : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageFile class.
        /// </summary>
        public ImageFile() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageFile(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageFile(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ImageFile(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>href</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>class</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
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
        /// <para>alt</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>coordsize</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>wrapcoords</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>print</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Source</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Left Crop</para>
        /// <para>Represents the following attribute in the schema: cropleft</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropleft")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropLeft
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Top Crop</para>
        /// <para>Represents the following attribute in the schema: croptop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("croptop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropTop
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Right Crop</para>
        /// <para>Represents the following attribute in the schema: cropright</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropright")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropRight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bottom Crop</para>
        /// <para>Represents the following attribute in the schema: cropbottom</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cropbottom")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CropBottom
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Intensity</para>
        /// <para>Represents the following attribute in the schema: gain</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gain")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Gain
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Brightness</para>
        /// <para>Represents the following attribute in the schema: blacklevel</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("blacklevel")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BlackLevel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Gamma Correction</para>
        /// <para>Represents the following attribute in the schema: gamma</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gamma")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Gamma
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Grayscale Toggle</para>
        /// <para>Represents the following attribute in the schema: grayscale</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("grayscale")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? GrayScale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bilevel Toggle</para>
        /// <para>Represents the following attribute in the schema: bilevel</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bilevel")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? BiLevel
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:image");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<ImageFile>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("src", a => a.Source)
.AddAttribute("cropleft", a => a.CropLeft)
.AddAttribute("croptop", a => a.CropTop)
.AddAttribute("cropright", a => a.CropRight)
.AddAttribute("cropbottom", a => a.CropBottom)
.AddAttribute("gain", a => a.Gain)
.AddAttribute("blacklevel", a => a.BlackLevel)
.AddAttribute("gamma", a => a.Gamma)
.AddAttribute("grayscale", a => a.GrayScale)
.AddAttribute("bilevel", a => a.BiLevel)
.AddAttribute("o:gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(":id", true, null));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "75" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageFile>(deep);
    }

    /// <summary>
    /// <para>Line.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:line.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:line")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Line : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Line class.
        /// </summary>
        public Line() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Line(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("from")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Point</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("to")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? To
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:line");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Line>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("from", a => a.From)
.AddAttribute("to", a => a.To);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "20" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line>(deep);
    }

    /// <summary>
    /// <para>Oval.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:oval.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:oval")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Oval : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Oval class.
        /// </summary>
        public Oval() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Oval(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Oval(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Oval(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:oval");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Oval>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "3" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Oval>(deep);
    }

    /// <summary>
    /// <para>Multiple Path Line.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:polyline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Ink" /> <c>&lt;o:ink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:polyline")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PolyLine : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PolyLine class.
        /// </summary>
        public PolyLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PolyLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PolyLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PolyLine(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Points for Compound Line</para>
        /// <para>Represents the following attribute in the schema: points</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("points")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Points
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:polyline");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Ink>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<PolyLine>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("points", a => a.Points);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Ink), 1, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "0" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolyLine>(deep);
    }

    /// <summary>
    /// <para>Rectangle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:rect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:rect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Rectangle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        public Rectangle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rectangle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rectangle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rectangle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
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
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:rect");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Rectangle>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("coordorigin", a => a.CoordinateOrigin)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "1" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rectangle>(deep);
    }

    /// <summary>
    /// <para>Rounded Rectangle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:roundrect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Callout" /> <c>&lt;o:callout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.ClipPath" /> <c>&lt;o:clippath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Extrusion" /> <c>&lt;o:extrusion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Lock" /> <c>&lt;o:lock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.SignatureLine" /> <c>&lt;o:signatureline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Office.Skew" /> <c>&lt;o:skew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Presentation.TextData" /> <c>&lt;pvml:textdata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Fill" /> <c>&lt;v:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Formulas" /> <c>&lt;v:formulas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ShapeHandles" /> <c>&lt;v:handles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.ImageData" /> <c>&lt;v:imagedata></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Path" /> <c>&lt;v:path></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Shadow" /> <c>&lt;v:shadow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Stroke" /> <c>&lt;v:stroke></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextBox" /> <c>&lt;v:textbox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.TextPath" /> <c>&lt;v:textpath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock" /> <c>&lt;w10:anchorlock></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder" /> <c>&lt;w10:bordertop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder" /> <c>&lt;w10:borderbottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder" /> <c>&lt;w10:borderleft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder" /> <c>&lt;w10:borderright></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap" /> <c>&lt;w10:wrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData" /> <c>&lt;xvml:ClientData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:roundrect")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RoundRectangle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RoundRectangle class.
        /// </summary>
        public RoundRectangle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoundRectangle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoundRectangle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RoundRectangle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>href</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("href")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("target")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>class</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("class")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
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
        /// <para>alt</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("alt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>coordsize</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coordsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>wrapcoords</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("wrapcoords")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>print</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("print")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oned")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:regroupid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:doubleclicknotify")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:button")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userhidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bullet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrstd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrnoshade")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hrpct")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue? HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:hralign")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>? HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:userdrawn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bordertopcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderleftcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderbottomcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:borderrightcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmnodekind")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:dgmlayoutmru")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>? InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("filled")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stroked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("strokeweight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:spt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:connectortype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>? ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwpure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:bwnormal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>? NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:oleicon")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:ole")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:preferrelative")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:cliptowrap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:clip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue? Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("o:gfxdata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue? Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rounded Corner Arc Size</para>
        /// <para>Represents the following attribute in the schema: arcsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("arcsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ArcSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:roundrect");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Formulas>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ShapeHandles>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Path>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<RoundRectangle>()
.AddAttribute("id", a => a.Id)
.AddAttribute("style", a => a.Style)
.AddAttribute("href", a => a.Href)
.AddAttribute("target", a => a.Target)
.AddAttribute("class", a => a.Class)
.AddAttribute("title", a => a.Title)
.AddAttribute("alt", a => a.Alternate)
.AddAttribute("coordsize", a => a.CoordinateSize)
.AddAttribute("wrapcoords", a => a.WrapCoordinates)
.AddAttribute("print", a => a.Print)
.AddAttribute("o:spid", a => a.OptionalString)
.AddAttribute("o:oned", a => a.Oned)
.AddAttribute("o:regroupid", a => a.RegroupId)
.AddAttribute("o:doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute("o:button", a => a.Button)
.AddAttribute("o:userhidden", a => a.UserHidden)
.AddAttribute("o:bullet", a => a.Bullet)
.AddAttribute("o:hr", a => a.Horizontal)
.AddAttribute("o:hrstd", a => a.HorizontalStandard)
.AddAttribute("o:hrnoshade", a => a.HorizontalNoShade)
.AddAttribute("o:hrpct", a => a.HorizontalPercentage)
.AddAttribute("o:hralign", a => a.HorizontalAlignment)
.AddAttribute("o:allowincell", a => a.AllowInCell)
.AddAttribute("o:allowoverlap", a => a.AllowOverlap)
.AddAttribute("o:userdrawn", a => a.UserDrawn)
.AddAttribute("o:bordertopcolor", a => a.BorderTopColor)
.AddAttribute("o:borderleftcolor", a => a.BorderLeftColor)
.AddAttribute("o:borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute("o:borderrightcolor", a => a.BorderRightColor)
.AddAttribute("o:dgmlayout", a => a.DiagramLayout)
.AddAttribute("o:dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute("o:dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute("o:insetmode", a => a.InsetMode)
.AddAttribute("filled", a => a.Filled)
.AddAttribute("fillcolor", a => a.FillColor)
.AddAttribute("stroked", a => a.Stroked)
.AddAttribute("strokecolor", a => a.StrokeColor)
.AddAttribute("strokeweight", a => a.StrokeWeight)
.AddAttribute("insetpen", a => a.InsetPen)
.AddAttribute("o:spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute("o:connectortype", a => a.ConnectorType)
.AddAttribute("o:bwmode", a => a.BlackWhiteMode)
.AddAttribute("o:bwpure", a => a.PureBlackWhiteMode)
.AddAttribute("o:bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute("o:forcedash", a => a.ForceDash)
.AddAttribute("o:oleicon", a => a.OleIcon)
.AddAttribute("o:ole", a => a.Ole)
.AddAttribute("o:preferrelative", a => a.PreferRelative)
.AddAttribute("o:cliptowrap", a => a.ClipToWrap)
.AddAttribute("o:clip", a => a.Clip)
.AddAttribute("o:gfxdata", a => a.Gfxdata)
.AddAttribute("arcsize", a => a.ArcSize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayout", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint("v:dgmlayoutmru", true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint("v:id", true, null));
            builder.AddConstraint(new AttributeValueSetConstraint("v:spt", true, new string[] { "2" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundRectangle>(deep);
    }

    /// <summary>
    /// <para>Shape Handle.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:h.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:h")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeHandle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeHandle class.
        /// </summary>
        public ShapeHandle() : base()
        {
        }

        /// <summary>
        /// <para>Handle Position</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("position")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Position
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Polar Center</para>
        /// <para>Represents the following attribute in the schema: polar</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("polar")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Polar
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Coordinate Mapping</para>
        /// <para>Represents the following attribute in the schema: map</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("map")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Map
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Invert Handle's X Position</para>
        /// <para>Represents the following attribute in the schema: invx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("invx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? InvertX
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Invert Handle's Y Position</para>
        /// <para>Represents the following attribute in the schema: invy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("invy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? InvertY
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Inversion Toggle</para>
        /// <para>Represents the following attribute in the schema: switch</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("switch")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue? Switch
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle X Position Range</para>
        /// <para>Represents the following attribute in the schema: xrange</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("xrange")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? XRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Y Position Range</para>
        /// <para>Represents the following attribute in the schema: yrange</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("yrange")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? YRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Polar Radius Range</para>
        /// <para>Represents the following attribute in the schema: radiusrange</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("radiusrange")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RadiusRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:h");
            builder.AddElement<ShapeHandle>()
  .AddAttribute("position", a => a.Position)
  .AddAttribute("polar", a => a.Polar)
  .AddAttribute("map", a => a.Map)
  .AddAttribute("invx", a => a.InvertX)
  .AddAttribute("invy", a => a.InvertY)
  .AddAttribute("switch", a => a.Switch)
  .AddAttribute("xrange", a => a.XRange)
  .AddAttribute("yrange", a => a.YRange)
  .AddAttribute("radiusrange", a => a.RadiusRange);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandle>(deep);
    }

    /// <summary>
    /// <para>Single Formula.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:f.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("v:f")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Formula : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// <para>Equation</para>
        /// <para>Represents the following attribute in the schema: eqn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("eqn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Equation
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("v:f");
            builder.AddElement<Formula>()
  .AddAttribute("eqn", a => a.Equation);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// VML Extension Handling Behaviors
    /// </summary>
    public enum ExtensionHandlingBehaviorValues
    {
        /// <summary>
        /// Not renderable.
        /// <para>When the item is serialized out as xml, its value is "view".</para>
        /// </summary>
        [EnumString("view")]
        View,
        /// <summary>
        /// Editable.
        /// <para>When the item is serialized out as xml, its value is "edit".</para>
        /// </summary>
        [EnumString("edit")]
        Edit,
        /// <summary>
        /// Renderable.
        /// <para>When the item is serialized out as xml, its value is "backwardCompatible".</para>
        /// </summary>
        [EnumString("backwardCompatible")]
        BackwardCompatible
    }

    /// <summary>
    /// Shape Fill Type
    /// </summary>
    public enum FillTypeValues
    {
        /// <summary>
        /// Solid Fill.
        /// <para>When the item is serialized out as xml, its value is "solid".</para>
        /// </summary>
        [EnumString("solid")]
        Solid,
        /// <summary>
        /// Linear Gradient.
        /// <para>When the item is serialized out as xml, its value is "gradient".</para>
        /// </summary>
        [EnumString("gradient")]
        Gradient,
        /// <summary>
        /// Radial Gradient.
        /// <para>When the item is serialized out as xml, its value is "gradientRadial".</para>
        /// </summary>
        [EnumString("gradientRadial")]
        GradientRadial,
        /// <summary>
        /// Tiled Image.
        /// <para>When the item is serialized out as xml, its value is "tile".</para>
        /// </summary>
        [EnumString("tile")]
        Tile,
        /// <summary>
        /// Image Pattern.
        /// <para>When the item is serialized out as xml, its value is "pattern".</para>
        /// </summary>
        [EnumString("pattern")]
        Pattern,
        /// <summary>
        /// Stretch Image to Fit.
        /// <para>When the item is serialized out as xml, its value is "frame".</para>
        /// </summary>
        [EnumString("frame")]
        Frame
    }

    /// <summary>
    /// Gradient Fill Computation Type
    /// </summary>
    public enum FillMethodValues
    {
        /// <summary>
        /// No Gradient Fill.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Linear Fill.
        /// <para>When the item is serialized out as xml, its value is "linear".</para>
        /// </summary>
        [EnumString("linear")]
        Linear,
        /// <summary>
        /// Sigma Fill.
        /// <para>When the item is serialized out as xml, its value is "sigma".</para>
        /// </summary>
        [EnumString("sigma")]
        Sigma,
        /// <summary>
        /// Application Default Fill.
        /// <para>When the item is serialized out as xml, its value is "any".</para>
        /// </summary>
        [EnumString("any")]
        Any,
        /// <summary>
        /// Linear Sigma Fill.
        /// <para>When the item is serialized out as xml, its value is "linear sigma".</para>
        /// </summary>
        [EnumString("linear sigma")]
        Linearsigma
    }

    /// <summary>
    /// Stroke Line Style
    /// </summary>
    public enum StrokeLineStyleValues
    {
        /// <summary>
        /// Single Line.
        /// <para>When the item is serialized out as xml, its value is "single".</para>
        /// </summary>
        [EnumString("single")]
        Single,
        /// <summary>
        /// Two Thin Lines.
        /// <para>When the item is serialized out as xml, its value is "thinThin".</para>
        /// </summary>
        [EnumString("thinThin")]
        ThinThin,
        /// <summary>
        /// Thin Line Outside Thick Line.
        /// <para>When the item is serialized out as xml, its value is "thinThick".</para>
        /// </summary>
        [EnumString("thinThick")]
        ThinThick,
        /// <summary>
        /// Thick Line Outside Thin Line.
        /// <para>When the item is serialized out as xml, its value is "thickThin".</para>
        /// </summary>
        [EnumString("thickThin")]
        ThickThin,
        /// <summary>
        /// Thck Line Between Thin Lines.
        /// <para>When the item is serialized out as xml, its value is "thickBetweenThin".</para>
        /// </summary>
        [EnumString("thickBetweenThin")]
        ThickBetweenThin
    }

    /// <summary>
    /// Line Join Type
    /// </summary>
    public enum StrokeJoinStyleValues
    {
        /// <summary>
        /// Round Joint.
        /// <para>When the item is serialized out as xml, its value is "round".</para>
        /// </summary>
        [EnumString("round")]
        Round,
        /// <summary>
        /// Bevel Joint.
        /// <para>When the item is serialized out as xml, its value is "bevel".</para>
        /// </summary>
        [EnumString("bevel")]
        Bevel,
        /// <summary>
        /// Miter Joint.
        /// <para>When the item is serialized out as xml, its value is "miter".</para>
        /// </summary>
        [EnumString("miter")]
        Miter
    }

    /// <summary>
    /// Stroke End Cap Type
    /// </summary>
    public enum StrokeEndCapValues
    {
        /// <summary>
        /// Flat End.
        /// <para>When the item is serialized out as xml, its value is "flat".</para>
        /// </summary>
        [EnumString("flat")]
        Flat,
        /// <summary>
        /// Square End.
        /// <para>When the item is serialized out as xml, its value is "square".</para>
        /// </summary>
        [EnumString("square")]
        Square,
        /// <summary>
        /// Round End.
        /// <para>When the item is serialized out as xml, its value is "round".</para>
        /// </summary>
        [EnumString("round")]
        Round
    }

    /// <summary>
    /// Stroke Arrowhead Length
    /// </summary>
    public enum StrokeArrowLengthValues
    {
        /// <summary>
        /// Short Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "short".</para>
        /// </summary>
        [EnumString("short")]
        Short,
        /// <summary>
        /// Medium Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "medium".</para>
        /// </summary>
        [EnumString("medium")]
        Medium,
        /// <summary>
        /// Long Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "long".</para>
        /// </summary>
        [EnumString("long")]
        Long
    }

    /// <summary>
    /// Stroke Arrowhead Width
    /// </summary>
    public enum StrokeArrowWidthValues
    {
        /// <summary>
        /// Narrow Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "narrow".</para>
        /// </summary>
        [EnumString("narrow")]
        Narrow,
        /// <summary>
        /// Medium Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "medium".</para>
        /// </summary>
        [EnumString("medium")]
        Medium,
        /// <summary>
        /// Wide Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "wide".</para>
        /// </summary>
        [EnumString("wide")]
        Wide
    }

    /// <summary>
    /// Stroke Arrowhead Type
    /// </summary>
    public enum StrokeArrowValues
    {
        /// <summary>
        /// No Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Block Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "block".</para>
        /// </summary>
        [EnumString("block")]
        Block,
        /// <summary>
        /// Classic Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "classic".</para>
        /// </summary>
        [EnumString("classic")]
        Classic,
        /// <summary>
        /// Oval Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "oval".</para>
        /// </summary>
        [EnumString("oval")]
        Oval,
        /// <summary>
        /// Diamond Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "diamond".</para>
        /// </summary>
        [EnumString("diamond")]
        Diamond,
        /// <summary>
        /// Open Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "open".</para>
        /// </summary>
        [EnumString("open")]
        Open
    }

    /// <summary>
    /// Image Scaling Behavior
    /// </summary>
    public enum ImageAspectValues
    {
        /// <summary>
        /// Ignore Aspect Ratio.
        /// <para>When the item is serialized out as xml, its value is "ignore".</para>
        /// </summary>
        [EnumString("ignore")]
        Ignore,
        /// <summary>
        /// At Most.
        /// <para>When the item is serialized out as xml, its value is "atMost".</para>
        /// </summary>
        [EnumString("atMost")]
        AtMost,
        /// <summary>
        /// At Least.
        /// <para>When the item is serialized out as xml, its value is "atLeast".</para>
        /// </summary>
        [EnumString("atLeast")]
        AtLeast
    }

    /// <summary>
    /// Shape Grouping Types
    /// </summary>
    public enum EditAsValues
    {
        /// <summary>
        /// Shape Canvas.
        /// <para>When the item is serialized out as xml, its value is "canvas".</para>
        /// </summary>
        [EnumString("canvas")]
        Canvas,
        /// <summary>
        /// Organization Chart Diagram.
        /// <para>When the item is serialized out as xml, its value is "orgchart".</para>
        /// </summary>
        [EnumString("orgchart")]
        OrganizationChart,
        /// <summary>
        /// Radial Diagram.
        /// <para>When the item is serialized out as xml, its value is "radial".</para>
        /// </summary>
        [EnumString("radial")]
        Radial,
        /// <summary>
        /// Cycle Diagram.
        /// <para>When the item is serialized out as xml, its value is "cycle".</para>
        /// </summary>
        [EnumString("cycle")]
        Cycle,
        /// <summary>
        /// Pyramid Diagram.
        /// <para>When the item is serialized out as xml, its value is "stacked".</para>
        /// </summary>
        [EnumString("stacked")]
        Stacked,
        /// <summary>
        /// Venn Diagram.
        /// <para>When the item is serialized out as xml, its value is "venn".</para>
        /// </summary>
        [EnumString("venn")]
        Venn,
        /// <summary>
        /// Bullseye Diagram.
        /// <para>When the item is serialized out as xml, its value is "bullseye".</para>
        /// </summary>
        [EnumString("bullseye")]
        Bullseye
    }

    /// <summary>
    /// Shadow Type
    /// </summary>
    public enum ShadowValues
    {
        /// <summary>
        /// Single Shadow.
        /// <para>When the item is serialized out as xml, its value is "single".</para>
        /// </summary>
        [EnumString("single")]
        Single,
        /// <summary>
        /// Double Shadow.
        /// <para>When the item is serialized out as xml, its value is "double".</para>
        /// </summary>
        [EnumString("double")]
        Double,
        /// <summary>
        /// Embossed Shadow.
        /// <para>When the item is serialized out as xml, its value is "emboss".</para>
        /// </summary>
        [EnumString("emboss")]
        Emboss,
        /// <summary>
        /// Perspective Shadow.
        /// <para>When the item is serialized out as xml, its value is "perspective".</para>
        /// </summary>
        [EnumString("perspective")]
        Perspective,
        /// <summary>
        /// shapeRelative.
        /// <para>When the item is serialized out as xml, its value is "shapeRelative".</para>
        /// </summary>
        [EnumString("shapeRelative")]
        ShapeRelative,
        /// <summary>
        /// drawingRelative.
        /// <para>When the item is serialized out as xml, its value is "drawingRelative".</para>
        /// </summary>
        [EnumString("drawingRelative")]
        DrawingRelative
    }

    /// <summary>
    /// Defines the StrokeFillTypeValues enumeration.
    /// </summary>
    public enum StrokeFillTypeValues
    {
        /// <summary>
        /// solid.
        /// <para>When the item is serialized out as xml, its value is "solid".</para>
        /// </summary>
        [EnumString("solid")]
        Solid,
        /// <summary>
        /// tile.
        /// <para>When the item is serialized out as xml, its value is "tile".</para>
        /// </summary>
        [EnumString("tile")]
        Tile,
        /// <summary>
        /// pattern.
        /// <para>When the item is serialized out as xml, its value is "pattern".</para>
        /// </summary>
        [EnumString("pattern")]
        Pattern,
        /// <summary>
        /// frame.
        /// <para>When the item is serialized out as xml, its value is "frame".</para>
        /// </summary>
        [EnumString("frame")]
        Frame
    }
}