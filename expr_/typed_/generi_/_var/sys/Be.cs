using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_._var
{
	public class Be<T> : nilnul.obj.BeI1<ParameterExpression>
	{
		public bool be(ParameterExpression obj)
		{
			return obj.Type==typeof(T);
		}

		static public Be<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be<T>>.Instance;
			}
		}

	}

}
