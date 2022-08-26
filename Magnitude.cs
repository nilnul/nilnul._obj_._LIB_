using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete(("nilnul.num.real:: "))]
	static public class _MagnitudeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		static public string Phrase(_magnitude.QuantityI quantity, _magnitude.UnitI unit) {
			return $"{quantity}{unit}";
		}
	}
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// aliase:
	///		measure
	/// </remarks>
	public abstract class MagnitudeA
	{
		
	}
}
