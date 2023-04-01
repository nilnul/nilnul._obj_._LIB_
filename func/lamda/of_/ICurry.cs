namespace nilnul.obj.func.lamda.of_
{
	/// <summary>
	/// convert a func to a lamda;
	/// eg:
	///		(x,y) =>x+y
	///		would be curried as:
	///		x => y => ()=>x+y
	///		note the difference with <see cref="func.op_.unary_.IProvision"/>
	/// </summary>
	public interface ICurry { }

}
