using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{
	/// <summary>
	/// both <see cref="_nilard.semi_.ILeftNilard"/> and <see cref="_nilard.semi_.IRightNilard"/>
	///
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// </remarks>
	/// annihilator 
	public interface NilardableI<T>
		:nilnul.obj.op_.binary.cumulator.Be_cumulatorGeneriI<T>
		,
		INardable
	{
	}
}
