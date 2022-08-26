using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._eq_
{
	/*Sets versus classes
Certain mathematical "relations", such as "equal to", "member of", and "subset of", cannot be understood to be binary relations as defined above, because their domains and codomains cannot be taken to be sets in the usual systems of axiomatic set theory. For example, if we try to model the general concept of "equality" as a binary relation =, we must take the domain and codomain to be the "class of all sets", which is not a set in the usual set theory.

In most mathematical contexts, references to the relations of equality, membership and subset are harmless because they can be understood implicitly to be restricted to some set in the context. The usual work-around to this problem is to select a "large enough" set A, that contains all the objects of interest, and work with the restriction =A instead of =. Similarly, the "subset of" relation ⊆ needs to be restricted to have domain and codomain P(A) (the power set of a specific set A): the resulting set relation can be denoted ⊆A. Also, the "member of" relation needs to be restricted to have domain A and codomain P(A) to obtain a binary relation ∈A that is a set. Bertrand Russell has shown that assuming ∈ to be defined on all sets leads to a contradiction in naive set theory.

Another solution to this problem is to use a set theory with proper classes, such as NBG or Morse–Kelley set theory, and allow the domain and codomain (and so the graph) to be proper classes: in such a theory, equality, membership, and subset are binary relations without special comment. (A minor modification needs to be made to the concept of the ordered triple (X, Y, G), as normally a proper class cannot be a member of an ordered tuple; or of course one can identify the function with its graph in this context.)[26] With this definition one can for instance define a function relation between every set and its power set.*/
	public interface BlankI
	{
	}
}
