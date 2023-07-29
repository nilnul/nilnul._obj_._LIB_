using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	public partial class TypeComparerX
	{
		static public bool IsSuperType<T,T1>(obj.VarI3<T> x, obj.VarI3<T1> y) { 

			return ( typeof(T) ).IsAssignableFrom( typeof(T1) ) ;
			
		}
		static public bool IsSuperType(obj.VarI1 x, obj.VarI1 y) {




			if (
				x.GetType().GetGenericTypeDefinition() == typeof(obj.VarI3<>) 
				&& 
				y.GetType().GetGenericTypeDefinition() == typeof(obj.VarI3<>)
			) { 
			
				var type=typeof(TypeComparerX);

				var methodInfo = type.GetMethod("IsSuperType", new[]{ typeof(obj.VarI3<>) ,typeof(obj.VarI3<>) } );		//if this doesn't work, try getMethods, or rename the specified method to a unique name before using GetMethod

				var closedMethodInfo = methodInfo.MakeGenericMethod(
					x.GetType().GetGenericArguments()[0]
					,
					y.GetType().GetGenericArguments()[0]
				);

				return (bool)( closedMethodInfo.Invoke(null, new[]{ x, y}) );	

			};

			throw new NotImplementedException();
			;
			
		}

		static public bool IsSubType<T, T1>(
			obj.Var3<T> x,
			obj.Var3<T1> y
			
		) {
			return IsSuperType(y, x);
		
		}
		static public bool IsSubType(
			obj.VarI1 x,
			obj.VarI1 y
			
		) {
			return IsSuperType(y, x);
		
		}

		static public bool IsNotSubType(
			obj.VarI1 x,
			obj.VarI1 y
			
		) {
			return !IsSubType(x, y);
		
		}

	static public bool IsSameType<T, T1>(
			obj.Var3<T> x,
			obj.Var3<T1> y

		) { 
					return IsSuperType(x, y) && IsSubType(x,y);

		}
	}
}
