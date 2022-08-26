using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.be_
{
	public class NulFalse<T, TBe> 
		:
		nilnul.obj.Box<TBe>
		,
		nilnul.obj.BeI1<T>

		where TBe : nilnul.obj.BeI1<T>
	{
		public NulFalse(TBe val) : base(val)
		{
		}

		public bool be(T obj)
		{
			if (object.ReferenceEquals(obj ,null))
			{
				return false;
			}
			return this.boxed.be(obj);
		}
	}


}
