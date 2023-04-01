namespace nilnul.obj
{
	/// <summary>
	/// for a <see cref="Iobj"/>	 with <see cref="obj.IComp"/>, a bound is two border which enclose at least one obj;
	/// to allow empty, <see cref="obj.border.co"/>
	/// </summary>
	public interface IBound:range_.dwelt_.INondecrease { }

	public interface IBound<T> : IBound,IRange<T> { }

}
