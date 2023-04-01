using nilnul.obj.comp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.max_
{
	public class OnComp<T>
		:
		nilnul.obj.Box_ofIn<IComparer<T>>
		,
		BinaryI<T>
	{
		public OnComp(in IComparer<T> val) : base(val)
		{
		}

		public OnComp(IComparer<T> x) : base(x)
		{
		}
		public OnComp():this(Comparer<T>.Default)
		{

		}

		public T op(T par, T par1)
		{
			return boxed.Ge(par, par1) ? par : par1;
		}


		static public OnComp<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OnComp<T>>.Instance;
			}
		}

	}
}
