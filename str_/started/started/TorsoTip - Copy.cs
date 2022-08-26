using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	static public class _TorsoTipX
	{
		static public (IEnumerable<T>, T) TorsoTip<T>(this IEnumerable<T> _started){
			return (_started.Torso(), _started.Tip());
		}
	}
}
