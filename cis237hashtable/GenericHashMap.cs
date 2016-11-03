using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        //Declare a constant for the prime value to use in the Hash Function
        private const int PRIMEVALUE = 97;
        //Declare an array for the values
        TValue[] theValues;
        TKey[] theKeys;
        //Constructor
        public GenericHashMap()
        {
            theValues = new TValue[PRIMEVALUE];
            theKeys = new TKey[PRIMEVALUE];

        }
        //Put function to put a key value pair in to the array/hash table
        public void Put(TKey key, TValue value)
        {
            //Get the index to put the value into
            int indexForValue = hashFunction(key);
            //Store the value in the array
            theValues[indexForValue] = value;
            //Storing the key in a parallel array for later display
            theKeys[indexForValue] = key;
        }
        //Get a value out using the passed in key.
        public TValue Get(TKey key)
        {
            //Get the index to put the value into
            int indexForValue = hashFunction(key);
            //Get the value out of the array with the calculated key
            return theValues[indexForValue];
        }
        //Ye Olde Hash Function
        private int hashFunction(TKey key)
        {
            //Use the built in GetHashCode method that comes from object to 
            //get an integer value that can be modded with the PRIMEVALUE.
            //This will give us and integer between 0 and the PRIMEVALUE.
            return key.GetHashCode() % PRIMEVALUE;
        }
        //Method to print the contents of the array
        public override string ToString()
        {
            string returnString = "\t\tKey => Value";
            returnString += Environment.NewLine + "---------------------------------------------";
            for (int i = 0; i < theValues.Length; i++)
            {
                if (theValues[i] != null)
                {
                    returnString += Environment.NewLine + theKeys[i] + " => " + theValues[i];
                }
            }
            return returnString;
        }
        public string ShowArrays()
        {
            string returnString = "\tIdx - Key => Value";
            returnString += Environment.NewLine + "---------------------------------------------";
            for (int i = 0; i < theValues.Length; i++)
            {
                returnString += Environment.NewLine + "[" + i + "] - " + theKeys[i] + " => " + theValues[i];
            }
            return returnString;
        }

    }


}
