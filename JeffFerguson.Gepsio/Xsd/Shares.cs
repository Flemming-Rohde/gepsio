﻿using JeffFerguson.Gepsio.Xml.Interfaces;

namespace JeffFerguson.Gepsio.Xsd
{
	/// <summary>
	/// An encapsulation of the XML schema type "shares" as defined in the http://www.xbrl.org/2003/instance namespace. 
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class should be considered deprecated and will most likely be removed in a future version of Gepsio. In early CTPs,
	/// Gepsio implemented its own XML schema parser, and this class was created for the implementation of the XML schema parser
	/// type system. In later CTPs, Gepsio levergaed the XML schema support already available in the .NET Framework, which rendered
	/// Gepsio's XML schema type system obsolete.
	/// </para>
	/// </remarks>
	public class Shares : Decimal
	{
		internal Shares(INode StringRootNode)
			: base(StringRootNode)
		{
		}
	}
}
