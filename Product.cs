using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete("nilnul.num.integer")]
	public partial class Product
	{



		static public uint Eval(params uint[] numbers)
		{

			return numbers.Aggregate((uint)1, (a, c) => a * c);

		}
	}
}
namespace nilnul_obj
{
	[Obsolete("nilnul.num.integer")]
	public partial class Product
	{



		static public uint Eval(params uint[] numbers)
		{

			return numbers.Aggregate((uint)1, (a, c) => a * c);

		}
	}
}
