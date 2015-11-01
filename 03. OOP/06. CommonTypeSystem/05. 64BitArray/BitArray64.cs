namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }


        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException();
                }

                return (int)((this.Number >> (63 - index)) & 1);
            }

            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                if (value > 1 || value < 0)
                {
                    throw new ArgumentException("The value must be 0 or 1!");
                }

                if (value == 0)
                {
                    this.Number = this.Number & (ulong)(~(1 << (63 - index)));
                }
                else
                {
                    this.Number = this.Number | (ulong)(1 << (63 - index));
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var otherBitArray = obj as BitArray64;
            return this.Number.Equals(otherBitArray.Number);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Number.GetHashCode();
        }
    }
}
