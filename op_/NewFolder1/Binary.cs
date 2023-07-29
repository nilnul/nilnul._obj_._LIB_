using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{
	[Obsolete(nameof(op_.Binary<T>))]
	public class Binary<T> :
		nilnul.obj.Box1<Func<T,T,T> >
		,
		BinaryI<T>
		//,
		//op_.of_.VecI<T>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">made defaultable</param>
		public Binary(Func<T, T, T> val) : base(val)
		{
		}

		public int arity => 2;

		public T op(T par, T par1)
		{
			return boxed(par,par1);
			//throw new NotImplementedException();
		}

		public T op(IEnumerable<T> vec)
		{
			obj.vec.of_._StrX._VowArity(2, vec);
			return op(vec.First(),vec.Last());



		}
	}


}
