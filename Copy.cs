using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	static public class _CopyX
	{

		static public void Copy<T>(ref T target, ref T src)
		{
			//var propInfo = target.GetType().GetProperties();
			foreach (var item in 
				target.GetType().GetProperties().Where(p=>p.CanRead)
			)
			{
				if (item.CanWrite)
				{
					target.GetType().GetProperty(item.Name).SetValue(target, item.GetValue(src, null), null);
				}
			}
		}

		static public void Copy_excludingProps<T>(ref T target, ref T src, params string[] props2bExcluded)
		{
			//var propInfo = target.GetType().GetProperties();
			foreach (var prop in 
				target.GetType().GetProperties().Where(p=>p.CanRead).Where(p=>!props2bExcluded.Contains( p.Name) )
			)
			{
				if (prop.CanWrite)
				{
					target.GetType().GetProperty(prop.Name).SetValue(target, prop.GetValue(src, null), null);
				}
			}
		}

		static public void ExcludingProps<T>( T target,  T src, params string[] props2bExcluded)
		{
			//var propInfo = target.GetType().GetProperties();
			foreach (var prop in 
				target.GetType().GetProperties().Where(p=>p.CanRead).Where(p=>!props2bExcluded.Contains( p.Name) )
			)
			{
				if (prop.CanWrite)
				{
					target.GetType().GetProperty(prop.Name).SetValue(target, prop.GetValue(src, null), null);
				}
			}
		}



		/// <summary>
		/// Perform a deep Copy of the object, using Json as a serialisation method. NOTE: Private members are not cloned using this method.
		/// </summary>
		/// <typeparam name="T">The type of object being copied.</typeparam>
		/// <param name="source">The object instance to copy.</param>
		/// <returns>The copied object.</returns>
		public static T ClonePublicPropByJson<T>(this T source)
		{
			//// Don't serialize a null object, simply return the default for that object
			//if (Object.ReferenceEquals(source, null))
			//{
			//	return default(T);
			//}


			// initialize inner objects individually
			// for example in default constructor some list property initialized with some values,
			// but in 'source' these items are cleaned -
			// without ObjectCreationHandling.Replace default constructor values will be added to result
			var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

			return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
		}
	}
}
