using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.obj.lex_
{

	static public class _BytX
	{
		/// <summary>
		/// ignore version
		/// </summary>
		static public readonly BinaryFormatter OfBinderOnName = new BinaryFormatter() {
			Binder= _byt.bind_.ByName.Singleton
		};

		static public readonly BinaryFormatter OfTypeFroName = new BinaryFormatter() {
			Binder= _byt.bind_.name_.ToTypeOnly.Singleton
		};

	
	}
}