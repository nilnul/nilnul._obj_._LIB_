using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set._fold_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nameof(nilnul.obj.AggregateI)"/>
	public interface OfSetI<T, TSet>

		where TSet: nilnul.obj.Set_blank_ofElmentI<T>
	{
		T fold(TSet set);
	}
}
