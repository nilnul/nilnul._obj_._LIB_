using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	/// <summary>
	/// </summary>
	public class Counted<T> :
	nilnul.obj.Box1<int>
	,
	BeI3<T>
	{
		public Counted(int val) : base(val)
		{
		}
		public bool be(IEnumerable<T> obj)
		{
			return obj.Count() == boxed;
		}
	}
}