using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_.nard.cumulate_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class EqNeo<T,TEq> :
		nard.CumulateShortcutable<T>
		where TEq:IEqualityComparer<T>,new()

	{
		

		public EqNeo(cumulator_.NardableI<T> val) : base(
			val, nilnul._obj.typ_.nilable_.unprimable_.Singleton<TEq>.Instance
		)
		{
		}

		
	}
}
