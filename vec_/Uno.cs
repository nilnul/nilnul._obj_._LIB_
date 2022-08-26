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
	///		mono
	///			<see cref="vec_.ICo"/>
	///		solo
	///			same start as <see cref="tup_.Single"/>
	///		uno
	///		
	public class Uno<T> : Tuple<T>
		,
		VecI<T>
	{
		public Uno(T item1) : base(item1)
		{
		}
		

		public IEnumerator<T> GetEnumerator()
		{
			yield return this.Item1;

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
