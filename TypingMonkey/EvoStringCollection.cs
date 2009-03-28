using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TypingMonkey.Entity
{
    /// <summary>
    /// Custom coleciton implementing the ICollection class.
    /// </summary>
    /// <remarks>
    /// Only a few methods implemented.
    /// </remarks>
    class EvoStringCollection:ICollection<EvoString>
    {
        EvoString[] array = null;

        #region ICollection<EvoString> Members

        /// <summary>
        /// Implement Add.
        /// </summary>
        /// <param name="item"></param>
        public void Add(EvoString item)
        {
            if (this.array == null)
            {
                this.array = new EvoString[1];
            }
            else
            {
                EvoString[] buffer = new EvoString[this.array.Length + 1];

                for(int i =0; i<this.array.Length; i++)
                {
                    buffer[i] = this.array[i];
                }

                buffer[this.array.Length] = item;

                this.array = buffer;
            }
        }

        /// <summary>
        /// Implement Clear.
        /// </summary>
        public void Clear()
        {
            this.array = null;
        }

        public bool Contains(EvoString item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(EvoString[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns number of items in our collection.
        /// </summary>
        public int Count
        {
            get
            {
                if (this.array != null)
                {
                    return this.array.Length;
                }
                else 
                {
                    return 0;
                }
            }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(EvoString item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes item at given index.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            if (this.array == null)
            {
                return false;
            }
            else 
            {
                EvoString[] buffer = new EvoString[this.array.Length - 1];

                for (int i = 0; i < this.array.Length; i++)
                {
                    if (i != index)
                    {
                        buffer[i] = this.array[i];
                    }
                }

                this.array = buffer;

                return true;
            }
        }

        #endregion

        #region IEnumerable<EvoString> Members

        public IEnumerator<EvoString> GetEnumerator()
        {
            return (IEnumerator<EvoString>)this.array.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
