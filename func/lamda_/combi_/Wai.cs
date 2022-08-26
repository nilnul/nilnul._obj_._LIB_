using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.lamda_.combi_
{
	static public class _WaiX
	{
		/// <summary>
		/// we are in the namespace of <see cref="nameof(nilnul.obj)"/>. So the input: Func{Func{A, R}, Func{A, R}} and the output: Func{A，R} are both the subtype of Obj
		/// </summary>
		/// <typeparam name="A"></typeparam>
		/// <typeparam name="R"></typeparam>
		/// <param name="f">the arg is a lambda as it's a function of func</param>
		/// <returns></returns>
		public static Func<A, R> Wai<A, R>(
			Func<
				Func<A, R>
				,
				Func<A, R>
			> f
		)
		{
			return t => f(Wai(f))(t);
		}

	}
}
