using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be
{
	
	public class Vow_beDynamic<T,TBe> :

		nilnul.obj.be.Vow4<IEnumerable<T>>
		//nilnul.obj.Box<TBe>
		,
		nilnul.obj.seq.VowI<T>
		where TBe: nilnul.obj.seq.BeI<T>
	{
		public Vow_beDynamic(TBe val) : base(val)
		{
		}

	

		

	}
	public class Vow_beDynamic<T> :

		Vow_beDynamic<T,BeI<T>>
		,
		nilnul.obj.seq.VowI<T>
	{
		public Vow_beDynamic(BeI<T> val) : base(val)
		{
		}

		

		

	}


}
