using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.co.be_._distributive._left
{
	public class OnObjs<T>
		:
		nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		
	{
		public OnObjs(IEqualityComparer<T> val) : base(val)
		{
		}
		public OnObjs():this(EqualityComparer<T>.Default)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="plus">follow the convention in <see cref="obj.algebra_.cobiop_.ISemiring"/> , putting additin first, multiplication second</param>
		/// <param name="multi"></param>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <param name="par2"></param>
		/// <returns></returns>
		public bool be(BinaryI<T> plus, BinaryI<T> multi,T par, T par1,T par2)
		{
			return boxed.Equals(
				multi.op(
					par,
					plus.op(par1, par2)
					
				)
				,
				plus.op(
					multi.op( par,par1),
					multi.op(par1, par2)
				)
			);
		}
		public bool be(BinaryI<T> plus, BinaryI<T> multi, (T, T,T) c)
		{
			return be(plus,multi, c.Item1, c.Item2,c.Item3);
			//throw new NotImplementedException();
		}

		public bool be(BinaryI<T> obj,BinaryI<T> multi, IEnumerable< T>  pars)
		{
			return nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<T>.Singleton.cumulate_each2monos(
				pars,
				pars,
				pars
			).All(t=>be(obj,multi,t) );




		}

	}
}
