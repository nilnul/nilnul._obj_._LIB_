using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_._associative
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

		public bool be(BinaryI<T> obj, T par, T par1,T par2)
		{
			return boxed.Equals(
				obj.op(
					obj.op(par, par1)
					,
					par2
				)
				,
				obj.op(
					par,
					obj.op(par1, par2)
				)
			);
		}
		public bool be(BinaryI<T> obj, (T, T,T) c)
		{
			return be(obj, c.Item1, c.Item2,c.Item3);
			//throw new NotImplementedException();
		}

		public bool be(BinaryI<T> obj, IEnumerable< T>  pars)
		{
			return nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<T>.Singleton.cumulate_each2monos(
				pars,
				pars,
				pars
			).All(t=>be(obj,t) );




		}

	}
}
