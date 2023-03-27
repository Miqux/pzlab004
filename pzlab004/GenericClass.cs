using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzlab004
{
    public class GenericClass<T,U,I,O> : IComparable<GenericClass<T, U, I, O>> where T : IComparable<T>
    {
		private T value1;

		public T Value1
        {
			get { return value1; }
			set { value1 = value; }
		}
		private U value2;

		public U Value2
		{
			get { return value2; }
			set { value2 = value; }
		}
		private I value3;

		public I Value3
		{
			get { return value3; }
			set { value3 = value; }
		}
		private O value4;

		public O Value4
		{
			get { return value4; }
			set { value4 = value; }
		}
		public GenericClass() { }

		public GenericClass(T temp1, U temp2, I temp3, O temp4) 
		{
			value1 = temp1;
			value2 = temp2;				
			value3 = temp3;
			value4 = temp4;
		}
        public override string ToString()
        {
            return "Wartosc 1: " + value1 + " Wartosc 2: " + value2 + " Wartosc 3:" + value3 + " Wartosc 4: " + value4;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return ToString() == obj.ToString();
        }
        public int CompareTo(GenericClass<T, U, I, O>? other)
        {
			return value1.CompareTo(other.Value1);
        }
    }
}
