using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_.nard.cumulate_.eqNeo_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class OpNeo<T,TEq,TOp> :
		nard.cumulate_.EqNeo<T,TEq>
		where TEq:IEqualityComparer<T>,new()
		where TOp: binary.cumulator_.NardableI<T>,new()
	{
		

		public OpNeo() :
			base(
			_obj.typ_.nilable_.unprimable_.Singleton<TOp>.Instance
				
		)
		{
		}


		static public OpNeo<T,TEq,TOp>  Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OpNeo<T,TEq,TOp> >.Instance;
			}
		}



	}
}
