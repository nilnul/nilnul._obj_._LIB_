using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TComponent">TCel</typeparam>
	public class Plusable<TComponent>
		:
		co.BeI<TComponent>
	{
		public bool be(in (TComponent[,], TComponent[,]) val)
		{
			return matrix.re_._SameSizeX.Re(val.Item1, val.Item2);
			//throw new NotImplementedException();
		}


		static public Plusable<TComponent> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Plusable<TComponent>>.Instance;
			}
		}

	}
}
