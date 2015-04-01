namespace StringBuilder.Substring
{
    using System.Text;
    using System;
    public static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder text, int index, int length)
        {
            string initial = text.ToString();
            var result = new StringBuilder();
            if (index < 0 || index > initial.Length-1)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            if (length<0||index+length>initial.Length-1)
            {
                throw new ArgumentException("Length must be >= 0 and index + length must be < text.Length");
            }

            for (int i = index; i < index+length; i++)
			{
                result.Append(initial[i]);
			}
            return result;
        }

        public static StringBuilder Substring(this StringBuilder text, int index)
        {
            string initial = text.ToString();
            StringBuilder result = new StringBuilder(initial.Length - index);
            if (index < 0 || index > initial.Length - 1)
            {
                throw new IndexOutOfRangeException("Starting index must be in the range [0, string.Length) and ");
            }
            for (int i = index; i < initial.Length; i++)
            {
                result.Append(initial[i]);
            }
            return result;
        }
    }
}
