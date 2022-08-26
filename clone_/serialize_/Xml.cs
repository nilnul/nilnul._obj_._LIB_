using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace nilnul.obj.clone_.serialize_
{
	static public class _XmlX
	{

		/// <summary>
		/// XML serialization does not require [Serializable] attribute, which is good news.
		/// However, XML serialization requires each class to have a parameterless constructor. Such a requirement may seem harmless, but it is not always so. Having parameterless constructor in Person class means that an instance can be created without name, surname etc. I prefer to have all the required properties set by the time of object creation to avoid partially initialized objects. So XML serialization would not work for me in many cases.There is no choice between shallow and deep copies. Only the deep copy option is available for a software engineer when using serialization. --by https://levelup.gitconnected.com/5-ways-to-clone-an-object-in-c-d1374ec28efa
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static T CreateDeepCopy<T>(T obj)
		{

			using (var ms = new MemoryStream())
			{
				XmlSerializer serializer = new XmlSerializer(obj.GetType());
				serializer.Serialize(ms, obj);
				ms.Seek(0, SeekOrigin.Begin);
				return (T)serializer.Deserialize(ms);
			}

		}
	}
	
}
