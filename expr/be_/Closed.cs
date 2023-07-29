using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Closed : expr.BeI
	{
		public bool be(ExprI4 obj)
		{
			var v = new _closed.lamda.Visitor(obj.expr.ee.Type);
			v.Visit(obj.expr);
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
