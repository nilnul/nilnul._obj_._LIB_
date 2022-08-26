using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.obj.lex_
{
	static public class _XmlX
	{

		public static string Serialize4xml<T>(this T obj)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			using (var stringWriter = new StringWriter())
			{
				using (XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter) { Formatting = Formatting.Indented })
				{
					serializer.Serialize(xmlWriter, obj);
					return stringWriter.ToString();
				}
			}
		}
		public static T Deserialize5xml<T>(this string obj)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			return (T) serializer.Deserialize(
				new StringReader(
					obj
				)
			);
		
		}


	
	}
}
