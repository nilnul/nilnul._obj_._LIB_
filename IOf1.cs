namespace nilnul.obj
{
	/*
/// T -> T.
///		for P1 --> P2, where P1 and P2 share the ancester of P, it is still an Op(P)
///  T -> P is
///		op, if P = T
///		
///		fro if P is sub type of T
///		proper fro if P is proper subType of T
///		
///		to if P is a supertype of T
///		proper to if P is a proper supertype of T
///		
///		restrict if P is depended by T (T is extension of P)
///		extend if P is dependent on T
///		
///		convert if P and T is mutual dependent.

 */
	/// <summary>
	/// the returned is of type "T"
	/// geometric visually an opposite of "to", "of" means construct one type from another.
	/// </summary>
	/// <remarks>
	/// <seealso cref="nameof(ToI)"/>
	/// In "Of", instead of subtyping <see cref="nameof(nilnul.IObj)"/>, we can create no type which requires verification by throw exception for invalid arguments, rather we can use static method with "_assumeing" to assume the argument must satisfy some conditions.
	/// </remarks>
	/// alias:
	///		<see cref="obj.IConstructor"/> or ICtor
	///		create <see cref="obj.ICreate"/>
	///		
	///		
	//[Obsolete("should be in namespace: "+ nameof(nilnul.obj.op_))]
	public interface IOf
		//:
		//op_.IOf
	//,
	//IOp<object>
	//,
	//_of.IAsTgt<object>
	//,
	//nilnul.obj.op_.IOf
	{

	}

	/// <summary>
	/// not (nary|nonary); but only specify the return type. the input is not defined here.
	/// </summary>
	/// <typeparam name="T"> the returned type</typeparam>
	public interface IOf1<out T>
		:
		IOf
		//,
		//nilnul.obj.IOp<T>
	{

	}


	

}
