using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{

	
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	/// the val of the var must be of this type.
	/// </typeparam>
	/// <see cref="expr_.typed_.generi_.IVar{T}"/>
	/// <see cref="_var.ITyped"/>
	/// <see cref="expr_.var_.ITyped"/>
	///
	[Obsolete(nameof(expr_.typed_.generi_.IVar<T>))]
	public interface IVar<T>:IVar {

	}

}
