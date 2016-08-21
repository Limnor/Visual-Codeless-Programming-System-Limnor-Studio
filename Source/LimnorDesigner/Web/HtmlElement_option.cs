﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Programming Language Implement
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using Limnor.WebBuilder;

namespace LimnorDesigner.Web
{
	public class HtmlElement_option : HtmlElement_ItemBase
	{
		public HtmlElement_option(ClassPointer owner)
			: base(owner)
		{
		}
		public HtmlElement_option(ClassPointer owner, string id, Guid guid)
			: base(owner, id, guid)
		{
		}
		public override string tagName
		{
			get { return "option"; }
		}
		[Description("Specifies that the element should be disabled")]
		[Browsable(false)]
		[XmlIgnore]
		[WebClientMember]
		public bool disabled
		{
			get;
			set;
		}
		[Description("Specifies a label for an option-group")]
		[Browsable(false)]
		[XmlIgnore]
		[WebClientMember]
		public string label
		{
			get;
			set;
		}
		[Description("Specifies that an option should be pre-selected when the page loads")]
		[Browsable(false)]
		[XmlIgnore]
		[WebClientMember]
		public bool selected
		{
			get;
			set;
		}
		[Description("Specifies the value to be sent to a server")]
		[Browsable(false)]
		[XmlIgnore]
		[WebClientMember]
		public string value
		{
			get;
			set;
		}
	}
}
