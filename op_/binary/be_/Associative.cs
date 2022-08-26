using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_
{
	/// <summary>
	/// 
	/// </summary>
	///

	public interface IAssociative
	{
	}
}
	/*
    some calls the
   		"="
   		in
   		var a=b=1;
   		right associative.
   	that's a misnominar.

   	Associative means what here defines:
   		semantically means xyz=x(yz).

   	the "=" in "var a=b=1;" is not in the semantical domain; in fact, in semantical domain, "var a=b=1;" is a tree and there is no ambiguity entailing the so called "right-associative" - it is not used nor needed.
   	It's only useful when in syntax world, parsing txt into a tree. So we will encounter the term not in semantical world before syntax parsing, but later when we in nilnul.lang_ to tackle the parsing back. There, we shall avoid the term "associative"; we shall call it something else, such as:
			precedence of position.

(
	precedence/priority is another syntax term, only coming to our attention later.
	when a + b * c, "*" and + have different priority. So we neednot consider the precedence/prepostence
	but in a*b/c, * and / have same priority. In this scenario, we need to evaluate the priority by taking into account of "position" potence.

)
	   */
