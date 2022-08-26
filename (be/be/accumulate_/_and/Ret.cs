using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.accumulate_._and
{
	public class Ret<T>:nilnul.obj.BeI<T>
	{
		private IEnumerable<System.Func<T, bool>> _funcs;

		public IEnumerable<System.Func<T, bool>> funcs
		{
			get { return _funcs; }
			set { _funcs = value; }
		}

		public Ret(IEnumerable<System.Func<T, bool>> funcs)
		{
			_funcs = funcs;
		}

		static public bool Be(IEnumerable<System.Func<T, bool>> funcs, T obj) {

			if (funcs.Any())
			{
				return funcs.First()(obj) && Be(funcs.Skip(1), obj);
			}
			return nilnul.obj.be.combine_.And<T>.Unit.be(obj);
		}

		public bool be(T obj)
		{
			return Be(_funcs, obj);
			//throw new NotImplementedException();
		}
	}
}
