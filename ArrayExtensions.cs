using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Codeavr.ArrayExtensions
{
    public static class ArrayExtensions
    {
        /// <summary>Sets a range of elements in an array to the default value of each element type.</summary>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        public static void Clear<T>(this T[] array)
        {
            Array.Clear(array, 0, array.Length);
        }

        /// <summary>Sets a range of elements in an array to the default value of each element type.</summary>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="fromIndex">The starting index of the range of elements to clear.</param>
        /// <param name="count">The number of elements to clear.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.IndexOutOfRangeException">
        /// <paramref name="fromIndex" /> is less than the lower bound of <paramref name="array" />.-or-
        /// <paramref name="count" /> is less than zero.-or-The sum of <paramref name="fromIndex" /> and <paramref name="count" /> is greater than the size of <paramref name="array" />.</exception>
        public static void Clear<T>(this T[] array, int fromIndex, int count)
        {
            Array.Clear(array, fromIndex, count);
        }

        /// <summary>Determines whether the specified array contains elements that match the conditions defined by the specified predicate.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the elements to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>
        /// <see langword="true" /> if <paramref name="array" /> contains one or more elements that match the conditions defined by the specified predicate; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static bool Exists<T>(this T[] array, Predicate<T> match)
        {
            return Array.Exists(array, match);
        }

        /// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional, zero-based array to search.</param>
        /// <param name="match">The predicate that defines the conditions of the element to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <paramref name="T" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }

        /// <summary>Retrieves all the elements that match the conditions defined by the specified predicate.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the elements to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>An <see cref="T:System.Array" /> containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty <see cref="T:System.Array" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }

        /// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static int FindIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindIndex(array, match);
        }

        /// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, –1.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLastIndex(array, match);
        }

        /// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <paramref name="T" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static T FindLast<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLast(array, match);
        }

        /// <summary>Performs the specified action on each element of the specified array.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> on whose elements the action is to be performed.</param>
        /// <param name="action">The <see cref="T:System.Action`1" /> to perform on each element of <paramref name="array" />.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="action" /> is <see langword="null" />.</exception>
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }

        /// <summary>Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.</summary>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <returns>The index of the first occurrence of <paramref name="value" /> in <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.RankException">
        /// <paramref name="array" /> is multidimensional.</exception>
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>Searches for the specified object and returns the index of the last occurrence within the entire <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, –1.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        public static int LastIndexOf<T>(this T[] array, T value)
        {
            return Array.LastIndexOf(array, value);
        }

        /// <summary>Reverses the sequence of the elements in the entire one-dimensional <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />. </exception>
        /// <exception cref="T:System.RankException">
        /// <paramref name="array" /> is multidimensional. </exception>
        public static void Reverse<T>(this T[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>Sorts the elements in an entire one-dimensional <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each element of the <see cref="T:System.Array" />.</summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.RankException">
        /// <paramref name="array" /> is multidimensional.</exception>
        /// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
        public static void Sort<T>(this T[] array)
        {
            Array.Sort(array);
        }

        /// <summary>Sorts the elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
        /// <param name="array">The one-dimensional, zero-base <see cref="T:System.Array" /> to sort</param>
        /// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
        /// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
        public static void Sort<T>(this T[] array, IComparer<T> comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>Determines whether every element in the array matches the conditions defined by the specified predicate.</summary>
        /// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to check against the conditions.</param>
        /// <param name="match">The predicate that defines the conditions to check against the elements.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>
        /// <see langword="true" /> if every element in <paramref name="array" /> matches the conditions defined by the specified predicate; otherwise, <see langword="false" />. If there are no elements in the array, the return value is <see langword="true" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.-or-
        /// <paramref name="match" /> is <see langword="null" />.</exception>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }

        /// <summary>Searches an entire one-dimensional sorted array for a specific element, using the <see cref="T:System.IComparable`1" /> generic interface implemented by each element of the <see cref="T:System.Array" /> and by the specified object.</summary>
        /// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
        public static int BinarySearch<T>(this T[] array, T value)
        {
            return Array.BinarySearch(array, value);
        }

        /// <summary>Returns a read-only wrapper for the specified array.</summary>
        /// <param name="array">The one-dimensional, zero-based array to wrap in a read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />  wrapper.</param>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>A read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> wrapper for the specified array.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array" /> is <see langword="null" />.</exception>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
        {
            return Array.AsReadOnly(array);
        }

        /// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 32-bit integers.</summary>
        /// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
        /// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="sourceArray" /> is <see langword="null" />.-or-
        /// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.RankException">
        /// <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
        /// <exception cref="T:System.ArrayTypeMismatchException">
        /// <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
        /// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.-or-
        /// <paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.-or-
        /// <paramref name="length" /> is less than zero.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.-or-
        /// <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
        public static void Copy<T>(this T[] sourceArray, int sourceIndex, T[] destinationArray, int destinationIndex, int length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
    }
}