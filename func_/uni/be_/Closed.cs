using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.uni.be_
{
	/// <summary>
	/// take the return type as the type for comparision.
	/// the type of input shall be subtype of return type
	/// </summary>
	public class Closed
		:
		func_.uni.BeI
	{
		public bool be(Uni obj)
		{
			return obj.flat.ee.ReturnType.IsAssignableFrom(
				obj.flat.ee.Parameters.First().Type
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
