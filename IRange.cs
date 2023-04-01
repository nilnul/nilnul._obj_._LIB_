using System.Linq;

namespace nilnul.obj
{
	/// <summary>
	/// from lower to uppler like <see cref="BoundI{TBorder}"/>, or from upper to lower like a bound with the opposit comparer.
	/// 
	/// </summary>
	/// <remarks>
	/// a bound upon comp, or <see cref="obj.comp.Converse{T}"/>;
	/// note:
	///		this is not to express a <see cref="bound_.ICLosed"/>
	///	this can be empty, used in programming loops;
	///	this is making <see cref="obj._bound.border"/>
	/// </remarks>
	/// alias:
	///		range
	///			like we program using a loop like:
	///				for (var i=3;i--;i ge|gt 0) {}
	///			or Enumerable.Range(1,5)
	///			"r"everse
	///		tween
	///		scope
	///		
	public interface IRange {
		
	}
	public interface IRange<T>:IRange
	{

	}


}