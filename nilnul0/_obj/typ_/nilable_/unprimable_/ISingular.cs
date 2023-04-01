using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.nilable_.unprimable_
{
	/// <summary>
	/// the inner state of the obj is immutable.
	/// becuz the state is readonly, so it's thread safe.
	/// eg:
	///		nilnul.bit.op_.binary_.And
	///	counter eg:
	///		nilnul.bit.stream_.slider_.Alt
	///			two instances might vary later, even they are the same initially.
	///		Slider is not defaultable , as when sliding, the state of it is changing.
	///		When you create two copies of slider, they may be at different states.
	/// </summary>
	/// <remarks>
	/// a type is called singleton, if the type can create one and only one instance.
	/// inheriting this type doesnot make the child type a singleton, as inherited type decorates the instance (any instances created,possibly many), not the type. So this marker is only a marker to tip programmers, not typesafe.
	///		To solve this, there must be mechanisms to constrain the type. Generic parameter may be the way to go; <seealso cref="nameof(Singleton{YourClass})"/>; but the generic type cannot inherit the type parameter, so implicit type conversion may be utilized. 
	/// </remarks>
	///  alias:
	///		defautable
	///		stateless
	///	application:
	///		<see cref="nilnul.obj.op_.unary.IRecur"/> might be <see cref="IUnprimable"/>, but not defaultable.As <see cref="obj.op_.unary.recur.Slider{TRecur, T, TOp}"/> is stateful.
	///	<see cref="_obj.typ_.IUnison"/>	

	public interface  ISingulable
	{
	}
}
