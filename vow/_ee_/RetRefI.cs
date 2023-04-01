using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow._ee_
{
	public interface RetRefI<T>

	{

		ref T eeByRef { get; }
	}
}
