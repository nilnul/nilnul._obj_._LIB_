using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.comp_
{
	//[Obsolete(nameof(nilnul.bit.Comp))]
	public class Upper<T, TBorder> :
		nilnul.obj.Box<IComparer<T>>
		,
		IComparer<TBorder>
		where TBorder:BorderI<T>
	{
		public Upper(IComparer<T> val) : base(val)
		{
		}
		public Upper():this(Comparer<T>.Default)
		{

		}


		static public Upper<T, TBorder> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Upper<T, TBorder>>.Instance;
			}
		}


		public int Compare(TBorder x, TBorder y)
		{
			var compared = boxed.Compare(x.mark, y.mark);
			if ( compared !=0)
			{
				return compared;
			}
			return _border_.at.comp_.Upper.Singleton.Compare(x.openFalseCloseTrue,y.openFalseCloseTrue);
			

		}
	}
}
