using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.twin
{
	/// <summary>
	/// this shall inherit T
	/// </summary>
	public interface IAlesce<T,TTwin>

	{
	}

	/// <summary>
	///  Co ->Alesce
	///			is obj.Combine
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TTwin"></typeparam>
	public class AlesceA<T, TTwin> :
		nilnul.obj.Box<TTwin>
		,
		IAlesce<T,TTwin>
		where TTwin:obj.TwinI<T>
	{
		public AlesceA(TTwin val) : base(val)
		{
		}

	}
}
