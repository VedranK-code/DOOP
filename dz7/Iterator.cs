using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection words;
        private int position = -1;
        private bool reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this.words = collection;
            this.reverse = reverse;

            if (reverse)
            {
                this.position = collection.getItems().Count;
            }
        }
        
        public override object Current()
        {
            return this.words.getItems()[position];
        }

        public override int Key()
        {
            return this.position;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = this.position + (this.reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this.words.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            this.position = this.reverse ? this.words.getItems().Count - 1 : 0;
        }
    }

    class WordsCollection : IteratorAggregate
    {
        List<string> words = new List<string>();
        
        bool direction = false;
        
        public List<string> getItems()
        {
            return words;
        }
        
        public void AddItem(string item)
        {
            this.words.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, direction);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("Small FireBall");
            collection.AddItem("FireBall");
            collection.AddItem("Big FireBall");

            Console.WriteLine("Cast a:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
