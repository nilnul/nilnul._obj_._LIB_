using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_._var
{
	/// <summary>
	/// as the dotnet builtin <see cref="ParameterExpression"/> is not statically typed, we need to check its type to see whether it is of the specified type, 
	/// </summary>
	/// <typeparam name="T"></typeparam>
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
