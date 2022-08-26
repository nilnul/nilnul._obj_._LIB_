using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.clone_
{
	static public class _SerializerX
	{

		/// <summary>
		/// There is no choice between shallow and deep copies. Only the deep copy option is available for a software engineer when using serialization.
		/// </summary>
		/// <typeparam name="T">Class <var>T</var> and all related ones need to be marked with [Serializable] attribute.</typeparam>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static T CreateDeepCopy<T>(T obj)
		{
			using (var ms = new MemoryStream())
			{
				IFormatter formatter = new BinaryFormatter();
				formatter.Serialize(ms, obj);
				ms.Seek(0, SeekOrigin.Begin);
				return (T)formatter.Deserialize(ms);
			}
		}
	}
}
