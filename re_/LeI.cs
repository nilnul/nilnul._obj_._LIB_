using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{
	/// <summary>
	/// a partial order. might be nontotal.
	/// If this is definitely total, <see cref="nameof(obj.IComp)"/>
	/// cannonical form of sub: left is no more than right. all sub relation among a set is called PartialOrd.
	/// Eq can be derived from le, as is from comparer. Deriving Eq will make eq and le consistent.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// <see cref="nilnul.rel_.net_.Poset"/>
	/// </remarks>
	/// 
	public interface LeI<T>:ReI<T>
	{
	}
}
