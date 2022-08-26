using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.typed_.generi.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Uni<TRet>
		: BeI<
			TRet
		>
	{
		public bool be(func.calc_.lamda_.typed_.Generi<TRet> obj)
		{
			return obj.untyped.ee.Parameters.Count == 1;
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
