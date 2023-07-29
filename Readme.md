# nilnul obj library
(codename: nilnul.\_obj_.\_LIB_)

This library treats everything as object, or "obj" for short. *obj* as the top type of everything type is the abstraction of common properties of all other underlying types. As the abstraction goes tier by tier deep, the abstracted common properties get tier by tier less; when the abstraction goes to the topmost *obj*, the remained properties definable for everything is almost empty, and that is why we often say what buddha says: everything is empty. Due to the emptiness, various instances wouldnot vary, so *obj* can also embody some characteristics of "singleton" type.

Every generic type is also the subtype of *obj*. So this library also defines some types in generic forms. *dynamic* type can also be taken as a subtype of *obj*, only that it's expandable as many other objects do.

# Core definitions

In this library we defined some types on the basis of the obj type. And this pattern can be then followed in later libraries where for a type, we can analoguely define a similar set of derived types.

For example:

- op:

	we defined operators on *obj*, including binary, unary, ternary operator as well *nary* operator, the arity of which is 0.
- some collective terms are explicitly and accurately defined. eg:
	- ordered collection of components
		- rec (short from record),  where the types of component may vary and the arity (count of components) varies;
		- str (short from string), where the types of component are same and the arity (count of components) varies. note str is a subtype of *rec*;
		- tup (short from tuple), where the types of component may vary and the arity (count of components) is set in advance. note tup is a subtype of *rec*, not *str*;
		- vec (short from vector), where the types of component are same and the arity (count of components) is set in advance. note vec is a subtype of *rec* and *str*;
		- 
	for mnemonics purpose, not the "rstv" are four consective letters, and the four forms a diamond shape with respect to subtype relation.

	- some other collective terms besides *str*, such as:
		- stream, like str, but infinite;
		- seq (short for sequence), which is a str or a stream;
		- set, where the order is disrespected, and the repeatedness is allowed but ignored; note here set is finite, for infinite collection, we would create new projects later, and treat it as *collection*, not *set*.
		- sortie, a distinct *str*, where the order is important, and no repetitiveness is allowed;
		
		recall that "str" is defined such that order is respected, and repetitiveness is allowed, we now have quite a few such closed related terms: str,stream,seq,set,sortie. For mnemonics, they all start with letter "s", which as an adfix means a lot of things. Among these *str* is the corner stone type,and a *set* is regarded as a *str* stripped of order and repetitiveness; or higher up to phylosophy, as put in 3brown1blue and other sources, you have to define an order before you strip it to get an unordered.
- be, which is a predicate for an object; *vow*, which is an assertion; *vow.ee*, which is an object passed the assertion. We often use these three together to furthe constrain a type, generating a new subtype. For nilnul systems, we pond on how we augment our library to include new types, and we find there are a few ways:
	- extension, like (int,string) is a new type extended on int type and string type
	- constriction, like the constrains applied in our aforementioned "be, vow, ee" portfolio;
By applying this portfolio repeatedly, we systematically formalize the process of defining new types in current or new libraries.
- abgebra, which is a play of words *ab*stract al*gebra*, meaning a calcus on *op*s, including *nary op*s which is obj in *op* world. For abgebra, some names might mean different things in different literature; here we attemp to remove that ambiguity such that when applied in our library, same jargon means unambiguously.
- *_obj.typ*, where "typ", short for type (we use short names, especially in namespace to avoid confliction with system or other libraries) is regarded, as it should be, the apriori concept for an obj, so we put under the namespace segment "\_obj" where prefix "_" in nilnul means some prerequisites.
	- under *\_obj.typ*, we defined *Unison*, commonly referred to as *Singleton* types, and *Xpn*(short for exception) for the theoretical bottom type, which is a type of no instances;
- we also attempt to define some types that are common for many entities; eg:
	- expr, an expression involving variables; *calc*, a calculation involving literal values only without any variables;
	- betwixt, something like an interval, but unorientated (directionless); and *bound*, like *betwixt*, but orientated;


# Development
This library is being actively development and is used in almost every nilnul project;

The coding style in this project as well other nilnul project embodies a uniform nilnul coding style, where type name is Capitalized while namespace, often an abbreviation from a type, is camelCased, not Capitalized; 

The unit testing project "nilnul.\_obj_.\_TEST_" is placed in a separate repo; the unit test project references this project using raw source code reference, and it shall be placed under the same parent folder as this project is.

The testing so far is being incremented to order to cover all codepaths; before that, the version of the compiled package of this lib is appended "-sym" and pushed to *nuget.org*. Be sure to include prerelease to search for this package.

Participation in this development process is always welcome.




