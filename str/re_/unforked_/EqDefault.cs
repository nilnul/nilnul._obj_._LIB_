using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.re_.align_
{
	/// <summary>
	/// 
	/// </summary>
	public class EqDefault<T,TEq> :
		
		nilnul.objs.re_.Align<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.Singleton<TEq>.Instance
		)
		{
		}

		static public EqDefault<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault<T,TEq>>.Instance;
			}
		}



	}
}
