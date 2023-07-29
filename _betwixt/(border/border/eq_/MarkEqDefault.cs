using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.eq_
{

	public class MarkEqDefault<T, TEq, TBorder>
		: Eq<T,TBorder>
		where TEq : IEqualityComparer<T>, new()
		where TBorder : BorderI<T>
	{



		public MarkEqDefault()
			:base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance

				 )
		{

		}

		static public MarkEqDefault<T, TEq, TBorder> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<MarkEqDefault<T, TEq, TBorder>>.Instance;
			}
		}


	}

	public class MarkEqDefault<T,TEq>
		:MarkEqDefault<T,TEq,obj.BorderI<T>>

		where TEq:IEqualityComparer<T>,new()
	{

	}


}
