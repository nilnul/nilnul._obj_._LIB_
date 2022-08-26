using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.lex_
{
	/// <summary>
	/// dotnet framework is inconsistent in writing and reading in that:
	///		in writing, xmlSerializer doesnot write the wrapper element
	///		in reading, xmlSerailizer is required to handler the wrapper.
	///	So we better to write a separate one, like "toXml", to return an XElement, which can be later, not in this serializer, converted into an xml element, or string.
	/// </summary>
	class IXml
	{
	}
}
