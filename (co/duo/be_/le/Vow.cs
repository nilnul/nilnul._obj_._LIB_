using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be_.le
{
	public class Vow<T> : nilnul.obj.be.Vow<nilnul.obj.Duo<T>, Le<T>>
	{
		public Vow(Le<T> be) : base(be)
		{
		}
	}
}
