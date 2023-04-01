namespace nilnul.obj.border
{
	/// <summary>
	/// </summary>
	public interface ICo { }

	/// <summary>
	/// </summary>
	/// <typeparam name="TObj"></typeparam>
	public interface ICo<TObj> : ICo { }

	/// <summary>
	/// </summary>
	/// <typeparam name="TObj"></typeparam>
	public interface ICo<TObj,TBorder>
		: ICo<TObj>
		
	{ }
}
