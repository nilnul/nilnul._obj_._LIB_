using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.capsule_
{
	/// <summary>
	/// the sub expr, including var and the expr itself, is of the same type;
	/// </summary>
	public interface ISubexprSameType
		:ICapsule
	{
	}
	public interface ISubexprSameType<T>
		:ICapsule<T>
		,
		ISubexprSameType
	{
	}

}
