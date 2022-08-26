using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		nino
	///		nano
	///		neno
	///		nuno
	///		nano
	///			also in nano meter.
	public class Nono<T>
		:
		VecI<T>
	{


		static public Nono<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nono<T>>.Instance;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield break;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
