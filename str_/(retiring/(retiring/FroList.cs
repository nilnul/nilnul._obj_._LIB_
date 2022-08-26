using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	public class _FroList<T>  
	{
		static public StrI<T> FroList(List<T> list) {
			if (list.Any())
			{
				return new started_.FroArray<T>(list);

			}
			return new Sans<T>();
		}
		
	}
}
