using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.procedure.func
{
	/*
	The following is the same example, this time written in JavaScript:

// Initial version

function sum(n) {
    function f(x) {
        return n + x;
    }

    if (n == 1)
        return 1;
    else
        return f(sum(n - 1));
}

// After converting the free variable n to a formal parameter w

function sum(n) {
    function f(w, x) {
        return w + x;
    }

    if (n == 1)
        return 1;
    else
        return f(n, sum(n - 1));
}

// After lifting function f into the global scope

function f(w, x) {
    return w + x;
}

function sum(n) {
    if (n == 1)
        return 1;
    else
        return f(n, sum(n - 1));
}

	The following algorithm is one way to lambda-lift an arbitrary program in a language which doesn't support closures as first-class objects:

Rename the functions so that each function has a unique name.
Replace each free variable with an additional argument to the enclosing function, and pass that argument to every use of the function.
Replace every local function definition that has no free variables with an identical global function.
Repeat steps 2 and 3 until all free variables and local functions are eliminated.
If the language has closures as first-class objects that can be passed as arguments or returned from other functions, the closure will need to be represented by a data structure that captures the bindings of the free variables.
	 */
	/// <summary>
	/// 
	/// </summary>
	public interface ILift
	{
	}
}
