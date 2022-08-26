using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_;
using nilnul.obj.str_;

namespace nilnul.obj.str_.seq_.started
{

	static public class _FoldX
	{
		static public T Fold<T>(this nilnul.obj.str_.seq_.Started<T> started,nilnul.obj.op_.BinaryI<T> op )
		{
			return nilnul.obj.str_.seq._FoldX.Fold(started.tail, started.head, op);
		}

	}
	/// <summary>
	/// convert a str to an element
	/// </summary>
	/// 
	public interface FoldI<T> : _fold_.Fold_ofEl<T>
	{

	}

	public class Fold<T> :
		nilnul.obj.Box<
		nilnul.obj.op_.BinaryI<T>
			>
		,

		FoldI<T>
	{
		public Fold(BinaryI<T> val) : base(val)
		{
		}

		public T fold(Started<T> x)
		{
			return _FoldX.Fold(x,this.boxed);
		}
	}



}