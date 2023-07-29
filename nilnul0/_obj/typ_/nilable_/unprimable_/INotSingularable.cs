using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.nilable_.unprimable_
{
	/// <summary>
	/// the type has a parameterless ctor , and the instances it created are same initially. But the instance can change its state overtime
	///		(
	///			by itself,
	///			or by outside act like numQuotient.CreateOne() where inner bigInt as numerator can be changed
	///		)
	///	,
	///	so after some time, instances have various states.
	///
	/// eg:
	///		nilnul.bit.stream_.slider_.Alt
	///			the current values of the slider is not the same across different instances.
	/// </summary>
	/// <remarks>
	/// when inherited, act as a reminder that this cannot be taken as singleton.
	/// alias:
	///		nonsinglable
	///		notSinglable
	///		stateless
	///			not only uprimable(initial state), but also statelss in later stage of lifecycle;
	/// </remarks>
	public interface INotSingularable
	{
	}
}
