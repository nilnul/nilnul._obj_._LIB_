using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started
{
	public class AsSeq<T>
		:
		AsSeq<T, nilnul.obj.str_.Sans0StartedI<T>>

	{
		public AsSeq(Sans0StartedI<T> val) : base(val)
		{
		}
	}
	public class AsSeq<T, TStr> : nilnul.obj.Box<nilnul.obj.str_.Sans0StartedI<T>>
		,
		IEnumerable<T>
		where TStr:
			nilnul.obj.StrI2<T>
			,
			nilnul.obj.str_.Sans0StartedI<T>
	{
		public AsSeq(Sans0StartedI<T> val) : base(val)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			switch (boxed)
			{
				case sans0Started_._sans_.BlankI _:
					yield break;
				case sans0Started_.StartedI<T,TStr> started:
					yield return started.head;
					foreach (var item in new str.AsSeq<T,TStr>( started.body ))
					{
						yield return item;
					}
					yield break;
				default:
					throw new UnexpectedTypeException($"{boxed.GetType().FullName}:{boxed} is not {typeof(sans0Started_._sans_.BlankI).FullName} or {typeof(sans0Started_.StartedI<T,TStr>).FullName}");
					break;
			}

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();//
			//throw new NotImplementedException();
		}
	}
}
