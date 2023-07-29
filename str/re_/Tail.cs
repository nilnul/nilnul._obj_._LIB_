using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re_
{

	/// <summary>
	/// the first is the  <see cref="obj.str.ITail"/>, of latter. the two could be equal
	/// </summary>
	/// alias:
	///		tail
	///		include
	///			bad, as it is maybe in the middle
	public class Tail<T> :
		obj.str.re.Converse<T>
		//nilnul.obj.Box1<IEqualityComparer<T>>
		//,
		//nilnul.objs.ReI<T>
		,
		ITail
	{
		public Tail(IEqualityComparer<T> val) : base(new Top<T>(val))
		{
		}
		public Tail() : this(EqualityComparer<T>.Default)
		{

		}

	

		static public Tail<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Tail<T>>.Unison;
			}

		}

	}
}
