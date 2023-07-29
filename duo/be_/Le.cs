using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be_
{
	public class Le<T> : nilnul.obj.duo.BeI1<T>
	{
		private comp.Re<T> _re;

		public comp.Re<T> re
		{
			get { return _re; }
			set { _re = value; }
		}

		public Le(comp.Re<T> re)
		{
			_re = re;
		}
		public bool be(Tuple<T, T> obj)
		{
			return re.le(obj.Item1, obj.Item2);

			throw new NotImplementedException();
		}
	}
}
