using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace nilnul.obj.serializer_
{
	[Obsolete()]
	static public class _XmlX
	{

		public static string Serialize4xml<T>(this T obj)
		{
			return nilnul.obj.lex_._XmlX.Serialize4xml(obj);
		}
		static public void Save<T>(T setting, string sFile) where T : class
		{
			int pos = sFile.LastIndexOf("\\");
			string sDir = sFile.Substring(0, pos);

			if (!Directory.Exists(sDir))
				Directory.CreateDirectory(sDir);

			if (File.Exists(sFile))
				File.Delete(sFile);

			XmlSerializer xs = new XmlSerializer(typeof(T));
			Stream stream = new FileStream(sFile, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite);
			xs.Serialize(stream, setting);
			stream.Close();
		}
		static public T Load<T>(string sFile) where T : class, new()
		{
			Object obj = new object();
			if (!File.Exists(sFile))
				return new T();
			Stream stream = new FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read);

			XmlSerializer xs = new XmlSerializer(typeof(T));
			obj = xs.Deserialize(stream) as T;
			stream.Close();
			return (T)obj;
		}
	}
}
