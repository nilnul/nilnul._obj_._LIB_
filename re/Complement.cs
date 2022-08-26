using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re
{
	public class Complement<T> 
		: 
		nilnul.obj._form.Arg<ReI<T>>
		,
		nilnul.obj.ReI<T>
	{
		//private ReI<T> _arg;

		//public ReI<T> arg
		//{
		//	get { return _arg; }
		//	//set { _arg = value; }
		//}

		public Complement(ReI<T> re):base(re)
		{
		}
		public bool re(T a, T b)
		{
			return !arg.re(a,b);
			//throw new NotImplementedException();
		}
	}

	[Obsolete(nameof(complement_.ReDefault<T,TRe>))]
	public class Complement<T, TRe> : Complement<T>
		where TRe : nilnul.obj.ReI<T>, new()
	{
		public Complement() : base(nilnul.obj.SingletonByLazy<TRe>.Lazy)
		{
		}


		static public Complement<T,TRe> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Complement<T,TRe>>.Instance;
			}
		}

	}
}
