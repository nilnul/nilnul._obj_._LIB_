using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		alesce as in "coalesce"
	/// </remarks>
	public interface IAlesce
	{
	}
	/// <summary>
	/// this shall inherit T
	/// </summary>
	public interface IAlesce<T>:IAlesce
	{
	}

	/// <summary>
	///  Co ->Alesce
	///			is obj.Combine
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TCo"></typeparam>
	public class AlesceA<T, TCo> :
		nilnul.obj.Box<TCo>
		,
		IAlesce<T>
	{
		public AlesceA(TCo val) : base(val)
		{
		}

	}
}
