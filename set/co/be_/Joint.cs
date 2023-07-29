using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.obj.set.co.be_
{
	
		static public class _JointX
		{

			static public bool Joint<T>(  IEnumerable<T> a, IEnumerable<T> b,IEqualityComparer<T> eq)
			{
				return b.Any(y => a.Contains(y));
			}

			static public bool Joint<T, TEq>(IEnumerable<T> a, IEnumerable<T> b )
				where TEq : IEqualityComparer<T>, new()
			{
				return Joint( a, b, nilnul.obj_.Singleton<TEq>.Instance);
			}


		}
	}
