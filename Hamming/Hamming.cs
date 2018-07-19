using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
           
                if (current == null)
                {
                     throw new System.ArgumentNullException("current");
                }
                else if(original == null)
                {
                    throw new System.ArgumentNullException("original");
                }
                else if(original.Length != current.Length)
                {
                    
                     throw new System.ArgumentException("Hamming Distance can only be calculated over strings of equal length");
                }
                else
                {
                    
                    for (int i = 0; i < original.Length; i++)
                    {
                        if (original[i] != current[i])
                        {
                            hammingDistance++;
                        }
                    }
                   return hammingDistance;
               }     
        }
    }
}

