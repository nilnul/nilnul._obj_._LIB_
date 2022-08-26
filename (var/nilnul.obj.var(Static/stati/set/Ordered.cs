using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._var;
using Var11 = nilnul.obj.var.StatiI;

namespace nilnul.obj.var.stati.set
{
	public partial class Ordered
		:IEnumerable<Var11>
	{


		HashSet<Var11> _set=new HashSet<Var11>();
		List<Var11> _list=new List<Var11>();

		public Ordered()
		{

		}

		public Ordered(params Var11[] vars)
			:this(vars as IEnumerable<Var11>)
		{

		}

		public Ordered(Ordered ordered) :this(ordered as IEnumerable<Var11>){
			
		}

		static public Ordered TruncateLast(Ordered ordered ) {

			return new Ordered( ordered.Take(ordered.Count()-1));

		}

		static public Ordered Rename(Ordered ordered,  Var11 var, Var11 varNew)
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
						x =>  NamingContextX3.ToTxt(x)
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

		public void appendNew<T>( ) {
			append(new Stati<T>());
		}

	public void append(IEnumerable<Var11> vars) {
			vars.ForEach(x => append(x));
		}

		static public Ordered AppendNew<T>(Ordered vars) {
			var r = new Ordered(vars);
			r.appendNew<T>();
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
