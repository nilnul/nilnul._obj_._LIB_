using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.state
{
	public class Inject<TInVar,TRet>
	{

		private nilnul.obj.var.Set<TInVar> _vars;

		public nilnul.obj.var.Set<TInVar> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		private IEqualityComparer<TInVar> _valEq;

		public IEqualityComparer<TInVar> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}


		private Dictionary<State_heritDict<TInVar>,TRet> _dict;

		public Dictionary<State_heritDict<TInVar>,TRet> dict
		{
			get { return _dict; }
			set { _dict = value; }
		}




		public Inject( nilnul.obj.var.Set<TInVar>  set ,  IEqualityComparer<TInVar> valEq )
		{
			_vars = set;

			_valEq = valEq;

			_dict = new Dictionary<State_heritDict<TInVar>, TRet>(

				new eq_.sameVars.SameVals_givenVars<TInVar>(
					set,valEq	
				)
				
			);

		}

		public void add(
			IEnumerable<TInVar> vals
			,TRet ret	
		) {

			var assign = new nilnul.obj.var.set.State_heritDict<TInVar>(_vars, vals);
			_dict.Add(
				assign,ret	
			);


		}

	}
}
