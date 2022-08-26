using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.each_._break
{

	/*
	 stackoverflow.com/questions/58531435/early-exit-from-calling-code-when-using-yield-return-on-a-generic-ienumerable

You see, while using foreach() to iterate resulting IEnumerable, you're safe. The Enumerator below implements IDisposable itself, which gets called in case of foreach (even if loop is exited with break) and takes care of cleaning the state of your in GetFileData.

But if you will play with Enumerator.MoveNext directly, you're in trouble and Dispose will never be called if exited earlier (of course, if you'll complete manual iteration, it will be).For manual Enumerator-based iteration, you can consider placing enumerator in using statement as well (as mentioned in code below).

	// Dispose will not be called
    var enumerator = GetEnumerable().GetEnumerator();
    // But if enumerator and this logic is placed inside the "using" block,
    // like this: using(var enumerator = GetEnumerable().GetEnumerable(){}), it will be.
    while(enumerator.MoveNext())
    {
        Console.WriteLine(enumerator.Current);
        break;
    }

    Console.WriteLine("{0}Here we'll see dispose on completion of manual enumeration.{0}", Environment.NewLine);

    // Dispose will be called: ended enumeration
    var enumerator2 = GetEnumerable().GetEnumerator();
    while (enumerator2.MoveNext())
    {
        Console.WriteLine(enumerator2.Current);                
    }


	Originally observed by: https://blogs.msdn.microsoft.com/dancre/2008/03/15/yield-and-usings-your-dispose-may-not-be-called/
Author calls this (the fact that manual MoveNext() and early break will not trigger Dipose()) "a bug", but this is intended implementation.
	 */

	/*
	 in short: if you don't use foreach, and use your own movenext, you have to dispose the disposable yourself.
	 */
}
