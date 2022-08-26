using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.calc_.unary_.alias_
{
	/// <summary>
	/// to inherit this, to make it obvious that the inheriter is synonym to a subtype.
	/// This means <typeparamref name="TSup"/> is alias to <typeparamref name="TSub"/>. <seealso cref="nameof(typ.child.calc_.unary_.IAlias{TSup,TSub})"/>, where it means the subtype is equiv to the sup type. 
	/// </summary>
	/// <typeparam name="TSub"></typeparam>
	/// <typeparam name="TSup"> the inheriter. </typeparam>
	/// <remarks>
	/// </remarks>
	public interface IOvSub<TSub,TSup>
		:IAlias<TSub>
		where TSub:TSup
	{

	}
	
}
