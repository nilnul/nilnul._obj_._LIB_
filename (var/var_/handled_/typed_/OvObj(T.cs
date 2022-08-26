using nilnul.obj.var_._handled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var_.handled_.typed_
{
	public interface OvObjI<T>
	   :

	   handled_.TypedI
		,
		nilnul.obj.VarI6<T>

	{

	}
	public class OvObj<T>
	   :

		handled_.Typed
	   ,
	   handled_.TypedI
		,
		nilnul.obj.VarI6<T>


	{
		protected OvObj(Handle val) : base(val, typeof(T))
		{
		}
		public OvObj():this(new Handle())
		{

		}

		static public OvObj<T> Ov<TFro>(OvObj<TFro> ovObj)
			where TFro : T
		{
			return new OvObj<T>(ovObj.handle);
		}
		
	}

}
