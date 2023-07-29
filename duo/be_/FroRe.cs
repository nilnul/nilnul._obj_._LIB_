using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be_
{


	public class FroRe<T> : nilnul.obj.duo.BeI1<T>
	{
		private nilnul.obj.ReI<T> _re;

		public nilnul.obj.ReI<T> re
		{
			get { return _re; }
			set { _re = value; }
		}

		public FroRe(nilnul.obj.ReI<T> eq)
		{
			_re = eq;
		}
		public bool be(Tuple<T, T> obj)
		{
			return _re.re(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}
	}

	public class FroRe<T, TRe> : FroRe<T>
		where TRe : ReI<T>, new()
	{
		public FroRe() : base(SingletonByDefault<TRe>.Instance)
		{
		}
	}
}
