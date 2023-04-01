namespace nilnul.obj
{
	/// <summary>
	/// parameter is a "in" par, but also inherit Bei<typeparamref name="T"/>
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public interface BeI1<in T>:BeI<T>
	{

	}

	//public abstract class BeA< T>:BeI1<T>
	//{

	//}
}
