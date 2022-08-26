using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups_
{
	/// <summary>
	/// the tups's row's item is not indexed by index, but by col name.
	/// the col is indexed by name; and can be ordered, or not ordered.
	/// </summary>
	public interface ITable
		:obj.ITups
	{
	}
}
