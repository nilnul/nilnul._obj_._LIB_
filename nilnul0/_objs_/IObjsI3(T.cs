using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// obj.Str. eg: 
	///		1,2,3
	/// </summary>
	/// <remarks>
	/// why objs is denoting obj.Str, not obj.Set, or obj.Bag, or obj.Sortie?
	///		obj.Str is the basis to form obj.Set, obj.Sortie, etc (obj.Str can express Set if we ignore the repetitiveness, or express Sortie if it's distinct, or express Bag/MultiSet if we take into consideration of subsequent occurances of an element after it's first occurance), justifying that we use objs to denote it.
	/// 
	/// vs other structure:
	///		to enwrap it with "{}", we get a set
	///		to enwrap it with "&lt; &gt;", we a sortie, which is a sorted set.
	///			
	///		"()" is reserved to group (things, including objs)
	/// 
	///
	/// vs obj.Str
	///		obj.str has order, whileas objs's order is undefined (it may lack order, so "a,b,c" and "b,a,c", though different as strS, might be same as objs.)
	///		But the above difference is conceptual, and is hard to reified into code.
	///		In code, to enwrap it with "[]", we get a str, which has an order that's intrinisic location based thus solely for being uniquely by being physically. The "[]" is not necessary as Objs is alias to obj.Str
	///		sometimes we enwrap it with "()".
	///		without wraping parenthesis, "1,2,3,2" is defaulted to be a str. If it is regarded as a set, the repeated items need to be leaned as one; if it's regarded as a sortie, it may fail; if it's regarded as str, nothing need to alter. so the enwrapping "[]" is ommitable; objs is another way to express obj.str.
	/// 
	/// 
	/// </remarks>
	public interface IObjs
	{

	}

	public interface IObjs<out T> : IObjs
	{

	}






}
