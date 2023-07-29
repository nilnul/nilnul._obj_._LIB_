using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._seq_.current_
{
	public interface IRef
	{

	}
	/// <summary>
	/// if there is no current, throws an xpn in a way to impose the returning;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface RefI<T> {
		ref T current { get; }
	}
}
