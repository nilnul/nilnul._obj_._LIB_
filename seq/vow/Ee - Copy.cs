using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.vow
{
	[Obsolete()]
	public class Ee<T, TVow> : nilnul.obj.vow.En<IEnumerable<T>, TVow>
		where TVow : nilnul.obj.seq.VowI<T>, new()
	{
		public Ee(IEnumerable<T> val) : base(val)
		{
		}
	}

	[Obsolete()]
	public class Ee_vowDyna<T, TVow> :
		nilnul.obj.vow.Ee <IEnumerable<T>, TVow>
		where TVow : nilnul.obj.seq.VowI<T>
	{
		public Ee_vowDyna(IEnumerable<T> val, TVow vow) : base(val,vow)
		{
		}
	}

}
