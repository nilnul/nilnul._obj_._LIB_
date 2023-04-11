namespace nilnul
{
	/*
	 eg:
		hashed indexed objects.
			the order of which is not pre-arranged, nore predictable.
			there might be repeated ones.
	 */
	/// We, the coder, is also very puzzled in whether define this as a str of things, or as just things with unknown/messy/hash structure.
	/// It seems attrative that we define this as a subtype of obj.Str, as pointed out by 3brown1blue: you have to define order first before you can ignore it.
	/// But let's put the buffle aside, before we can solve it: Define this as different from obj.str
	/// <summary>
	/// things with unknown/messy/hash structure|scope; without scope, we can list the things like a,b,c, without enclosing ()[]{}《》， etc；
	/// </summary>
	/// <remarks>
	/// 	 this is not str, as the order is not guaranteed. This is a str without undefined/deterministic order; there might be order, or might be without order. eg: table in a database.
	/// 	 this is not set, as multiple elements might recur. eg: in a table from Database
	/// 	 this is not multi-set, as the order, not guranteed as it is, might make difference.
	/// 	 This is the "a,b,c" in set {a,b,c} , in str [a,b,c], in sortie ⟨ a,b,c ⟩, withoug the enclosing fences.
	/// 
	/// </remarks>
	/// imaging things litter on the floor, we don't know what's missed that might be somewhere else;
	/// 
	/// also we don;t know the order; but by Axiom of Choice (which is expected to apply to sets, but we here also apply it on this), we can choose one by one and establish order; So <see cref="nilnul.obj.IStr"/> is the default implementation of this; so later in consuming project that consumes the idea of this project, we might use Typs to represent Typ.Str in order to save some words;
	public interface IObjs
		:obj.IStr
	{

	}






}
