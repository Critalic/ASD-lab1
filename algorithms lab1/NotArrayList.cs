﻿using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    
    class NotArrayList
    {
        object[] notArrayList;
        int sizeOfArray = 0;
        bool isLimitedInSize;

        /// constructors
        public NotArrayList(int size)
        {
            this.notArrayList = new object[size];
            this.isLimitedInSize = true;
        }
        public NotArrayList()
        {
            
            this.notArrayList = new object[10];
            this.isLimitedInSize = false;
        }

        //assist methods
        public int size() { return sizeOfArray; }
        public object getElement(int index) 
        {
            try
            {
                if (index < sizeOfArray && index >= 0)
                {
                    return notArrayList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("There is no element under this index ");
                }
            }
            catch (IndexOutOfRangeException e)
            {         
                return e.Message;
            }                
             
        }

        //adding methods
        public void addToTheEnd(object obj)
        {
            if (!isLimitedInSize && (sizeOfArray >= notArrayList.Length/2))
            {
                Array.Resize(ref notArrayList, (notArrayList.Length * 3));
                
            }
            
            notArrayList[sizeOfArray] = obj;
            sizeOfArray++;
            
        }
        public void addToTheBeginning(object obj)
        {
            if(sizeOfArray==0)
            {
                Console.WriteLine("Can't add elements to the beginning of an empty array");
                Environment.Exit(1);
            }
            if (!isLimitedInSize && (sizeOfArray >= notArrayList.Length / 2))
            {
                Array.Resize(ref notArrayList, (notArrayList.Length * 3));

            }
            for (int i= sizeOfArray-1; i>=0 ; i--)
            {
                notArrayList[i + 1] = notArrayList[i];
            }
            notArrayList[0] = obj;
            sizeOfArray++;
        }
        public void addToTheMiddle(object obj, int index)
        {
            if ( index<0)
            {
                Console.WriteLine("Index can't be less than zero");
                Environment.Exit(1);
            }
            else if(sizeOfArray < index )
            {
                Console.WriteLine("Index can't be bigger than the size of the array");
                Environment.Exit(1);
            }
            if (!isLimitedInSize && (sizeOfArray >= notArrayList.Length / 2))
            {
                Array.Resize(ref notArrayList, (notArrayList.Length * 3));

            }
            for (int i = sizeOfArray-1; i >= index-1 ; i--)
            {
                notArrayList[i + 1] = notArrayList[i];
            }
            notArrayList[index - 1] = obj;
            sizeOfArray++;
        }

        //deleting methods
        public void deleteAtTheEnd()
        {
            if (sizeOfArray == 0)
            {
                Console.WriteLine("Can't delete from an empty array");
                Environment.Exit(1);
            }
            sizeOfArray--;
        }
        
        public void deleteAtTheBeginning()
        {
            if (sizeOfArray == 0)
            {
                Console.WriteLine("Can't delete from an empty array");
                Environment.Exit(1);
            }
            object first = notArrayList[sizeOfArray-1 ];
            for (int i=sizeOfArray-1; i>0; i-- )
            {
                object former = notArrayList[i - 1];
                notArrayList[i - 1] = first;
                first = former;
            }
            sizeOfArray--;
        }
        public void deleteInTheMiddle(int position)
        {
            if (sizeOfArray == 0)
            {
                Console.WriteLine("Can't delete from an empty array");
                Environment.Exit(1);
            }
            else if ( position < 0)
            {
                Console.WriteLine("Index can't be less than zero");
                Environment.Exit(1);
            }
            else if(sizeOfArray < position)
            {
                Console.WriteLine("Index can't be bigger than the size of the array");
                Environment.Exit(1);
            }
            object first = notArrayList[sizeOfArray - 1];
            for (int i = sizeOfArray; i > (position-1); i--)
            {
                object former = notArrayList[i - 1];
                notArrayList[i - 1] = first;
                first = former;
            }
            sizeOfArray--;
        }

        // changing methods
        public void changeLast(object obj)
        {
            notArrayList[sizeOfArray - 1] = obj;
        }
        public void changeFirst(object obj)
        {
            notArrayList[0] = obj;
        }
        public void changeMiddle(object obj, int position)
        {
            if (position < 0)
            {
                Console.WriteLine("Index can't be less than zero");
                Environment.Exit(1);
            }
            else if (sizeOfArray < position)
            {
                Console.WriteLine("Index can't be bigger than the size of the array");
                Environment.Exit(1);
            }
            notArrayList[position - 1] = obj;
        }

    }
}
