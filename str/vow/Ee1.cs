using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vow
{
	public class Ee1<T, TStr>
		:
		nilnul.obj.vow.Ee1<TStr>
		,
		IEnumerable<T>

		where TStr : IEnumerable<T>
	{
		

		public Ee1(TStr val, obj.VowI2<TStr> vow) : base(val, vow)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}


	

}
