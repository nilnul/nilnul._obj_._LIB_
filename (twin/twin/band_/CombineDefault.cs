using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.twin.band_
{
	public class CombineDefault<T, TWin, TCombine>
		:
		obj.twin.BandI<T, TWin>
		where TWin : obj.TwinI<T>
		where TCombine : obj.CombineI1<T>, new()
	{
		public T band(TWin co)
		{
			return nilnul.obj_.Singleton<TCombine>.Instance.combine(co.component,co.component1);
		}


		static public CombineDefault<T, TWin, TCombine> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CombineDefault<T, TWin, TCombine>>.Instance;
			}
		}

	}
}
