using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_._keep_.prev_
{
	public interface IRef
	{

	}
	/// <summary>
	/// if there is no prev, throws an xpn in a way to impose the returning;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface RefI<T> {
		ref T prev { get; }
	}
}
