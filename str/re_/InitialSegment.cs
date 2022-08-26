using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re_
{
		/// <summary>
		/// the first is the initial segment of latter. the two could be equal
		/// </summary>
	/// 
	public class InitialSegment<T> :
		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		nilnul.objs.ReI<T>
	{
		public InitialSegment(IEqualityComparer<T> val) : base(val)
		{
		}
		public InitialSegment():this(EqualityComparer<T>.Default)
		{

		}

		/// <summary>
		/// the first is the initial segment of latter. the two could be equal
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(IEnumerable<T> a, IEnumerable<T> b)
		{
			var aEnum = a.GetEnumerator();
			var bEnum = b.GetEnumerator();

			while (aEnum.MoveNext())
			{
				if (bEnum.MoveNext())
				{
					if (!this.boxed.Equals(aEnum.Current,bEnum.Current))
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}

			return true;
			
			//throw new NotImplementedException();
		}


		static public InitialSegment<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<InitialSegment<T>>.Instance;
			}
		}

	}
}
