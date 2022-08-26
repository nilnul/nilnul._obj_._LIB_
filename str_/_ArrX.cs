using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	static public class _ArrX
	{
		public static T[] GenerateOfDefaults<T>(int num)
		{
			var r= new T[num];
			for (int i = 0; i < num; i++)
			{
				r[i] = default(T);
			}
			return r;

		}

		public static T[] Generate<T>(int num, T val)
			where T:new()
		{
			var r= new T[num];
			for (int i = 0; i < num; i++)
			{
				r[i] = val;
			}
			return r;

		}
		public static T[] GenerateByNew<T>(int num)
			where T:new()
		{
			var r= new T[num];
			for (int i = 0; i < num; i++)
			{
				r[i] = new T();
			}
			return r;

		}



	}
}
