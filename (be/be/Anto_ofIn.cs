namespace nilnul.obj.be
{
	public class Anto_ofIn<T>
	:

		BeI_ofIn<T>


	{
		private nilnul.obj.BeI_ofIn<T> _be;

		public nilnul.obj.BeI_ofIn<T> beField
		{
			get { return _be; }
			set { _be = value; }
		}


		public Anto_ofIn(nilnul.obj.BeI_ofIn<T> be)
		{
			_be = be;

		}
		public bool be(in T obj)
		{
			return !_be.be(in obj);

			//throw new NotImplementedException();
		}
	}
}
