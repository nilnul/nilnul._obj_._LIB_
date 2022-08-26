using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple.be_
{
	public class FroCo<T, T1> : nilnul.obj.couple.BeI<T, T1>
	{
		private nilnul.obj.CoI<T,T1> _co;

		public nilnul.obj.CoI<T,T1> co
		{
			get { return _co; }
			set { _co = value; }
		}

		public bool be(Tuple<T, T1> obj)
		{
			return _co.co(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}
	}
}
