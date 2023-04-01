namespace nilnul.obj
{
	/// <summary>
	/// unique id
	/// make the id longer such that no conflicts happen probabilitistically
	/// </summary>
	/// <remarks>
	/// if we want to compress/convert/embed/use <see cref="IIdenty"/> where <see cref="IId"/> is required due to, say, special characters forbidden, we can convert <see cref="IIdenty"/> to this following some encoding.
	/// </remarks>
	/// 
	interface IUid { }

}
