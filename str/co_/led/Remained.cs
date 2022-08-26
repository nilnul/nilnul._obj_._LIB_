using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.co_.led
{
	static public class _RemainedX
	{
		static public IEnumerable<T> Remained<T>(IEnumerable<T> led, IEnumerable<T> longer) {
			return longer.Skip(led.Count());
		}
	}
}
