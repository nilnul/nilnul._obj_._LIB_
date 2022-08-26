using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.unary_
{
	static public class _NopX
	{
		static public Expression<Func<T, T>> Lambda<T>() {
			return (Expression<Func<T,T> >)(x=>x);
		}


	}
}
