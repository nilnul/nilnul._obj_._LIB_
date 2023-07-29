using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.interpret.duo_.sameVars.be_
{
	public class DifVal<T,TRet>
	{
		private IEqualityComparer<TRet> _valEq;

		public IEqualityComparer<TRet> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}

		public DifVal(IEqualityComparer<TRet> valEq)
		{
			_valEq = valEq;
		}

		public bool _be_avowSameVars(Interpret<T,TRet> a, Interpret<T,TRet> b) {
			return !_valEq.Equals(a);
		}
	}
}
