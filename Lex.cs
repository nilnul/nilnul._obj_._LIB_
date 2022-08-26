using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		interprest
	///		
	/// </remarks>
	public interface LexI<T>
		:obj.PhraseI<T>
		,
		obj._parse_.RetI<T>
	{
	}
}
