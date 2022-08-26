using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/*
	 * https://en.wikipedia.org/wiki/Closure_(computer_programming)
	Here is the same example rewritten in JavaScript, another popular language with support for closures:

// Return a list of all books with at least 'threshold' copies sold.
function bestSellingBooks(threshold) {
  return bookList.filter(
      function (book) { return book.sales >= threshold; }
    );
}
The function keyword is used here instead of lambda, and an Array.filter method[8] instead of a global filter function, but otherwise the structure and the effect of the code are the same.

A function may create a closure and return it, as in the following example:

// Return a function that approximates the derivative of f
// using an interval of dx, which should be appropriately small.
function derivative(f, dx) {
  return function (x) {
    return (f(x + dx) - f(x)) / dx;
  };
}
Because the closure in this case outlives the execution of the function that creates it, the variables f and dx live on after the function derivative returns, even though execution has left their scope and they are no longer visible. In languages without closures, the lifetime of an automatic local variable coincides with the execution of the stack frame where that variable is declared. In languages with closures, variables must continue to exist as long as any existing closures have references to them. This is most commonly implemented using some form of garbage collection. 
A language implementation cannot easily support full closures if its run-time memory model allocates all automatic variables on a linear stack. In such languages, a function's automatic local variables are deallocated when the function returns. However, a closure requires that the free variables it references survive the enclosing function's execution. Therefore, those variables must be allocated so that they persist until no longer needed, typically via heap allocation, rather than on the stack, and their lifetime must be managed so they survive until all closures referencing them are no longer in use.

	This explains why, typically, languages that natively support closures also use garbage collection. The alternatives are manual memory management of non-local variables (explicitly allocating on the heap and freeing when done)*/

	/// <summary>
	/// nilnul term for class: functions with a set of variable/state
	///A closure can be used to associate a function with a set of "private" variables, which persist over several invocations of the function. The scope of the variable encompasses only the closed-over function, so it cannot be accessed from other program code. These are analogous to private variables in object-oriented programming, and in fact closures are analogous to a type of object, specifically function objects, with a single public method (function call), and possibly many private variables (the closed-over variables).
	///  no longer pure functions;
	/// In a managed, garbage collected environment, a closure records references to the frames from which values may be obtained.
	///
	/// In contrast a lifted function has parameters for each value needed in the calculation.
	/// </summary>
	/// <remarks>
	/// the captured is the container, not the content. Thus the content can change at different calls of the same func.
	///
	/// alias:
	///		closure
	///			same ending with "procedure"
	///	
	/// </remarks>
	/// <seealso cref="nameof(monad_)"/>
	public interface IClosure
	{
	}
}
