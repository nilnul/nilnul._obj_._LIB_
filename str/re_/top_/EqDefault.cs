using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re_.top_
{
	/// <summary>
	/// in it. 
	/// </summary>
	public class EqDefault<T,TEq> :
		
		nilnul.obj.str.re_.Top<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault() : base(nilnul._obj.typ_._UnisonX<TEq>.Unison)
		{
		}


		static public EqDefault<T,TEq> Singleton
		{
			
			get
			{
				return nilnul._obj.typ_._UnisonX<EqDefault<T,TEq> >.Unison;
			}
		}

	}
}
