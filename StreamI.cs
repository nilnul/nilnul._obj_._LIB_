using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// vs <see cref="nameof(IEnumerable{T})"/>, no check of MoveNext() is needed. always movable to next.
	/// <see cref="nameof(IEnumerable{T})"/> uses "GetEnumerator()" to implement a subtype "slider" of Stream.
	/// </summary>
	public interface IStream
		:ISeq
	{


	}
	public interface StreamI_blank :IStream
	{
	}

	public interface IStream<out T> {

	}

	public interface StreamI_blank_ofEl<out T> : StreamI_blank,IStream< T> {

 }
}
