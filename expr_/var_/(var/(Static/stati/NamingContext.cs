using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.stati
{
	public class NamingContext
	{
		static public var.Stati<T> Create<T>(string name) {

			return Create<T>(name, NamingContext3.StaticContext);

		}

		static public var.Stati<T> Create<T>(string name, NamingContext3 context) {

			if (context.containName(name))
			{
				throw new ArgumentException();
			}
			var x = new Stati<T>();

			context.name(x, name);

			return x;


		}


	}
}
