using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary._cumulator_
{
	/// <summary>
	/// nucleation;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		nucleid
	///		seed
	///		catapult
	public interface InitialI<out T>
	{
		T initial { get; }
	}
	


}
