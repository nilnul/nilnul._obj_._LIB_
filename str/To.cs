using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public interface ToI<TElOfStr,TTgt>
		:
		nilnul.obj.ToI<  IEnumerable<TElOfStr>,TTgt>
	{

	}
}
