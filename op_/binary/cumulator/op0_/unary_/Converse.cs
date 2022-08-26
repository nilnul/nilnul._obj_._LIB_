using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.op0_.unary_
{
	public class Converse<TObj>
		: nilnul.obj.op_.UnaryI<
			binary.CumulatorI<TObj>
		>
	{
		public CumulatorI<TObj> op(CumulatorI<TObj> par)
		{
			return opAsClass(par) ;
			//throw new NotImplementedException();
		}
		public Cumulator<TObj> opAsClass(CumulatorI<TObj> par)
		{
			return new Cumulator<TObj>(par.initial,new binary.Converse<TObj> (par.binder));
			//throw new NotImplementedException();
		}


		static public Converse<TObj> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Converse<TObj>>.Instance;
			}
		}



	}
}
