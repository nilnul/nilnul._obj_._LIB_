using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.re_.init_
{
	/// <summary>
	/// 
	/// </summary>
	public class EqDefault<T,TEq> :
		
		nilnul.objs.re_.InitialSegment<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}


		static public EqDefault<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EqDefault<T,TEq>>.Instance;
			}
		}


	}
}
