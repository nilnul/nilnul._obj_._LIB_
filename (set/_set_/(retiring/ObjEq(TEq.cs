using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	/// <summary>
	/// cuz this is named "nilnul.obj.Set", then the member is obj.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	///
	[Obsolete(nameof(MemberEqI<T>))]
	public interface ObjEqI<T, TEq>
		where TEq:IEqualityComparer<T>
	{
		TEq objEq { get; }


	}

	[Obsolete(nameof(MemberEqI<T>))]
	public interface ObjEqI<T>
		:ObjEqI<T,IEqualityComparer<T>>

	{ }

	[Obsolete(nameof(MemberEqI<T>))]
	public abstract class ObjEqA<T>
		:
		nilnul.obj.Box_pub<IEqualityComparer<T>>
		,
		ObjEqI<T>
	{
		public ObjEqA(IEqualityComparer<T> val) : base(val)
		{
		}

		public IEqualityComparer<T> objEq => this.boxed;
	}

	[Obsolete(nameof(MemberEqI<T>))]
	public class ObjEq_eqDefaulted<T, TEq>
		:
		ObjEqA<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public ObjEq_eqDefaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}
}
