namespace nilnul.obj.var_
{
	/// <summary>
	/// a val with an alias name;
	/// eg:
	///		var a=1; //where a is a <see cref="obj.var_.IVal"/>, whileas "1" is val, not var.
	/// </summary>
	/// <remarks>
	/// in expr we can use both <see cref="IObj"/> or <see cref="IVar"/>; eg:
	///		var a=1;var b=new object();
	///		1+a+b  //the expr;
	/// </remarks>
	internal class IVal:IObj
	{
	}


}
