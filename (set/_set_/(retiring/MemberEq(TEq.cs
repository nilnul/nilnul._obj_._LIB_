using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	/// <summary>
	/// the Comparer of HashSet<typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	/// <remarks>
	/// elEq, for equality of element, is reserved for use in nilnul.set.Familty;
	/// there, element means smallest constituent, and ElEq is the equality of element, which is the member of the set (the set in turn is the member of family). In other words, element is the member of member of family.
	/// member means biggest constituent part of the whole, smaller  than only the whole
	/// </remarks>
	public interface MemberEqI<out T, out TEq>
		where TEq:IEqualityComparer<T>
	{
		TEq memberEq { get; }

	}

	public interface MemberEqI< T>
		:MemberEqI<T,IEqualityComparer<T>>

	{ }

	public abstract class MemberEqA<T>
		:
		nilnul.obj.Box_pub<IEqualityComparer<T>>
		,
		MemberEqI<T>
	{
		public MemberEqA(IEqualityComparer<T> val) : base(val)
		{
		}

		public IEqualityComparer<T> memberEq => this.boxed;
	}
}
