using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.table
{
	public static class _ToObjsX
	{
		private static readonly IDictionary<Type, ICollection<PropertyInfo>> _Properties =
			new Dictionary<Type, ICollection<PropertyInfo>>();

		/// <summary>
		/// Converts a DataTable to a list with generic objects
		/// </summary>
		/// <typeparam name="T">Generic object</typeparam>
		/// <param name="table">DataTable</param>
		/// <returns>List with generic objects</returns>
		public static IEnumerable<T> ToObjs<T>(this DataTable table) 
			where T : class, new()
		{
			try
			{
				var objType = typeof(T);
				ICollection<PropertyInfo> properties;

				lock (_Properties)
				{
					if (!_Properties.TryGetValue(objType, out properties))
					{
						properties = objType.GetProperties().Where(property => property.CanWrite).ToList();
						_Properties.Add(objType, properties);
					}
				}

				var list = new List<T>(table.Rows.Count);

				foreach (var row in table.AsEnumerable())
				{
					var obj = new T();

					foreach (var prop in properties)
					{
						try
						{
							if (table.Columns.Contains(prop.Name))
							{
								var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
								var safeValue = ( row[prop.Name]  is null || row[prop.Name] ==DBNull.Value )? null : Convert.ChangeType(row[prop.Name], propType);

								

								prop.SetValue(obj, safeValue, null);

							}

						}
						catch
						{
							//throw;
							// ignored
						}
					}

					list.Add(obj);
				}

				return list;
			}
			catch
			{
				//throw;
				return Enumerable.Empty<T>();
			}
		}
	}
}
