using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.vow.ee_
{
	public class VowDefaulted<T, TVow>
		:
		nilnul.obj.seq.vow.Ee1<T>
		where TVow : nilnul.obj.VowI2<IEnumerable<T>>, new()
	{
		public VowDefaulted(IEnumerable<T> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
