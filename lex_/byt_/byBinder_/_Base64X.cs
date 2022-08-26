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

namespace nilnul.obj.lex_.byt_.byBinder_
{
	static public class _Base64X
	{
		/// <summary>
		/// ignore version
		/// </summary>
		static public readonly BinaryFormatter Lexer = _BytX.OfBinderOnName;

		public static string Serialize2Base6four(this object obj)
		{
			using (
				var stream = new MemoryStream()
			)
			{
				Lexer.Serialize(stream, obj);
				return Convert.ToBase64String(stream.ToArray());
			}
		}

		public static T Deserialize5Base6four<T>(this string obj)
		{
			return (T) Lexer.Deserialize(
				 new MemoryStream(
					 Convert.FromBase64String(obj)
				)
			);
		}
	}
}