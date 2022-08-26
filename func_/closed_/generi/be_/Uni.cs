using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed_.generi.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Uni<TRet>
		: BeI<
			TRet
		>
	{
		public bool be(func_.closed_.Generi<TRet> obj)
		{
			return obj.ee.ee.flat.ee.Parameters.Count == 1;
			//throw new NotImplementedException();
		}


		static public Uni<TRet> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Uni<TRet>>.Instance;
			}
		}

	}
}
