using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///

	[Obsolete(nameof(expr.be_.Closed))]
	public class Closed
		:untyped.BeI
	{
		public bool be(UntypedI obj)
		{

			var v = new expr.be_._closed.lamda.Visitor(obj.lambda.ee.Type);
			v.Visit(obj.lambda);
			return v.beOfType;
			//throw new NotImplementedException();
		}


		static public Closed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Closed>.Instance;
			}
		}

	}
}
