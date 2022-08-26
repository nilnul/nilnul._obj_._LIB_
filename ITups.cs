using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a collection of <see cref="ITup"/>, the order of which is indeterminate.
	/// If it's indexed by name instead of index number, it's called <see cref="tups_.ITable"/>
	/// </summary>
	public interface ITups:IObjs<ITup>
	{
	}
}
