using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni.be_
{
	/// <summary>
	/// take the return type as the type for comparision.
	/// the type of input shall be subtype of return type
	/// </summary>
	public class Closed
		: func.calc_.lamda_.uni.BeI
	{
		public bool be(shelly_.Uni obj)
		{
			return obj.ee.ReturnType.IsAssignableFrom(
				obj.ee.Parameters.First().Type
			);
			//throw new NotImplementedException();
		}


		static public Closed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Closed>.Instance;
			}
		}

	}
}
