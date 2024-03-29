﻿namespace nilnul._obj.typ_
{
	/*
	 The unit type is a normal value type with exactly one value. Think of it that way: a variable of the type byte can have potentially 256 different values, a variable of the type bool can have two values and a variable of the type unit has (always the same) one value. If you return Unit.Default you do not return nothing but a value, which happened to always be the same.
	 the JIT treats ValueTuple (and any other "empty" struct) as 1-byte.

The unit type is only useful if something like the following would be possible:

Task<unit> task = Task.Run(() => Unit.Default);
var result = await task;
return result;

	So if you know the type, you know the instance; The returned value can be known in compiling-time. Note here it still returns a value, not returns no value.
	 */

	/// <summary>
	/// the class and the instance can be regarded as unascertainable; the <see cref="ITyp"/> has only one inst;
	/// some parameterized|generized types would degress from <see cref="IMultison"/>
	/// in f#, this type is called unit; which is considered nilard/nilaryTuple
	/// </summary>
	/// <remarks>
	/// one and only one instance exists for the type;
	/// the typ is also an instance;
	/// take the instance as type;
	/// </remarks>
	/// <see cref="nilable_.unprimable_.ISingulable"/>
	/// <see cref="Pointer"/>
	/// vs:
	///		sealed
	///			in fact this is sealed in the sense that it cannot be more specific by a subtype;
	/// alias:
	///		unison
	///			the type and the instance are in unison, as union struct type;
	///			same leading as unit;
	///		unit
	///			as in theory or functional programming;
	///		unial
	///		unard
	///		uniton
	///		union
	///		singleton
	///		instance
	///		inst
	///		instant
	///		instantiated
	///		incarnation
	///		void
	///		vod
	///		vnit
	///		eg
	///			when this is used in namespace, this would be "eg_", to express the following types are all unision 
	/// 
	public interface IUnison { }
}
