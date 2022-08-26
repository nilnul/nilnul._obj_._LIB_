using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._var;
using Var11 = nilnul.obj._var.VarI_dynamicTyped;

namespace nilnul.obj.var.set
{
	public partial class Ordered
		:IEnumerable<Var11>
	{


		HashSet<_var.VarI_dynamicTyped> _set=new HashSet<_var.VarI_dynamicTyped>();
		List<_var.VarI_dynamicTyped> _list=new List<_var.VarI_dynamicTyped>();

		public Ordered()
		{

		}

		public Ordered(params VarI_dynamicTyped[] vars)
			:this(vars as IEnumerable<Var11>)
		{

		}

		public Ordered(Ordered ordered) :this(ordered as IEnumerable<Var11>){
			
		}

		static public Ordered TruncateLast(Ordered ordered ) {

			return new Ordered( ordered.Take(ordered.Count()-1));

		}

		static public Ordered Rename(Ordered ordered,  _var.VarI_dynamicTyped var, _var.VarI_dynamicTyped varNew)
		{
			if (ordered._set.Contains(var) )
			{
				if (ordered._set.Contains(varNew))
				{
					throw new Exception(string.Format("{0} already exists in {1}", varNew, ordered));
					ordered._set.Remove(var);
					ordered._list.Remove(varNew);
				}

				else
				{
					ordered._set.Remove(var);
					ordered._set.Add(varNew);
					var index= ordered._list.IndexOf(var);
					ordered._list.Remove(var);
					ordered._list.Insert(index,varNew);
				}


			}
			return ordered;

			throw new NotImplementedException();
		}


		public Ordered(IEnumerable<Var11> vars)
		{
			foreach (var item in vars)
			{
				var added = _set.Add(item);
				if (added)
				{
					_list.Add(item);
				}
			}

		}
		public Ordered(Var11 var)
		{
			append(var);

		}

		public override string ToString()
		{
			return string.Join(
					",", 
					_list.Select(
						x => NamingContextX.ToTxt(x)
					)
				);
		}

		public Ordered toDehead() {
			if (_set.Count==0)
			{
				return new Ordered();
			}

			return new Ordered(
				this._list.Skip(1)	
			);
		}
		public void prepend( Var11 var) {
			if (_set.Contains(var))
			{
				throw new ElementAlreadyExistsException("Element already exists.");
			}

			_set.Add(var);
			_list.Insert(0,var);
		}


		public void append( Var11 var) {
			if (_set.Contains(var))
			{
				throw new ElementAlreadyExistsException("Element already exists.");
			}

			_set.Add(var);
			_list.Add(var);
		}

		public void appendNew( Type type) {
			append(new _var.Var_dynamicTyped(type));
		}

	public void append(IEnumerable<Var11> vars) {
			vars.ForEach(x => append(x));
		}

		static public Ordered AppendNew(Ordered vars,Type type) {
			var r = new Ordered(vars);
			r.appendNew(type);
			return r;
		}


		public void remove(Var11 var) {
			_set.Remove(var);
			_list.Remove(var);
		}

		public void remove(IEnumerable<Var11> vars) {
			vars.ForEach(x => remove(x));
		}

		public IEnumerator<Var11> GetEnumerator()
		{
			return _list.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}

		[Serializable]
		public class ElementAlreadyExistsException : Exception
		{
			public ElementAlreadyExistsException() { }
			public ElementAlreadyExistsException(string message) : base(message) { }
			public ElementAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
			protected ElementAlreadyExistsException(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context) : base(info, context)
			{ }
		}

	}
}
