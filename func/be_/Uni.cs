using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Uni
		: func.BeI
	{
		
		public bool be(F obj)
		{
			return obj.flat.ee.Parameters.Count == 1;

		}

		static public Uni Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Uni>.Instance;
			}
		}

	}
}
