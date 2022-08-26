using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a co but unordered.
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		twin
	///			tinges "two".
	///		tie
	///		both
	///		pair
	///		spouse
	public interface TwinI<T>
		:
		nilnul.obj.CoI2<T>	/// one must know order before he can ignore it (see: Who cares about topology? (Inscribed rectangle problem), by 3blue1brown, youtube.com/watch?v=AmgkSdhK4K8);  we need to first define something for it to be ignored later.
	{

	}
	public class Twin<T> :
		nilnul.obj.Co<T>
		, TwinI<T>
	{
		public Twin(Tuple<T, T> tuple) : base(tuple)
		{
		}

		public Twin(T item1, T item2) : base(item1, item2)
		{
		}
	}
}
