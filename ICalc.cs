using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a calculation. op.Call
	/// </summary>
	/// <remarks>
	/// alias:
	///		call
	///		,
	///		formula
	///		,
	///		calculation
	///		,
	///		expression
	///		,
	///		equation
	///		,
	///		calculus
	///		
	///	nomenclature:
	///		instance of type =>
	///			tuples => op => calc => var => expr => func
	///		
	/// </remarks>
	///
	//[Obsolete(nameof(nilnul.obj.expr_.ICalc))]
	public interface ICalc
	{
	}

	/// <summary>
	///
	/// </summary>
	/// <typeparam name="T"> the result's type</typeparam>
	public interface ICalc<out T>:ICalc { }
}
