using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_
{
	/// <summary>
	/// having a parameterless ctor. a default instance can be created.
	/// </summary>
	/// <remarks>
	///	alias:
	///		newable
	///			re: the "new" constraint in "where" clause of generic type.
	///				note in where constraint, it's "new()", where there is not just "new", but also "()" to specify that it's nary,
	///		defaultable
	///			for example,
	///				we can phase datetime as:
	///					220101595857_007
	///						where "_" is the end of seconds, and begin of split seconds.
	///					but "_" can also be "", "s", "S", where "s" is the default (if no par is given, "s" is provided.)
	///		scratchable
	///			construct from scratch
	///		initable
	///		parlessable
	///		nilable
	///			no inputs required
	///				like the "0", first natural number
	///					base on 0, we get one; and based on one, we get two.
	///			nable,
	///				the input tuple is 0-nary ( or just nary)
	///			sounds like newable
	///		parameterless
	///		nonparameterized
	///
	/// the type can have a default implementation subtype, which contains the parameterless ctor. (the type can have nondefault implementation subtype, which has a parameterless ctor inheriting the parameterized ctor of this type.)
	/// </remarks>
	/// vs:
	///		<see cref="IUnison"/>, whileas this means it has a parless ctor, doesnot mean this is a <see cref="IUnison"/>; <see cref="nilable_.IUnprimable"/> means it doesnot have other ctor than the parless ctor, but doesnot mean it is a <see cref="IUnison"/> as we can see an example of <see cref="nilnul.obj.IStream"/> which can have state of where the current is; <see cref="nilable_.unprimable_.ISingulable"/> is a synonym of this;
	public interface INilable
	{
	}
}
