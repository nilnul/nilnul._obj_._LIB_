using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// we need to study the op with a collection of instances 
	/// <summary>
	/// if we regard each object as special <see cref="obj.op_.INary"/>, then this is about the relation|transformatin of ops.
	/// (note, we are talking about instances of a type, not members of a set. So the collection is not constraint to a finite set.)
	/// </summary>
	/// <remarks>
	/// we generally require the collection to be nonempty;
	/// </remarks>
	/// alias:
	///		abgebra
	///			,abstract algebra
	///			,"ab" indicating it's about basic elements
	///			, to differentiate from algebra, which might mean expressions with variables traditionaly, or concrete algebra, an algebra that's not abstract algebra;
	///			,pronuncible
	///			
	///		calculus
	///		algebra
	///		struc
	///		structure
	///		struct
	///		
	public interface IAbgebra
	{

	}

	/// <summary>
	/// the element is of type <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IAbgebra<T>:IAbgebra { }
}
