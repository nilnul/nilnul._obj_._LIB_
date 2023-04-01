using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.comp_
{
	public class Lower<T, TBorder> :
		nilnul.obj.Box<IComparer<T>>
		,
		IComparer<TBorder>
		where TBorder:BorderI<T>
	{
		public Lower(IComparer<T> val) : base(val)
		{
		}
		public Lower():this(Comparer<T>.Default)
		{

		}

		public int Compare(TBorder x, TBorder y)
		{
			var compared = boxed.Compare(x.mark, y.mark);
			if ( compared !=0)
			{
				return compared;
			}
			return _border_.at.comp_.Lower.Singleton.Compare(x.openFalseCloseTrue,y.openFalseCloseTrue);

		}


		static public Lower<T, TBorder> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Lower<T, TBorder>>.Instance;
			}
		}

	}
}
