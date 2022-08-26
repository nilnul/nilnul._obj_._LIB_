using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.to_._txt
{
	public static class Extensions
	{

		static public string _ToTxt_byLoop<T>(this IEnumerable<T> _started, string seperator)
		{

			var str = _started.First().ToString();

			foreach (var item in _started.Skip(1))
			{
				str += seperator + (item).ToString();

			}
			return str;



		}


	}
}
