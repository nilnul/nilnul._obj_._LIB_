using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{
	/// <summary>
	/// this is implicitly closed, as for input being of different type, it's not unary, it's a general <see cref="OfI1{TRet, TArg}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public class Unary<T>
		:
		op_.Unary<T,T>,

		UnaryI<T>
		,
		of_.VecI<T>
		,
		obj.OfI1<T,T>

	{
		public Unary(Func<T, T> val) : base(val)
		{
		}

		public T op(IEnumerable<T> vec)
		{
			obj.vec_._str._VowX._VowArity(1, vec);
			return op(vec.First());
		}

		
	}

}
