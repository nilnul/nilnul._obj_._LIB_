using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse.cumulator
{
	/// <summary>
	/// imaging the 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Cumulate<T> :
		op_.binary.cumulator.Cumulate<T>
		,
		binary.cumulator._cumulate_.OfSeq<T>     ///the difference with <see cref="Cumulate{T}"/> is in the body of the method, not the interface. So they share the same interface, but with different implementations; and the implementations have to be in the class, not interface.
	{
		

		public Cumulate(T ini, BinaryI<T> op) : base(ini, new binary.Converse<T>(op) )
		{
		}




		

	}
}
