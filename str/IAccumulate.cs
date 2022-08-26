using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	/// <summary>
	/// return <typeparamref name="T"/> from <see cref="obj.IStr{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// vs: <see cref="obj.AccumulateI{T}"/>, we prefer this as we have a rule: extension object shall be placed upon the input.
	///		as the input of <see cref="IAccumulate{T}"/> is <see cref="IStr{T}"/>, hence we shall place this upon the namespace of <see cref="str"/>
	public interface IAccumulate<T>
	{
	}
}
